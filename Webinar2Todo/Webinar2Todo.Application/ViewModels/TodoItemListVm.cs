using System;
using System.Collections.Generic;
using System.Text;

namespace Webinar2Todo.Application.ViewModels
{
    public class TodoItemListVm
    {
        public int ListId { get; set; }
        public List<TodoItemVm> Items { get; set; }
        public int Count { get; set; }
    }
}
