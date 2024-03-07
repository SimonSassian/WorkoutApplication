using Microsoft.AspNetCore.Mvc;

namespace WorkoutApplication.Model
{
    public class Attendee : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
