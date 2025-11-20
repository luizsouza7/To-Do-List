using System;
using System.Collections.Generic;
using System.Linq;
using To_Do_List.Models;

namespace To_Do_List.Controllers
{
    public class TarefaController
    {
        private readonly TodoContext _context;
        private readonly Guid _usuarioId;

        public TarefaController(Guid usuarioId)
        {
            _context = new TodoContext();
            _usuarioId = usuarioId;
        }

        public void Criar(Tarefa tarefa)
        {
            tarefa.Id = Guid.NewGuid();
            tarefa.UsuarioId = _usuarioId;
            tarefa.CriadoEm = DateTime.Now;
            
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
        }

        public void Atualizar(Tarefa tarefa)
        {
            var existente = _context.Tarefas
                .FirstOrDefault(t => t.Id == tarefa.Id && t.UsuarioId == _usuarioId);
            
            if (existente == null)
                throw new InvalidOperationException("Tarefa não encontrada ou não pertence ao usuário.");

            existente.Titulo = tarefa.Titulo;
            existente.Descricao = tarefa.Descricao;
            existente.Prioridade = tarefa.Prioridade;
            existente.Status = tarefa.Status;
            existente.DataPrevista = tarefa.DataPrevista;
            
            _context.SaveChanges();
        }

        public void Salvar(Tarefa tarefa)
        {
            if (tarefa.Id == Guid.Empty || !_context.Tarefas.Any(t => t.Id == tarefa.Id))
            {
                Criar(tarefa);
            }
            else
            {
                Atualizar(tarefa);
            }
        }

        public bool Excluir(Guid tarefaId, out string mensagem)
        {
            mensagem = string.Empty;
            var tarefa = _context.Tarefas
                .FirstOrDefault(t => t.Id == tarefaId && t.UsuarioId == _usuarioId);
            
            if (tarefa == null)
            {
                mensagem = "Tarefa não encontrada.";
                return false;
            }

            _context.Tarefas.Remove(tarefa);
            _context.SaveChanges();
            
            mensagem = "Tarefa excluída com sucesso.";
            return true;
        }

        public Tarefa? ObterPorId(Guid id)
        {
            return _context.Tarefas
                .FirstOrDefault(t => t.Id == id && t.UsuarioId == _usuarioId);
        }

        public IReadOnlyList<Tarefa> ListarTodas()
        {
            return _context.Tarefas
                .Where(t => t.UsuarioId == _usuarioId)
                .OrderBy(t => t.DataPrevista)
                .ThenBy(t => t.Titulo)
                .ToList();
        }

        public IReadOnlyList<Tarefa> BuscarPorPeriodo(DateTime inicio, DateTime fim)
        {
            if (inicio > fim)
                (inicio, fim) = (fim, inicio);

            return _context.Tarefas
                .Where(t => t.UsuarioId == _usuarioId &&
                            t.DataPrevista.HasValue &&
                            t.DataPrevista.Value.Date >= inicio.Date &&
                            t.DataPrevista.Value.Date <= fim.Date)
                .OrderBy(t => t.DataPrevista)
                .ThenBy(t => t.Titulo)
                .ToList();
        }

        public IReadOnlyList<Tarefa> Buscar(string filtro)
        {
            if (string.IsNullOrWhiteSpace(filtro))
                return ListarTodas();

            var filtroLower = filtro.ToLower();
            return _context.Tarefas
                .Where(t => t.UsuarioId == _usuarioId &&
                            (t.Titulo.ToLower().Contains(filtroLower) ||
                             (t.Descricao != null && t.Descricao.ToLower().Contains(filtroLower)) ||
                             t.Prioridade.ToLower().Contains(filtroLower) ||
                             t.Status.ToLower().Contains(filtroLower)))
                .OrderBy(t => t.DataPrevista)
                .ThenBy(t => t.Titulo)
                .ToList();
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}

