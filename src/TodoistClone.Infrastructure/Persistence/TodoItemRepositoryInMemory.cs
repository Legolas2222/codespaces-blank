using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Domain.Entities;

namespace TodoistClone.Infrastructure.Persistence;

public class TodoItemRepositoryInMemory : ITodoItemRepository
{
    private static List<TodoItem> todos = new();
    public async Task<TodoItem> GetById(Guid id)
    {
        var item = todos.Find(x => x.Id == id);
        if (item is null)
        {
            throw new Exception("Provided ID did not match a db entry");
        }
        return item;
    }
    public async Task<IEnumerable<TodoItem>> GetAll()
    {
        return todos.AsEnumerable<TodoItem>();
    }

    public async Task<Guid> Add(TodoItem item)
    {
        todos.Add(item);
        return item.Id;
    }

    public async Task<Guid> Update(Guid id, string? NewTitle, string? NewDescription)
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
        return item.Id;


    }
    public async Task<bool> Delete(Guid id)
    {
        var item = todos.Find(x => x.Id == id);
        if (item is not null)
        {
            todos.Remove(item);
            return true;
        }
        return false;
    }


}