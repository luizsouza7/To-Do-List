using System;
using System.Collections.Generic;
using System.Linq;
using To_Do_List.Models;

namespace To_Do_List.Services
{
    internal static class AppData
    {
        private static readonly List<Usuario> Usuarios = new();
        private static readonly List<Tarefa> Tarefas = new();
        private static readonly object SyncRoot = new();

        static AppData()
        {
            Usuarios.Add(new Usuario
            {
                Nome = "Administrador",
                Email = "admin@todo.com",
                Senha = "123"
            });
        }

        public static Usuario? UsuarioLogado { get; private set; }

        public static bool Autenticar(string email, string senha, out string mensagem)
        {
            mensagem = string.Empty;
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                mensagem = "Informe e-mail e senha.";
                return false;
            }

            lock (SyncRoot)
            {
                var usuario = Usuarios.FirstOrDefault(u =>
                    string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase));

                if (usuario == null || usuario.Senha != senha)
                {
                    mensagem = "Usuário ou senha inválidos.";
                    return false;
                }

                UsuarioLogado = usuario;
                return true;
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

            lock (SyncRoot)
            {
                if (Usuarios.Any(u =>
                        string.Equals(u.Email, email, StringComparison.OrdinalIgnoreCase)))
                {
                    mensagem = "Já existe um usuário com esse e-mail.";
                    return false;
                }

                Usuarios.Add(new Usuario
                {
                    Nome = nome.Trim(),
                    Email = email.Trim(),
                    Senha = senha
                });
                mensagem = "Conta criada com sucesso.";
                return true;
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

            lock (SyncRoot)
            {
                UsuarioLogado.Senha = novaSenha;
                mensagem = "Senha atualizada com sucesso.";
                return true;
            }
        }

        public static void SalvarTarefa(Tarefa tarefa)
        {
            lock (SyncRoot)
            {
                var existente = Tarefas.FirstOrDefault(t => t.Id == tarefa.Id);
                if (existente == null)
                {
                    tarefa.CriadoEm = DateTime.Now;
                    Tarefas.Add(tarefa);
                }
                else
                {
                    existente.Titulo = tarefa.Titulo;
                    existente.Descricao = tarefa.Descricao;
                    existente.Prioridade = tarefa.Prioridade;
                    existente.Status = tarefa.Status;
                    existente.DataPrevista = tarefa.DataPrevista;
                }
            }
        }

        public static IReadOnlyList<Tarefa> ObterTarefasPorPeriodo(DateTime inicio, DateTime fim)
        {
            if (inicio > fim)
            {
                (inicio, fim) = (fim, inicio);
            }

            lock (SyncRoot)
            {
                return Tarefas
                    .Where(t => t.DataPrevista.Date >= inicio.Date && t.DataPrevista.Date <= fim.Date)
                    .OrderBy(t => t.DataPrevista)
                    .ThenBy(t => t.Titulo)
                    .ToList();
            }
        }
    }
}

