using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using TodoistClone.Infrastructure.Persistence.DbModels;

namespace TodoistClone.Infrastructure.Persistence
{
    public class TodoItemRepositoryDb : ITodoItemRepository
    {
        private readonly TodoItemContext _context;
        public TodoItemRepositoryDb(TodoItemContext context)
        {
            _context = context;
        }   

        public Task Add(TodoItem item)
        {
            _context.Add(item);
            return _context.SaveChangesAsync();
            
        }

        public Task Delete(Guid id)
        {
            _context.Remove(id);
            return _context.SaveChangesAsync();
        }

        public Task<List<TodoItem>> GetAllAsync()
        {
            return _context.TodoItems.ToListAsync();

        }

        public Task<TodoItem?> GetByIdAsync(Guid id)
        {
            return _context.TodoItems.FindAsync(id).AsTask();
        }

        public Task Update(Guid id, string? NewTitle, string? NewDescription)
        {
            var item = _context.TodoItems.FirstOrDefault(x => x.Id == id);
            if (item is null)
            {
                throw new Exception("Item not found");
            }
            item.Update(NewTitle, NewDescription);
            return _context.SaveChangesAsync();
        }
    }
}
