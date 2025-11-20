using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using To_Do_List.Models;

namespace To_Do_List.Controllers
{
    public class UsuarioController
    {
        private readonly TodoContext _context;

        public UsuarioController()
        {
            _context = new TodoContext();
        }

        public Usuario? Autenticar(string email, string senha)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
                return null;

            var emailLower = email.ToLower();
            return _context.Usuarios
                .FirstOrDefault(u => u.Email.ToLower() == emailLower && u.Senha == senha);
        }

        public bool Registrar(string nome, string email, string senha, out string mensagem)
        {
            mensagem = string.Empty;
            
            if (string.IsNullOrWhiteSpace(nome) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(senha))
            {
                mensagem = "Preencha todos os campos.";
                return false;
            }

            var emailLower = email.ToLower();
            if (_context.Usuarios.Any(u => u.Email.ToLower() == emailLower))
            {
                mensagem = "Já existe um usuário com esse e-mail.";
                return false;
            }

            var usuario = new Usuario
            {
                Nome = nome.Trim(),
                Email = email.Trim(),
                Senha = senha
            };

            _context.Usuarios.Add(usuario);
            _context.SaveChanges();
            
            mensagem = "Conta criada com sucesso.";
            return true;
        }

        public bool AtualizarSenha(Guid usuarioId, string novaSenha, out string mensagem)
        {
            mensagem = string.Empty;
            
            if (string.IsNullOrWhiteSpace(novaSenha))
            {
                mensagem = "A nova senha não pode ser vazia.";
                return false;
            }

            var usuario = _context.Usuarios.Find(usuarioId);
            if (usuario == null)
            {
                mensagem = "Usuário não encontrado.";
                return false;
            }

            usuario.Senha = novaSenha;
            _context.SaveChanges();
            
            mensagem = "Senha atualizada com sucesso.";
            return true;
        }

        public Usuario? ObterPorId(Guid id)
        {
            return _context.Usuarios.Find(id);
        }

        public IReadOnlyList<Usuario> ListarTodos()
        {
            return _context.Usuarios.OrderBy(u => u.Nome).ToList();
        }

        public bool Excluir(Guid id, out string mensagem)
        {
            mensagem = string.Empty;
            var usuario = _context.Usuarios.Find(id);
            
            if (usuario == null)
            {
                mensagem = "Usuário não encontrado.";
                return false;
            }

            _context.Usuarios.Remove(usuario);
            _context.SaveChanges();
            
            mensagem = "Usuário excluído com sucesso.";
            return true;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}

