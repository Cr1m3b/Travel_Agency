using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Flight
    {
        public int FlightId { get; set; }
        public string CompanyName { get; set; }
        //public double Price { get; set; }
        //public int Luggage { get; set; }
        public DateTime TripDate { get; set; }
        public DateTime ReturnDate { get; set; }

        //public User User { get; set; }
        //public Destinations Destinations

    }
}
