using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Udemy.EfCore.Data.Context;
using Udemy.EfCore.Data.Entities;
using Udemy.EfCore.Models;

namespace Udemy.EfCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            UdemyContext context = new();

            //var entityEntry = context.Products.Add(new Data.Entities.Product
            //{
            //    Name = "Telefon",
            //    Price = 3400
            //});

            //var updatedProduct = context.Products.Find(1);
            //updatedProduct.Price = 400;
            //updatedProduct.Name = "Bilgisayar";

            //Product product = new Product() { Price = 4000 };
            //context.Products.Add(product);  
            //context.SaveChanges();

            //context.Employees.Add(new PartTimeEmployee
            //{
            //    DailyWage = 400,
            //    FirstName = "part",
            //    LastName = "part"
            //});

            //context.Employees.Add(new PartTimeEmployee
            //{
            //    DailyWage = 400,
            //    FirstName = "part2",
            //    LastName = "part2"
            //});

            //context.Employees.Add(new FullTimeEmployee
            //{
            //    HourlWage = 60,
            //    FirstName = "full",
            //    LastName = "full"
            //});
            //context.SaveChanges();

            var parts = context.PartTimeEmployees.ToList();
            var parts2 = context.Employees.Where(x => x is PartTimeEmployee).ToList();



            return View();
        }
    }
}
