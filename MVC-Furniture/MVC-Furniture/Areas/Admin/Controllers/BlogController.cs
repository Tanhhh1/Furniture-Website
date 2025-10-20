using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    public class BlogController : Controller
    {
        [HttpGet("list-blog")]
        public IActionResult ListBlog()
        {
            return View();
        }

        [HttpGet("add-blog")]
        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpGet("edit-blog")]
        public IActionResult EditBlog()
        {
            return View();
        }
    }
}
