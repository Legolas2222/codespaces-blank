using TodoistClone.Contracts.TodoContract.GetById;

namespace TodoistClone.Contracts.TodoContract.GetAll;

public record TodoGetAllResponse
(
    List<TodoGetResponse> Todos
);