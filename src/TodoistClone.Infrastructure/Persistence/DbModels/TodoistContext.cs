using Microsoft.EntityFrameworkCore;
using MongoDB.Driver;
using MongoDB.Driver.Core.Configuration;
using TodoistClone.Domain.Entities;
namespace TodoistClone.Infrastructure.Persistence.DbModels
{
    public class TodoistContext : DbContext
    {
        private readonly string _connectionString;

        public DbSet<TodoItem> TodoItems { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMongoDB(new MongoClient(_connectionString), "TodosDev");
            base.OnConfiguring(optionsBuilder);
        }

        public TodoistContext(string connectionString)
        {
            _connectionString = connectionString;
        }
    }
}
