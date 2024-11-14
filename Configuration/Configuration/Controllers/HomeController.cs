using Configuration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Configuration.Controllers
{
    public class HomeController : Controller
    {

        readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration; 
        }

        public IActionResult Index()
        {
            string email = _configuration["Email"];
            string name = _configuration["User:Name"];
            string password = _configuration.GetSection("User:Password").Value;

            User user = _configuration.GetSection("User").Get(typeof(User)) as User;
            return View();
        }
    }
}
