using Demo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Controllers
{
    public class LoginController : Controller
    {
        private readonly User _user;
        public LoginController(User user) 
        {
            _user = user;
        }
        public IActionResult Create()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Create(User user)
        {
            
            if (user.userName == "Berkin" && user.password == "123")
            {
                
                return RedirectToAction("Index", "MainPage", user);
            }

            return View();
        }

    }
}
