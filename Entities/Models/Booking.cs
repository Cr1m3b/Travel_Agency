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
        public int BookingId { get; set; }
        [Display(Name = "Purchased Date")]
       // [CustomValidation(typeof(MyValidations), "ValidateDateAttribute")]
        public DateTime PurchaseDate { get; set; }
        //Navigation Properties
        public int PackageId { get; set; }
        public Package Package { get; set; }
        //TODO: Navigation Properties for user
    }
}
