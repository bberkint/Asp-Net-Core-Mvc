using GettingData.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GettingData.Controllers
{
    public class ProductController : Controller
    {

        List<Product> products = new List<Product>() { 
            new Product(){ID = 1, ProductName = "Kitap", CategoryName = "Ev Eşyası"},
            new Product(){ID = 2, ProductName = "Televizyon", CategoryName = "Elektronik"},
            new Product(){ID = 3, ProductName = "Kalem", CategoryName = "Ev Eşyası"},
            new Product(){ID = 4, ProductName = "Silgi", CategoryName = "Ev Eşyası"},
        };
        public IActionResult GetAllProducts()
        {
            return View(products);
        }

        public IActionResult GetProductById(int id)
        {
            Product product = products.Find(x => x.ID == id);

            if (product == null) {
                ViewBag.Error = "Verilen id ile bir ürün bulunamadı.";
            }

            return View(product);
        }


        public IActionResult GetProductsByCategoryName(string categoryName) {

            List<Product> p = products.FindAll(x => x.CategoryName == categoryName);

            if (p.Count == 0) {
                ViewData["Error"] = "İstenilen kategoride veri bulunamadı.";
            }

            return View(p);  
        }
    }
}
