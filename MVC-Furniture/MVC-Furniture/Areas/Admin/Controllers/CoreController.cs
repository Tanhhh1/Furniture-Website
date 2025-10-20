using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    public class CoreController : Controller
    {
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            return View();
        }

        [HttpGet("profile")]
        public IActionResult Profile()
        {
            return View();
        }

        [HttpGet("list-review")]
        public IActionResult ListReview()
        {
            return View();
        }
    }
}
