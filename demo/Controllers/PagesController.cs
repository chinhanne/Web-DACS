using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Testimonial()
        {
            return View();
        }

        public IActionResult ChackOut()
        {
            return View();
        }
    }
}
