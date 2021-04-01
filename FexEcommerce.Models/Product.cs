using System;
using System.Collections.Generic;
using System.Text;

namespace FexEcommerce.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public string Details { get; set; }
        public string Garantia { get; set; }
        public double Price { get; set; }
        public User User { get; set; }
        public Category Category { get; set; }
    }
}
