using Microsoft.AspNetCore.Mvc;

namespace WorkoutApplication.Controllers
{
    public class Attendee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
