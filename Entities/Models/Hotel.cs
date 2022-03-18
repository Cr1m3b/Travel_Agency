using Entities.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Hotel
    {
        public Hotel()
        {
            Packages = new HashSet<Package>();
        }
        public int HotelId { get; set; }
        [Display(Name = "Hotel Name")]
        public string HotelName { get; set;}
        [Display(Name = "Hotel Stars")]
        public int HotelStars { get; set;}
        public string MapEmbededUrl { get; set; }
        public Destinations Destinations { get; set; }
        //Navigation Properties
        public ICollection<Package> Packages { get; set; }

    }
}
