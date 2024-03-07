using Microsoft.AspNetCore.Mvc;

namespace WorkoutApplication.Model
{
    public class Speaker : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
