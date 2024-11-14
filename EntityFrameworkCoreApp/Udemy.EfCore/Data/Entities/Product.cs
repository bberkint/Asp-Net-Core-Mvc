using System;
using System.Collections.Generic;

namespace Udemy.EfCore.Data.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedTime { get; set; }

        public ProductDetail ProductDetail { get; set; }
        public List<SaleHistory> SaleHistories { get; set; }
        public List<ProductCategory> ProductCategories { get; set; }
    }
}
