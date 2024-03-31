using TodoistClone.Contracts.TodoContract.GetById;

namespace TodoistClone.Contracts.TodoContract.GetAll;

public record GetAllResponse
(
    List<TodoGetResponse> Todos
);