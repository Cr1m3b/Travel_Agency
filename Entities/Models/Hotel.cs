using Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Hotel
    {
        public int HotelId { get; set; }
        public string HotelName { get; set;}
        public int HotelStars { get; set;}
        public KindOfBeds Beds { get; set; }
        public DateTime CheckInDay { get; set; }
        public DateTime CheckOutDay { get; set; }
        //public User User { get; set; }
        //public Destinations Destinations

    }
}
