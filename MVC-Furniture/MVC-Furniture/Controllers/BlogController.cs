using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Controllers
{
    [Route("/")]
    public class BlogController : Controller
    {
        [HttpGet("all-blog")]
        public IActionResult AllBlog()
        {
            return View();
        }

        [HttpGet("detail-blog")]
        public IActionResult DetailBlog()
        {
            return View();
        }
    }
}
