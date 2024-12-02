using Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Drawing;

namespace Demo.Controllers
{
    public class ChangeColorController : Controller
    {
        public IActionResult Index()
        {
           

            return View();
        }
    }
}
