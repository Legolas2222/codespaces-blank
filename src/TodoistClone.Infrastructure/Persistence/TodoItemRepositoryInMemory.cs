using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Domain.Entities;

namespace TodoistClone.Infrastructure.Persistence;

public class TodoItemRepositoryInMemory : ITodoItemRepository
{
    private static List<TodoItem> todos = [];  
    public async Task<TodoItem> GetByIdAsync(Guid id)
    {
        var item = todos.Find(x => x.Id == id);
        return item is null ? throw new Exception("Provided ID did not match a db entry") : item;
    }
    public async Task<List<TodoItem>> GetAllAsync()
    {
        return todos;
    }

    public async Task Add(TodoItem item)
    {
        todos.Add(item);
    }

    public async Task Update(Guid id, string? NewTitle, string? NewDescription)
    {
        var item = todos.Find(x => x.Id == id);
        if (item is not null)
        {
            todos.Remove(item);
            item.Update(NewTitle, NewDescription);
            todos.Add(item);
        }
        if (item is null)
        {
            throw new Exception("Provided ID did not match a db entry");
        }



    }
    public async Task Delete(Guid id)
    {
        var item = todos.Find(x => x.Id == id);
        if (item is not null)
        {
            todos.Remove(item);
        }

    }


}