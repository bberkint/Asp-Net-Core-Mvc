using Microsoft.AspNetCore.Mvc;

namespace Configuration.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
