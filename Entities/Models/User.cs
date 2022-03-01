using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Display(Name = "Enter your first name :")]
        [Required(ErrorMessage = "The firstname is required.")]
        [Range(2,20, ErrorMessage = "The firstname must be between 2 and 20 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Enter your last name :")]
        [Required(ErrorMessage = "The laststname is required.")]
        [Range(2, 20, ErrorMessage = "The lastname must be between 2 and 20 characters")]
        public string LastName { get; set; }

        [Display(Name = "Enter your email:")]
        [Required(ErrorMessage = "Email is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Display(Name = "Enter your contact phone number:")]
        [Required(ErrorMessage = "Contact phone is required.")]
        [DataType(DataType.PhoneNumber,ErrorMessage = "Invalid Contact Number")]
        [RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Invalid Contact Number.")]
        public string ContactNumber { get; set; }

        [Display(Name = "Enter your country:")]
        [Required(ErrorMessage = "Country is required.")]
        [Range(3, 12, ErrorMessage = "The name of the country must be between 3 and 12 characters")]
        public string Country { get; set; }
    }
}
