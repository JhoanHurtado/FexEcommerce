using System.Collections.Generic;

namespace FexEcommerce.Models
{
    public class Source
    {
        public Source()
        {
            this.Products = new HashSet<Product>();
         
        }
        public int ID { get; set; }
        public string SourceLink { get; set; }
        public int tipe { get; set; }
        public ICollection<Product> Products { get; set; }

    }
}