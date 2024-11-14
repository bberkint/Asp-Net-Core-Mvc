using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class UserController : Controller
    {
        public IActionResult GetUser() // action
        {

            User user = new User();
            user.ID = 1;
            user.FirstName = "Berkin";
            user.LastName = "Topaloğlu";

            return View();
        }



        [NonAction]    // rooteda buna gitmiyo. yani getfullname yazsak bile çıkarmaz 
        public string GetFullName(User user) {
            return user.FirstName + " " + user.LastName;
        }
    }
}
