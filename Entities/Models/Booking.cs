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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        [Display(Name = "Purchased Date")]
       // [CustomValidation(typeof(MyValidations), "ValidateDateAttribute")]
        public DateTime PurchaseDate { get; set; }
        public decimal PackagesCost { get; set; }
        //Navigation Properties
        public ICollection<Package> Packages { get; set; }

        public ApplicationUser ApplicationUser { get; set; }
    }
}
