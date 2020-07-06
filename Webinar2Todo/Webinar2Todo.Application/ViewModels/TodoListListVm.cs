using System;
using System.Collections.Generic;
using System.Text;

namespace Webinar2Todo.Application.ViewModels
{
    public class TodoListListVm
    {
        public List<TodoListVm> Lists { get; set; }
        public int Count { get; set; }
    }
}
