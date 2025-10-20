using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    public class OrderController : Controller
    {
        [HttpGet("list-order")]
        public IActionResult ListOrder()
        {
            return View();
        }

        [HttpGet("detail-order")]
        public IActionResult DetailOrder()
        {
            return View();
        }
    }
}
