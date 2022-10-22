using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace API_Customer_Registration.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name field is required")]
        public string Name { get; set; }
        public string Address_Street { get; set; }
        public string Address_City { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Age must be numeric")]
        [Range(1, 130)]
        public int Age { get; set; }
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }
        [RegularExpression("^[0-9]*$", ErrorMessage = "Phone must contain only numbers")]
        public string Phone { get; set; }

    }
}
