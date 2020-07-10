using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Webinar2Todo.Domain.Model;
using static Webinar2Todo.Application.Mapping.IMapFrom;

namespace Webinar2Todo.Application.ViewModels
{
    public class TodoListVm : IMapFrom<TodoList>
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string ListName { get; set; }
        public TodoItemListVm Items { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TodoList, TodoListVm>()
                .ForMember(d => d.ListName, opt => opt.MapFrom(s => s.Name))
                .ForMember(d => d.Items, opt => opt.Ignore()).ReverseMap();
        }
    }
}
