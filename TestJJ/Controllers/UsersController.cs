using Microsoft.AspNetCore.Mvc;

namespace TestJJ.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }
    }
}
