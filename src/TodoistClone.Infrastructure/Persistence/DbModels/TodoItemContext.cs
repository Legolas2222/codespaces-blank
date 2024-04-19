using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using TodoistClone.Domain.Entities;
namespace TodoistClone.Infrastructure.Persistence.DbModels
{
    public class TodoItemContext : DbContext
    {
        public DbSet<TodoItem> TodoItems { get; init; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }


        public TodoItemContext(DbContextOptions<TodoItemContext> options) : base(options)
        {

        }
    }
}
