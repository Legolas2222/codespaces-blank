using TodoistClone.Domain.Entities;

namespace TodoistClone.Application.Common.Interfaces.Persistence;

public interface ITodoItemRepository
{
    public Task<TodoItem> GetById(Guid id);
    public Task<IEnumerable<TodoItem>> GetAll();
    public Task<Guid> Add(TodoItem item);
    public Task<Guid> Update(Guid id, string? NewTitle, string? NewDescription);
    public Task<bool> Delete(Guid id);

}