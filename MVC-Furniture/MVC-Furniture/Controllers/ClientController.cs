using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Controllers
{
    [Route("/")]
    public class ClientController : Controller
    {
        [HttpGet]
        public IActionResult Homepage()
        {
            return View();
        }

        [HttpGet("about")]
        public IActionResult About()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet("profile")]
        public IActionResult Profile()
        {
            return View();
        }
    }
}
