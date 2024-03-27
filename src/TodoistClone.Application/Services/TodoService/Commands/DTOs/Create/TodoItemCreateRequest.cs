namespace TodoistClone.Application.Services.TodoService.Commands.DTOs.Create;

public record TodoItemCreateRequest(
    string Title,
    string Description,
    bool Done);