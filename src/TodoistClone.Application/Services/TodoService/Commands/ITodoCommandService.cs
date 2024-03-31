using TodoistClone.Application.Services.TodoService.Commands.DTOs.Create;
using TodoistClone.Application.Services.TodoService.Commands.DTOs.Delete;
using TodoistClone.Application.Services.TodoService.Commands.DTOs.Update;
using TodoistClone.Application.Services.TodoService.Common.DTOs;

namespace TodoistClone.Application.Services.TodoService.Commands;

public interface ITodoCommandService
{
    Task<TodoItemCreateResult> Add(TodoItemCreateRequest request);
    Task<TodoItemUpdateResult> Update(TodoItemUpdateRequest newTodo);
    Task<TodoItemDeleteResult> Delete(TodoItemDeleteRequest request);
}