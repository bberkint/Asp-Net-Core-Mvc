using Microsoft.AspNetCore.Mvc;

namespace PassingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Uygulama çalışıyor...";
        }
    }
}
