using System;

namespace To_Do_List.Models
{
    public class Tarefa
    {
        // Identificador único da tarefa (usado como Guid pelo controller)
        public Guid Id { get; set; }

        // Referência ao usuário como Guid (compatível com _usuarioId no controller)
        public Guid UsuarioId { get; set; }

        // Campos principais da tarefa
        public string Titulo { get; set; } = string.Empty;
        public string? Descricao { get; set; }
        public string Prioridade { get; set; } = "Normal";
        public string Status { get; set; } = "Pendente";

        // Data prevista para execução (opcional)
        public DateTime? DataPrevista { get; set; }

        // Data de criação usada pelo controller (tarefa.CriadoEm)
        public DateTime CriadoEm { get; set; }

        // Propriedade de navegação opcional
        // public Usuario? Usuario { get; set; }
    }
}

