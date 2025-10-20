using Microsoft.AspNetCore.Mvc;

namespace MVC_Furniture.Controllers
{
    [Route("/")]
    public class AuthController : Controller
    {
        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View();
        }

        [HttpGet("forgot-password")]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpGet("reset-password")]
        public IActionResult ResetPassword()
        {
            return View();
        }

        [HttpGet("verify-password")]
        public IActionResult VerifyPassword()
        {
            return View();
        }
    }
}
