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
        [Key]
        public int BookingId { get; set; }
        public DateTime PurchaseDate { get; set; }
        //Navigation Properties
        public int PackageId { get; set; }
        public Package Package { get; set; }
        //TODO: Navigation Properties for user
    }
}
