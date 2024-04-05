using Microsoft.EntityFrameworkCore;
using TodoistClone.Domain.Entities;

namespace TodoistClone.Infrastructure.Persistence.DbModels
{
    public class TodoItemContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
    }
}
