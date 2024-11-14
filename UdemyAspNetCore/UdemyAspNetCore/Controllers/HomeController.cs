using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UdemyAspNetCore.Filters;
using UdemyAspNetCore.Models;

namespace UdemyAspNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var customers = CustomerContext.Customers;

            return View(customers);
        }

        public IActionResult Create()
        {

            return View(new Customer());
        }


        //Moel Binding

        [HttpPost]
        [ValidFirstName]
        public IActionResult Create(Customer customer)
        {
            ModelState.Remove("Id");
            if (customer.FirstName == "Berkin")
            {
                ModelState.AddModelError("", "FirstName Berkin olamaz");
            }
            if (ModelState.IsValid)
            {
                Customer lastCustomer = null;
                if (CustomerContext.Customers.Count > 0)
                {
                    lastCustomer = CustomerContext.Customers.Last();
                }
                customer.Id = 1;
                if (lastCustomer != null)
                {
                    customer.Id = lastCustomer.Id + 1;
                }

                CustomerContext.Customers.Add(customer);

                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Remove(int id)
        {

            var removedCustomer = CustomerContext.Customers.Find(x => x.Id == id);
            CustomerContext.Customers.Remove(removedCustomer);

            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(x => x.Id == id);

            return View(updatedCustomer);
        }

        [HttpPost]
        public IActionResult Update(Customer customer)
        {
            var updatedCustomer = CustomerContext.Customers.FirstOrDefault(x => x.Id == customer.Id);
            updatedCustomer.FirstName = customer.FirstName;
            updatedCustomer.LastName = customer.LastName;
            updatedCustomer.Age = customer.Age;

            return RedirectToAction("Index");
        }

    }
}
