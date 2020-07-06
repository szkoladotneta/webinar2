using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using Webinar2Todo.Application.Mapping;
using Webinar2Todo.Domain.Model;
using static Webinar2Todo.Application.Mapping.IMapFrom;

namespace Webinar2Todo.Application.ViewModels
{
    public class TodoItemVm : IMapFrom<TodoItem>
    {
        public int Id { get; set; }
        public string Task { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public int TodoListId { get; set; }
        public string TodoListName { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<TodoItem, TodoItemVm>()
                .ForMember(d => d.TodoListName, opt => opt.MapFrom(s => s.TodoList.Name)).ReverseMap();
        }
    }
}
