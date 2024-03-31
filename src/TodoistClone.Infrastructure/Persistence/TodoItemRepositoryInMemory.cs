using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Domain.Entities;

namespace TodoistClone.Infrastructure.Persistence;

public class TodoItemRepositoryInMemory : ITodoItemRepository
{
    private List<TodoItem> todos = new();
    public async Task<TodoItem> GetById(Guid id)
    {
        var item = todos.Find(x => x.Id == id);
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

    public async Task<Guid> Update(Guid id, string NewTitle, string NewDescription, bool NewCompletionStatus)
    {
        var item = todos.Find(x => x.Id == id);
        if (item is not null)
        {
            todos.Remove(item);
            item.Update(NewTitle, NewDescription);
            todos.Add(item);
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