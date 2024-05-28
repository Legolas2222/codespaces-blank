using MongoDB.Driver;
using TodoistClone.Domain.Entities;

namespace TodoistClone.Infrastructure.Persistence.config
{
    public class TodosContext : ITodosContext
    {
        public TodosContext(string ConnectionString, string DatabaseName, string CollectionName)
        {
            var client = new MongoClient(ConnectionString);
            var database = client.GetDatabase(DatabaseName);

            TodoItems = database.GetCollection<TodoItem>(CollectionName);
        }
           
        public IMongoCollection<TodoItem> TodoItems { get; }

    }
}