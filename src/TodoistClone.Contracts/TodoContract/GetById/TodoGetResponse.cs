namespace TodoistClone.Contracts.TodoContract.GetById
{
    public record TodoGetResponse(
        Guid Id,
        string Title,
        string Description,
        bool Done
    );
}