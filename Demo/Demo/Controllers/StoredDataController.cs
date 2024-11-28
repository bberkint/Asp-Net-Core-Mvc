using Demo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Demo.Controllers
{
    public class StoredDataController : Controller
    {
        public IActionResult GetData()
        {
            //Person person = new Person();
            //person.Name = HttpContext.Session.GetString("Name");
            //person.Surname = HttpContext.Session.GetString("Surname");


            //List<Person> people = new List<Person>();

            //if (person.Name != null && person.Surname != null)
            //{
            //    people.Add(person);
            //}

            //return View(people);

            //var peopleJson = HttpContext.Session.GetString("People");
            //List<Person> people = peopleJson != null ? JsonConvert.DeserializeObject<List<Person>>(peopleJson) : new List<Person>();

            //var colourJson = HttpContext.Session.GetString("ColourSession");
            //List<Colour> colours = colourJson != null ? JsonConvert.DeserializeObject<List<Colour>>(colourJson) : new List<Colour>();   

            return View();  

        }
    }
}
