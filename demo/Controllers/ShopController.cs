using Microsoft.AspNetCore.Mvc;

namespace demo.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            return View();
        }

        public IActionResult Shop_Detail()
        {
            return View();
        }
    }
}
