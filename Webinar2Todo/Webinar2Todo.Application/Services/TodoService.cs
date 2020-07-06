using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webinar2Todo.Application.Interfaces;
using Webinar2Todo.Application.ViewModels;
using Webinar2Todo.Domain.Interfaces;
using Webinar2Todo.Domain.Model;

namespace Webinar2Todo.Application.Services
{
    public class TodoService : ITodoService
    {
        private readonly ITodoItemRepository _itemRepo;
        private readonly ITodoListRepository _listRepo;
        private readonly IMapper _mapper;
        public TodoService(ITodoItemRepository itemRepo, ITodoListRepository listRepo, IMapper mapper)
        {
            _itemRepo = itemRepo;
            _listRepo = listRepo;
            _mapper = mapper;
        }

        public async Task DeleteTodoItem(int todoItemId)
        {
            await _itemRepo.DeleteTodoItem(todoItemId);
        }

        public async Task DeleteTodoList(int todoListId)
        {
            await _listRepo.DeleteTodoList(todoListId);
        }

        public async Task<TodoItemListVm> GetAllTodoItems()
        {
            var items = await _itemRepo.GetAll()
                                       .ProjectTo<TodoItemVm>(_mapper.ConfigurationProvider)
                                       .ToListAsync();
            return new TodoItemListVm()
            {
                Items = items,
                Count = items.Count
            };
        }

        public async Task<TodoListListVm> GetAllTodoLists()
        {
            var lists = await _listRepo.GetAll()
                .ProjectTo<TodoListVm>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new TodoListListVm()
            {
                Lists = lists,
                Count = lists.Count
            };
        }

        public async Task<TodoItemListVm> GetTodoItemsForList(int listId)
        {
            var items = await _itemRepo.GetTodoItemsForList(listId)
                .ProjectTo<TodoItemVm>(_mapper.ConfigurationProvider)
                .ToListAsync();
            return new TodoItemListVm()
            {
                Items = items,
                Count = items.Count
            };
        }

        public async Task<TodoListVm> GetTodoListById(int id)
        {
            var list = await _listRepo.GetAll().Where(p => p.Id == id)
                .ProjectTo<TodoListVm>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync();
            return list;
        }

        public async Task<int> InsertTodoItem(TodoItemVm todoItem)
        {
            var item = _mapper.Map<TodoItem>(todoItem);
            var id = await _itemRepo.InsertTodoItem(item);
            return id;
        }

        public async Task<int> InsertTodoList(TodoListVm todoList)
        {
            var list = _mapper.Map<TodoList>(todoList);
            var id = await _listRepo.InsertTodoList(list);
            return id;
        }

        public async Task UpdateTodoItem(TodoItemVm todoItem)
        {
            var item = _mapper.Map<TodoItem>(todoItem);
            await _itemRepo.UpdateTodoItem(item);
        }
    }
}
