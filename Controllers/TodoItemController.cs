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

        //GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(TodoItem obj)
        {
            if(obj.Priority == "")
            {
                ModelState.AddModelError("Priority", "The Priority is required.");
            }

            if(ModelState.IsValid)
            {
                _db.TodoItems.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }

        //GET
        public IActionResult Update(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound();
            }

            var categoryFromDb = _db.TodoItems.Find(id);

            if(categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(TodoItem obj)
        {
            if (obj.Priority == "")
            {
                ModelState.AddModelError("Priority", "The Priority is required.");
            }

            if (ModelState.IsValid)
            {
                _db.TodoItems.Update(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(obj);
        }
    }
}
