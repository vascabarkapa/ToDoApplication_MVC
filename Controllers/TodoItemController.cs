using Microsoft.AspNetCore.Mvc;
using ToDoApplication_MVC.Data;
using ToDoApplication_MVC.Models;

namespace ToDoApplication_MVC.Controllers
{
    public class TodoItemController : Controller
    {
        private readonly ApplicationDbContext _db;

        public TodoItemController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<TodoItem> objTodoItemList = _db.TodoItems;

            return View(objTodoItemList);
        }
    }
}
