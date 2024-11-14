using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller // controller
    {
        public string Index() // action
        {
            return "Uygulama çalışıyor...";
        }


        public string Test() {

            return "Bu test actiondır.";
        }

        public IActionResult Selamla() { 
            ViewResult result = View();
            return result;
        }

        public IActionResult Selamla2()
        {
            ViewResult result = View("Test2");
            return result;
        }
    }
}
