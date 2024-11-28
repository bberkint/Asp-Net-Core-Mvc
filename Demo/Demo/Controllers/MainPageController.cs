using System;
using System.Collections.Generic;
using System.Drawing;
using Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Demo.Controllers
{
    public class MainPageController : Controller
    {
        public IActionResult Index()
        {
            var session = HttpContext.Session.GetString("ColourSession");
            Console.WriteLine("1.adım");
            if (string.IsNullOrEmpty(session))
            {
                List<Colour> colours = new List<Colour>
                {
                    new Colour { ColorID = 0, ColorName = "--red", ColorValue = "#fb0808" },
                    new Colour { ColorID = 1, ColorName = "--blue", ColorValue = "#097bf1" },
                    new Colour { ColorID = 2, ColorName = "--green", ColorValue = "#37f608" },
                    new Colour { ColorID = 3, ColorName = "--yellow", ColorValue = "#ffd800" },
                    new Colour { ColorID = 4, ColorName = "--pink", ColorValue = "#ff00dc" }
                };
                Console.WriteLine("2.adım");

                HttpContext.Session.SetString("ColourSession", JsonConvert.SerializeObject(colours));
            }

            var colorList = HttpContext.Session.GetString("ColourSession");
            return View(JsonConvert.DeserializeObject<List<Colour>>(colorList)); 
        }


        //[HttpPost]
        //public IActionResult Index(Person person)
        //{
        //    //HttpContext.Session.SetString("Name", person.Name);
        //    //HttpContext.Session.SetString("Surname", person.Surname);

        //    var peopleJson = HttpContext.Session.GetString("People"); // sessiondan mevcut olan kişiler listesini alıyoruz
        //    List<Person> people = peopleJson != null ? JsonConvert.DeserializeObject<List<Person>>(peopleJson) : new List<Person>();    

        //    people.Add(person);

        //    HttpContext.Session.SetString("People", JsonConvert.SerializeObject(people));

        //    return View();
        //}

        [HttpPost]
        public IActionResult Index(Colour colour)
        {
            //{ colorname: '--red', colorvalue: '#600600'}


            return View();
        }
    }
}