using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Webinar2Todo.Application.ViewModels;

namespace Webinar2Todo.Application.Interfaces
{
    public interface ITodoService
    {
        Task<TodoListListVm> GetAllTodoLists();
        Task<TodoListVm> GetTodoListById(int id);

        Task<TodoItemListVm> GetTodoItemsForList(int listId);

        Task<TodoItemListVm> GetAllTodoItems();
        Task<int> InsertTodoList(TodoListVm todoList);
        Task DeleteTodoList(int todoListId);
        Task<int> InsertTodoItem(TodoItemVm todoItem);
        Task DeleteTodoItem(int todoItemId);
        Task UpdateTodoItem(TodoItemVm todoItem);
    }
}
