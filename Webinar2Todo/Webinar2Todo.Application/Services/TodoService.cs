using System;
using System.Collections.Generic;
using System.Text;
using Webinar2Todo.Application.Interfaces;
using Webinar2Todo.Application.ViewModels;
using Webinar2Todo.Domain.Interfaces;

namespace Webinar2Todo.Application.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoItemRepository _itemRepo;
        private readonly ITodoListRepository _listRepo;
        public TodoService(ITodoItemRepository itemRepo, ITodoListRepository listRepo)
        {
            _itemRepo = itemRepo;
            _listRepo = listRepo;
        }
        public List<TodoListVm> GetListWithItems()
        {
            var lists = _listRepo. 
        }
    }
}
