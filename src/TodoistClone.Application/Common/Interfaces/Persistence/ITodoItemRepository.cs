using TodoistClone.Domain.Entities;

namespace TodoistClone.Application.Common.Interfaces.Persistence;

public interface ITodoItemRepository
{
    public Task<TodoItem?> GetByIdAsync(Guid id);
    public Task<List<TodoItem>> GetAllAsync();
    public Task Add(TodoItem item);
    public Task Update(Guid id, string? NewTitle, string? NewDescription);
    public Task Delete(Guid id);

}