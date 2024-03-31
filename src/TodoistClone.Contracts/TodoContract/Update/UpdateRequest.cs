namespace TodoistClone.Contracts.TodoContract.Update;

public record TodoUpdateRequest(
    Guid Id,
    string? NewTitle,
    string? NewDescription
    );