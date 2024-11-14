using GettingData.Models;
using Microsoft.AspNetCore.Mvc;

namespace GettingData.Controllers
{
    public class HomeController : Controller
    {
        public string Index(Product product)
        {
            return "Uygulama çalışıyor";
        }

        //home/index/15?name=abdullah&surname=yesil

        public string UseQueryString(string name, string surname)
        {
            return "QueryString çalışıyor "+ name + " " + surname;
        }
    }
}
