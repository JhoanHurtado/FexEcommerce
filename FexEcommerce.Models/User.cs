using System;
using System.Collections.Generic;
using System.Text;

namespace FexEcommerce.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Email { get; set; }
        public string  Password { get; set; }
        public string PictureProfile { get; set; }
        public string contact { get; set; }
        public string OpcionalContact { get; set; }
        public bool Terified { get; set; }
        public string TokenVerified { get; set; }
        public City City { get; set; }
        public Department Department { get; set; }
    }
}
