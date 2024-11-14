using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        public IActionResult UseViewBag()
        {
            ViewBag.UserName = "Berkin";

            User user = new User();
            user.firstName = "Ahmet Berke";
            user.lastName = "Topaloğlu"; 
            ViewBag.User = user;

            List<User> users = new List<User>() { 
                new User(){firstName = "Adem Yiğit", lastName ="Doğan"},
                new User(){firstName = "Mehmet Kayra", lastName ="Doğan"},
                new User(){firstName = "Efsa", lastName ="Topaloğlu"},
            };

            ViewBag.Users = users;
            return View();
        }


        public IActionResult UseViewData() {

            ViewData["UserName"] = "Berkin";

            User user = new User();
            user.firstName = "Servet";
            user.lastName = "Topaloğlu";
            ViewData["User"] = user;

            return View(); 
        }

        public IActionResult UseTempData() {

            TempData["name"] = "Batın";

            return RedirectToAction("TempDataTest");
        }

        public IActionResult TempDataTest() {

            TempData.Keep("name");
            //string userName = TempData["name"].ToString();
            return View();
        }
    }
}
