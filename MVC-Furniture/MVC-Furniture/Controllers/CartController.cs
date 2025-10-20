using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Controllers
{
    [Route("/")]
    public class CartController : Controller
    {
        [HttpGet("cart")]
        public IActionResult Cart()
        {
            return View();
        }

        [HttpGet("order")]
        public IActionResult Order()
        {
            return View();
        }

        public IActionResult Payment()
        {
            return View();
        }
    }
}
