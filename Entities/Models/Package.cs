using Entities.Models.Enums;
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
        public Package()
        {
            Photos = new HashSet<Photo>();
            Comments= new HashSet<Comment>();
        }
        public int PackageId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        [Display(Name = "Trip Date")]
        public DateTime TripDate { get; set; }
        [Display(Name = "Trip Duration")]
        public int TripDuration { get; set; }
        public decimal Price { get; set; }
        public Destinations Destinations { get; set; }
        //Navigation Properties
        public ICollection<Photo> Photos { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public ICollection<Comment> Comments { get; set; }


        //TODO: 
        //Package status(active,pending,expired)

    }
}
