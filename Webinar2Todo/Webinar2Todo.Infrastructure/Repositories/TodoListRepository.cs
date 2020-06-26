using System;
using System.Collections.Generic;
using System.Text;
using Webinar2Todo.Domain.Interfaces;
using Webinar2Todo.Domain.Model;

namespace Webinar2Todo.Infrastructure.Repositories
{
    public class TodoListRepository : ITodoListRepository
    {
        public List<TodoList> GetAll()
        {
            
        }
        public TodoList GetById(int id) 
        { 
        }
    }
}
