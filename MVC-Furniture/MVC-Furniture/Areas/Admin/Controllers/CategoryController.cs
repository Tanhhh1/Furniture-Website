using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    public class CategoryController : Controller
    {
        [HttpGet("list-category")]
        public IActionResult ListCategory()
        {
            return View();
        }

        [HttpGet("add-category")]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpGet("edit-category")]
        public IActionResult EditCategory()
        {
            return View();
        }
    }
}
