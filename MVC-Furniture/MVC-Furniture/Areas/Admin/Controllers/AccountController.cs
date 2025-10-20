using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin")]
    public class AccountController : Controller
    {
        [HttpGet("list-account")]
        public IActionResult ListAccount()
        {
            return View();
        }

        [HttpGet("add-account")]
        public IActionResult AddAccount()
        {
            return View();
        }

        [HttpGet("edit-account")]
        public IActionResult EditAccount()
        {
            return View();
        }
    }
}
