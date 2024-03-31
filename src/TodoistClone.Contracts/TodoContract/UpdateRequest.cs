namespace TodoistClone.Contracts.TodoContract;

public record TodoUpdateRequest(
    Guid Id,
    string NewTitle,
    string NewDescription,
    bool NewCompletionStatus);