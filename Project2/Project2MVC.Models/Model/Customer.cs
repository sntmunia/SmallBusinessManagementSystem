using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2MVC.Models.Model
{
    public class Customer
    {
        [Key]
        public  string Code { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        public  string Name { get; set; }
        [Required(ErrorMessage = "Please enter address")]
        public  string Address { get; set; }
        [Required(ErrorMessage = "Please enter email")]
        public  string Email { get; set; }
        [Required(ErrorMessage = "Please enter contact")]
        public  int Contact { get; set; }
        [Required(ErrorMessage = "Please enter loyalty Point")]
        public  int LoyaltyPoint { get; set; }
    }
}
