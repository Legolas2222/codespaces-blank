using MongoDB.Driver;

namespace TodoistClone.Infrastructure.Persistence.Config
{
    public class MongoDBDatabaseSettings
    {
        public MongoDBDatabaseSettings(string connectionString, string DatabaseName, string todoItemCollectionName) 
        {
            this.ConnectionString = connectionString;
            this.TodoItemCollectionName = todoItemCollectionName;
            this.DatabaseName = DatabaseName;
   
        }
        public string ConnectionString { get; init; }
        public string DatabaseName { get; init; }
        public string TodoItemCollectionName { get; init; }
        public IMongoDatabase GetDatabase()
        {
            var client = new MongoClient(this.ConnectionString);
            return client.GetDatabase(this.DatabaseName);
        }
    }
}