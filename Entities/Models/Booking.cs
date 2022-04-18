using Entities.IdentityUsers;
using Entities.Models.CustomValidations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Booking
    {
        public Booking()
        {
            Packages=new HashSet<Package>();
        }
        public int BookingId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [MinLength(2, ErrorMessage = "First name can not be less than 2 letters")]
        [MaxLength(40,ErrorMessage ="First name can not be more than 40 letters")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [MinLength(2, ErrorMessage = "Last name can not be less than 2 letters")]
        [MaxLength(40, ErrorMessage = "Last name can not be more than 40 letters")]
        public string LastName { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [Display(Name = "Contact Number")]
        [DataType(DataType.PhoneNumber, ErrorMessage = "Invalid Contact Number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Purchased Date")]
        public DateTime PurchaseDate { get; set; }
        [Display(Name = "Packages Cost")]
        public decimal PackagesCost { get; set; }
        //Navigation Properties
        public ICollection<Package> Packages { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
