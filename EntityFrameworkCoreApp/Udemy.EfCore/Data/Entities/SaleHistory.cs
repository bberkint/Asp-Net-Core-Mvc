﻿namespace Udemy.EfCore.Data.Entities
{
    public class SaleHistory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        //Navigation prop
        public Product Product { get; set; }
        public int Amount { get; set; }
    }
}