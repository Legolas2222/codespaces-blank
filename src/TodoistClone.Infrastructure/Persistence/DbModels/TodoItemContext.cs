using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using TodoistClone.Domain.Entities;

namespace TodoistClone.Infrastructure.Persistence.DbModels
{
    internal class TodoItemContext : DbContext
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

        public static TodoItemContext Create(IMongoDatabase db)
        {
            var options = new DbContextOptionsBuilder<TodoItemContext>()
                .UseMongoDB(db.Client, db.DatabaseNamespace.DatabaseName)
                .Options;
                

            return new TodoItemContext(options);
        }

        public TodoItemContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
