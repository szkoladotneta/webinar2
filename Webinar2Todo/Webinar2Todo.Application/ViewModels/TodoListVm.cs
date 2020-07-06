using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Webinar2Todo.Domain.Model;
using static Webinar2Todo.Application.Mapping.IMapFrom;

namespace Webinar2Todo.Application.ViewModels
{
    public class TodoListVm : IMapFrom<TodoList>
    {
        public int Id { get; set; }
        public string ListName { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TodoList, TodoListVm>().ReverseMap();
        }
    }
}
