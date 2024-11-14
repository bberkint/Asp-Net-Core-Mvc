using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using PassingData.Models.ViewModel;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class CustomerController : Controller
    {


        List<Customer> customers = new List<Customer>() { 
            new Customer() { FirstName = "Murat", LastName ="Arı"},
            new Customer() { FirstName = "Enes", LastName ="Behçet"},
            new Customer() { FirstName = "Hazbulla", LastName ="Cantürk"},
        };    
        public IActionResult UseViewModel()
        {

            Product product = new Product();
            product.ProductName = "Monitör";
            product.CategoryName = "Elektronik";
            product.UnitPrice = 10;


            string date = DateTime.Now.ToString();

            CustomerAndProductVM customerAndProductVM = new CustomerAndProductVM();
            customerAndProductVM.customers = customers; 
            customerAndProductVM.product = product; 
            customerAndProductVM.date = date;   

            return View(customerAndProductVM);
        }


        public IActionResult UseTuple() {

            Product product = new Product();
            product.ProductName = "Telefon";
            product.CategoryName = "Elektronik";
            product.UnitPrice = 4000;

            string date = DateTime.Now.ToString();

             (List<Customer>, Product, string) customerAndProduct = (customers, product, date);

            return View(customerAndProduct);
        }
    }
}
