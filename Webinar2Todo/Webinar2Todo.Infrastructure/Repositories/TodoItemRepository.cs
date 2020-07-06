using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Webinar2Todo.Domain.Interfaces;
using Webinar2Todo.Domain.Model;

namespace Webinar2Todo.Infrastructure.Repositories
{
    public class TodoItemRepository : ITodoItemRepository
    {
        private readonly Context _context;
        public TodoItemRepository(Context context)
        {
            _context = context;
        }

        public async Task DeleteTodoItem(int todoItemid)
        {
            var item = await _context.TodoItems.Where(p => p.Id == todoItemid).SingleOrDefaultAsync();
            _context.TodoItems.Remove(item);
            await _context.SaveChangesAsync();
        }

        public IQueryable<TodoItem> GetAll()
        {
            return _context.TodoItems;
        }

        public TodoItem GetItemById(int id)
        {
            return _context.TodoItems.FirstOrDefault(p => p.Id.Equals(id));
        }

        public IQueryable<TodoItem> GetTodoItemsForList(int todoListId)
        {
            return _context.TodoItems.Where(p => p.TodoListId.Equals(todoListId));
        }

        public async Task<int> InsertTodoItem(TodoItem todoItem)
        {
            await _context.TodoItems.AddAsync(todoItem);
            await _context.SaveChangesAsync();
            return todoItem.Id;
        }

        public async Task UpdateTodoItem(TodoItem todoItem)
        {
            _context.Update(todoItem);
            await _context.SaveChangesAsync();
        }
    }
}
