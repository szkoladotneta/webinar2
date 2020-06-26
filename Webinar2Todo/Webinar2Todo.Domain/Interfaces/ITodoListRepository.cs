using System;
using System.Collections.Generic;
using System.Text;
using Webinar2Todo.Domain.Model;

namespace Webinar2Todo.Domain.Interfaces
{
    public interface ITodoListRepository
    {
        List<TodoList> GetAll();
    }
}
