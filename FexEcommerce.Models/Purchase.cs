using System;
using System.Collections.Generic;
using System.Text;

namespace FexEcommerce.Models
{
    public class Purchase
    {
        public int ID { get; set; }
        public User User { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

    }
}
