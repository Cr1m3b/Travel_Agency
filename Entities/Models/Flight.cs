using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Flight
    {
        public Flight()
        {
            Packages= new HashSet<Package>();
        }
        public int FlightId { get; set; }
        public string CompanyName { get; set; }
        //Navigation Properties
        public ICollection<Package> Packages { get; set; }

    }
}
