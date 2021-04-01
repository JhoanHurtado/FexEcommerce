﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FexEcommerce.Models
{
    public class purchasesDetail
    {
        public int ID { get; set; }
        public Purchase Purchase { get; set; }
        public Product Product { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public Tax Tax { get; set; } // impuestos
        public int Amount { get; set; } //cantiad
    }
}
