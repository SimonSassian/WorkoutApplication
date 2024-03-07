using Microsoft.AspNetCore.Mvc;

namespace WorkoutApplication.Controllers
{
    public class Speaker : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
