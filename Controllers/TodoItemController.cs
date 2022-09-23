using Microsoft.AspNetCore.Mvc;

namespace ToDoApplication_MVC.Controllers
{
    public class TodoItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
