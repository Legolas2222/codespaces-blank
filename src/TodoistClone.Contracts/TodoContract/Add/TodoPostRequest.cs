namespace TodoistClone.Contracts.TodoContract.Add;

public record TodoPostRequest(
    string Title,
    string Description,
    bool Done
);