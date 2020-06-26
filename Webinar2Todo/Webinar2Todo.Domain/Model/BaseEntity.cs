using System;
using System.Collections.Generic;
using System.Text;

namespace Webinar2Todo.Domain.Model
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
