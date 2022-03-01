using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Package
    {
        [Key]
        public int PackageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime TripDate { get; set; }
        public int TripDuration { get; set; }
        public decimal Price { get; set; }
        //TODO: 
        //Add Destination kai package status(active,pending,expired)
        //List<Photos>

    }
}
