using Microsoft.AspNetCore.Mvc;

namespace WorkoutApplication.Controllers
{
    public class Event : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
