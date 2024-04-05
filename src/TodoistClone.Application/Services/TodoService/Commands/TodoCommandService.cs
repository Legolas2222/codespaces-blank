using System.ComponentModel;
using TodoistClone.Application.Common.Interfaces.Persistence;
using TodoistClone.Application.Services.TodoService.Commands.DTOs.Create;
using TodoistClone.Application.Services.TodoService.Commands.DTOs.Delete;
using TodoistClone.Application.Services.TodoService.Commands.DTOs.Update;
using TodoistClone.Application.Services.TodoService.Common.DTOs;
using TodoistClone.Domain.Entities;

namespace TodoistClone.Application.Services.TodoService.Commands;

public class TodoCommandService(ITodoItemRepository todoitemrepository) : ITodoCommandService
{
    private readonly ITodoItemRepository _todoitemrepository = todoitemrepository;

    public Task Add(TodoItemCreateRequest request)
    {
        //!Validation 
        var todoItem = new TodoItem( 
            request.Title,
            request.Description,
            request.Done
        );

        return _todoitemrepository.Add(todoItem);
    }

    public Task Delete(TodoItemDeleteRequest request)
    { 
        //!Validation 
        return _todoitemrepository.Delete(request.Id);

    }

    public Task Update(TodoItemUpdateRequest data)
    {
        //!Validation

        return _todoitemrepository.Update(data.Id, data.NewTitle, data.NewDescription);


    }
}