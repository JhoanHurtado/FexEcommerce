using System;
using System.Collections.Generic;
using System.Text;

namespace FexEcommerce.Models
{
    public class Department
    {
        public Department()
        {
            this.Cities = new HashSet<City>();
        }
        public int ID { get; set; }
        public string Name { get; set; }

        public virtual ICollection<City> Cities { get; set; }
    }
}
