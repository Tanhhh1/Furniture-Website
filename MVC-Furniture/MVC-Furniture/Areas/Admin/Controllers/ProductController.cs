using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    public class ProductController : Controller
    {
        [HttpGet("list-product")]
        public IActionResult ListProduct()
        {
            return View();
        }

        [HttpGet("add-product")]
        public IActionResult AddProduct()
        {
            return View();
        }

        [HttpGet("edit-product")]
        public IActionResult EditProduct()
        {
            return View();
        }
    }
}
