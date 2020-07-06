using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webinar2Todo.Domain.Model
{
    public class TodoItem : BaseEntity
    {
        public string Task { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int TodoListId { get; set; }
        public TodoList TodoList { get; set; }
    }
}
