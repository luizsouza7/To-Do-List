using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using To_Do_List.Models;


namespace To_Do_List
{
    public class TodoContext : DbContext
    {
        public TodoContext()
            : base("name=TodoConnection") // nome da sua connection string
        {
        }

        // Tabelas do banco viram DbSet
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Tarefa> Tarefas { get; set; }
    }
}