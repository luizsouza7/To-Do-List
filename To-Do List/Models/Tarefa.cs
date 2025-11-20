using System;

namespace To_Do_List.Models
{
    public class Tarefa
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Titulo { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string Prioridade { get; set; } = string.Empty;
        public string Status { get; set; } = string.Empty;
        public DateTime DataPrevista { get; set; } = DateTime.Today;
        public DateTime CriadoEm { get; set; } = DateTime.Now;
    }
}