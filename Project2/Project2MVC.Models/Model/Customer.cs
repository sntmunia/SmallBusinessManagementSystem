using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2MVC.Models.Model
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage = "Please enter code")]
        [Display(Name = "Code")]
        public  string Code { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "Please enter name")]
        [StringLength(50, MinimumLength = 3)]
        public  string Name { get; set; }

        [Display(Name = "Address")]
        [Required(ErrorMessage = "Please enter address")]
        public  string Address { get; set; }

        [Display(Name = "Email")]
        [Required(ErrorMessage = "Please enter email")]
        public  string Email { get; set; }

        [Display(Name = "Contact")]
        [Required(ErrorMessage = "Please enter contact")]
        public  int Contact { get; set; }

        [Display(Name = "Loyalty Point")]
        [Required(ErrorMessage = "Please enter loyalty Point")]
        public  int LoyaltyPoint { get; set; }

        [NotMapped]
        public List<Customer> customers { get; set; }
    }
}
