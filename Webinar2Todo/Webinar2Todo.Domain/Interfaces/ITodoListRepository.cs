using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webinar2Todo.Domain.Model;

namespace Webinar2Todo.Domain.Interfaces
{
    public interface ITodoListRepository
    {
        IQueryable<TodoList> GetAll();
        TodoList GetListById(int id);
        Task<int> InsertTodoList(TodoList todoList);
        Task DeleteTodoList(int todoListid);
        Task UpdateTodoList(TodoList todoList);
    }
}
