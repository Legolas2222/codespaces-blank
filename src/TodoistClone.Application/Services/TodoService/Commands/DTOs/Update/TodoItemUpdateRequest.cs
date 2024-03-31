namespace TodoistClone.Application.Services.TodoService.Commands.DTOs.Update
{
    public record TodoItemUpdateRequest(
        Guid Id,
        string? NewTitle,
        string? NewDescription);
}
