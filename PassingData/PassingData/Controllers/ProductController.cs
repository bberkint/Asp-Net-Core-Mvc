using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;

namespace PassingData.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            string userName = "Batın Berkin";
            return View(userName as Object);
        }


        public IActionResult UrunGoster() { 

            Product product = new Product();
            product.ProductName = "Televizyon";
            product.UnitPrice = 50000;
            return View(product);
        }

        public IActionResult GetProductList() {

            List<Product> products = new List<Product>()
            {

                new Product(){ ProductName= "Bilgisayar" , CategoryName = "Elektronik", UnitPrice= 45000},
                new Product(){ ProductName= "Telefon" , CategoryName = "Elektronik", UnitPrice= 30000},
                new Product(){ ProductName= "Buz Dolabı" , CategoryName = "Beyaz Eşya", UnitPrice= 20000},
                new Product(){ ProductName= "Koltuk" , CategoryName = "Beyaz Eşya", UnitPrice= 50000},

            };    

            return View(products);
        }
    }
}
