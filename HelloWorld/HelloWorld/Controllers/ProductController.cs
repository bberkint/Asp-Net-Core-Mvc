using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
