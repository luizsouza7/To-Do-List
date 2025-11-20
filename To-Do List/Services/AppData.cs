using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List.Services
{
    internal static class AppData
    {
        private static readonly object SyncRoot = new();

        public static Usuario? UsuarioLogado { get; private set; }

        private static TodoContext CriarContexto()
        {
            return new TodoContext();
        }

        private static void GarantirBancoCriado()
        {
            using var context = CriarContexto();
            context.Database.EnsureCreated();
            
            if (!context.Usuarios.Any(u => u.Email == "admin@todo.com"))
            {
                context.Usuarios.Add(new Usuario
                {
                    Nome = "Administrador",
                    Email = "admin@todo.com",
                    Senha = "123"
                });
                context.SaveChanges();
            }
        }

        static AppData()
        {
            try
            {
                GarantirBancoCriado();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao inicializar banco de dados: {ex.Message}");
            }
        }

        public static bool Autenticar(string email, string senha, out string mensagem)
        {
            mensagem = string.Empty;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                mensagem = "Informe e-mail e senha.";
                return false;
            }

            try
            {
                using var context = CriarContexto();
                var emailLower = email.ToLower();
                var usuario = context.Usuarios
                    .FirstOrDefault(u => u.Email.ToLower() == emailLower);

                if (usuario == null || usuario.Senha != senha)
                {
                    mensagem = "Usuário ou senha inválidos.";
                    return false;
                }

                UsuarioLogado = usuario;
                return true;
            }
            catch (Exception ex)
            {
                mensagem = $"Erro ao autenticar: {ex.Message}";
                return false;
            }
        }

        public static bool RegistrarUsuario(string nome, string email, string senha, out string mensagem)
        {
            mensagem = string.Empty;
            if (string.IsNullOrWhiteSpace(nome) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(senha))
            {
                mensagem = "Preencha todos os campos.";
                return false;
            }

            try
            {
                using var context = CriarContexto();
                var emailLower = email.ToLower();
                
                if (context.Usuarios.Any(u => u.Email.ToLower() == emailLower))
                {
                    mensagem = "Já existe um usuário com esse e-mail.";
                    return false;
                }

                var novoUsuario = new Usuario
                {
                    Nome = nome.Trim(),
                    Email = email.Trim(),
                    Senha = senha
                };

                context.Usuarios.Add(novoUsuario);
                context.SaveChanges();
                
                mensagem = "Conta criada com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = $"Erro ao registrar usuário: {ex.Message}";
                return false;
            }
        }

        public static void Deslogar()
        {
            UsuarioLogado = null;
        }

        public static bool AtualizarSenha(string novaSenha, out string mensagem)
        {
            mensagem = string.Empty;
            if (UsuarioLogado == null)
            {
                mensagem = "Nenhum usuário autenticado.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                mensagem = "A nova senha não pode ser vazia.";
                return false;
            }

            try
            {
                using var context = CriarContexto();
                var usuario = context.Usuarios.Find(UsuarioLogado.Id);
                
                if (usuario == null)
                {
                    mensagem = "Usuário não encontrado.";
                    return false;
                }

                usuario.Senha = novaSenha;
                context.SaveChanges();
                
                UsuarioLogado.Senha = novaSenha;
                
                mensagem = "Senha atualizada com sucesso.";
                return true;
            }
            catch (Exception ex)
            {
                mensagem = $"Erro ao atualizar senha: {ex.Message}";
                return false;
            }
        }

        public static void SalvarTarefa(Tarefa tarefa)
        {
            if (UsuarioLogado == null)
            {
                throw new InvalidOperationException("Nenhum usuário autenticado.");
            }

            try
            {
                using var context = CriarContexto();
                
                if (tarefa.Id == Guid.Empty || !context.Tarefas.Any(t => t.Id == tarefa.Id))
                {
                    tarefa.Id = Guid.NewGuid();
                    tarefa.UsuarioId = UsuarioLogado.Id;
                    tarefa.CriadoEm = DateTime.Now;
                    context.Tarefas.Add(tarefa);
                }
                else
                {
                    var existent = context.Tarefas
                        .FirstOrDefault(t => t.Id == tarefa.Id && t.UsuarioId == UsuarioLogado.Id);
                    
                    if (existent == null)
                    {
                        throw new InvalidOperationException("Tarefa não encontrada ou não pertence ao usuário.");
                    }

                    existent.Titulo = tarefa.Titulo;
                    existent.Descricao = tarefa.Descricao;
                    existent.Prioridade = tarefa.Prioridade;
                    existent.Status = tarefa.Status;
                    existent.DataPrevista = tarefa.DataPrevista;
                }

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new InvalidOperationException($"Erro ao salvar tarefa: {ex.Message}", ex);
            }
        }

        public static bool ExcluirTarefa(Guid tarefaId)
        {
            if (UsuarioLogado == null)
            {
                return false;
            }

            try
            {
                using var context = CriarContexto();
                var tarefa = context.Tarefas
                    .FirstOrDefault(t => t.Id == tarefaId && t.UsuarioId == UsuarioLogado.Id);
                
                if (tarefa != null)
                {
                    context.Tarefas.Remove(tarefa);
                    context.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao excluir tarefa: {ex.Message}");
                return false;
            }
        }

        public static Tarefa? ObterTarefaPorId(Guid tarefaId)
        {
            if (UsuarioLogado == null)
            {
                return null;
            }

            try
            {
                using var context = CriarContexto();
                return context.Tarefas
                    .FirstOrDefault(t => t.Id == tarefaId && t.UsuarioId == UsuarioLogado.Id);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao obter tarefa: {ex.Message}");
                return null;
            }
        }

        public static IReadOnlyList<Tarefa> ObterTodasTarefas()
        {
            if (UsuarioLogado == null)
            {
                return new List<Tarefa>();
            }

            try
            {
                using var context = CriarContexto();
                return context.Tarefas
                    .Where(t => t.UsuarioId == UsuarioLogado.Id)
                    .OrderBy(t => t.DataPrevista)
                    .ThenBy(t => t.Titulo)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao obter tarefas: {ex.Message}");
                return new List<Tarefa>();
            }
        }

        public static IReadOnlyList<Tarefa> ObterTarefasPorPeriodo(DateTime inicio, DateTime fim)
        {
            if (UsuarioLogado == null)
            {
                return new List<Tarefa>();
            }

            if (inicio > fim)
            {
                (inicio, fim) = (fim, inicio);
            }

            try
            {
                using var context = CriarContexto();
                return context.Tarefas
                    .Where(t => t.UsuarioId == UsuarioLogado.Id &&
                                t.DataPrevista.HasValue &&
                                t.DataPrevista.Value.Date >= inicio.Date &&
                                t.DataPrevista.Value.Date <= fim.Date)
                    .OrderBy(t => t.DataPrevista)
                    .ThenBy(t => t.Titulo)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao obter tarefas: {ex.Message}");
                return new List<Tarefa>();
            }
        }

        public static IReadOnlyList<Tarefa> BuscarTarefas(string filtro)
        {
            if (UsuarioLogado == null)
            {
                return new List<Tarefa>();
            }

            if (string.IsNullOrWhiteSpace(filtro))
            {
                return ObterTodasTarefas();
            }

            try
            {
                using var context = CriarContexto();
                var filtroLower = filtro.ToLower();
                return context.Tarefas
                    .Where(t => t.UsuarioId == UsuarioLogado.Id &&
                                (t.Titulo.ToLower().Contains(filtroLower) ||
                                 (t.Descricao != null && t.Descricao.ToLower().Contains(filtroLower)) ||
                                 t.Prioridade.ToLower().Contains(filtroLower) ||
                                 t.Status.ToLower().Contains(filtroLower)))
                    .OrderBy(t => t.DataPrevista)
                    .ThenBy(t => t.Titulo)
                    .ToList();
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Erro ao buscar tarefas: {ex.Message}");
                return new List<Tarefa>();
            }
        }
    }
}
