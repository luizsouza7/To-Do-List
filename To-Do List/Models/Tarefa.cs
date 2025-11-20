using System;

namespace To_Do_List.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string Prioridade { get; set; }
        public string Status { get; set; }
        public DateTime? DataPrevista { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}

