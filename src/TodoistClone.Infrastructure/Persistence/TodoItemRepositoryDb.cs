using Microsoft.EntityFrameworkCore;
using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Domain.Entities;
using TodoistClone.Infrastructure.Persistence.DbModels;

namespace TodoistClone.Infrastructure.Persistence
{
    internal class TodoItemRepositoryDb : BaseRepository<TodoItem>, ITodoItemRepository
    {
        public TodoItemRepositoryDb(TodoItemContext context) : base(context)
        {

        }

        public Task<List<TodoItem>> GetAllAsync()
        {
            return dbContext.Set<TodoItem>().ToListAsync();
        }

        public Task<TodoItem?> GetByIdAsync(Guid id)
        {
            return dbContext.Set<TodoItem>().FindAsync(id).AsTask();
        }
    }
}
