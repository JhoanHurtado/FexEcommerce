using System;
using System.Collections.Generic;
using System.Text;

namespace FexEcommerce.Models
{
    public class City
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Department Department { get; set; }
    }
}
