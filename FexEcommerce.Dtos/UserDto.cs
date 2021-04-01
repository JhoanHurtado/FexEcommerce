using FexEcommerce.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FexEcommerce.Dtos
{
    public class UserDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Email { get; set; }
        public string PictureProfile { get; set; }
        public string contact { get; set; }
        public string OpcionalContact { get; set; }
        public bool Terified { get; set; }
        public string TokenVerified { get; set; }
        public City City { get; set; }
        public Department Department { get; set; }
    }
}
