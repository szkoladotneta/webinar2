using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webinar2Todo.Domain.Model;

namespace Webinar2Todo.Domain.Interfaces
{
    public interface ITodoItemRepository
    {
        IQueryable<TodoItem> GetAll();
        TodoItem GetItemById(int id);
        IQueryable<TodoItem> GetTodoItemsForList(int todoListId);
        Task<int> InsertTodoItem(TodoItem todoItem);
        Task DeleteTodoItem(int todoItemid);
        Task UpdateTodoItem(TodoItem todoItem);
    }
}
