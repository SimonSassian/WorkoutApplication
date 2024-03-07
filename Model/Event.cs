using Microsoft.AspNetCore.Mvc;

namespace WorkoutApplication.Model
{
    public class Event : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
