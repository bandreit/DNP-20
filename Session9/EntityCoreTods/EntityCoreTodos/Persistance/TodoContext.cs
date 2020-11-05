using AdvancedTodoWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityCoreTodos.Persistance
{
    public class TodoContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = Todos.db");
        }
    }
}