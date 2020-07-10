using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webinar2Todo.Application.Interfaces;
using Webinar2Todo.Application.ViewModels;

namespace Webinar2Todo.Controllers
{
    public class TodoController : Controller
    {
        private readonly ITodoService _service;
        public TodoController(ITodoService service)
        {
            _service = service;
        }
        // GET: Todo
        public async Task<ActionResult> Index()
        {
            var model = await _service.GetAllTodoLists();
            return View(model);
        }

        // GET: Todo/Details/5
        public async Task<ActionResult> ListDetails(int id)
        {
            var model = await _service.GetTodoItemsForList(id);
            return View(model);
        }

        // GET: Todo/Create
        public ActionResult CreateList()
        {
            return View();
        }

        // POST: Todo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateList(IFormCollection collection, TodoListVm model)
        {
            try
            {
                await _service.InsertTodoList(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Create
        public ActionResult CreateItem()
        {
            return View();
        }

        // POST: Todo/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateItem(IFormCollection collection, TodoItemVm model)
        {
            try
            {
                await _service.InsertTodoItem(model);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Edit/5
        public ActionResult EditItem(int id)
        {
            return View();
        }

        // POST: Todo/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Todo/Delete/5
        public async Task<ActionResult> DeleteItem(int id)
        {
            await _service.DeleteTodoItem(id);
            return View();
        }
    }
}