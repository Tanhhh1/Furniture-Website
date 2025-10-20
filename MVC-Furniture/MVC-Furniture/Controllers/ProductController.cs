using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Controllers
{
    [Route("/")]
    public class ProductController : Controller
    {
        [HttpGet("all-product")]
        public IActionResult AllProduct()
        {
            return View();
        }

        [HttpGet("detail-product")]
        public IActionResult DetailProduct()
        {
            return View();
        }
    }
}
