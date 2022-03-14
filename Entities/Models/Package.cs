using Entities.Enums;
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
            Ratings = new HashSet<Rating>();
        }
        public int PackageId { get; set; }
        public string Title { get; set; }
        public string MainPhoto { get; set; }
        public string Description { get; set; }
        public string Program { get; set; }
        [Display(Name = "Trip Date")]
        public DateTime TripDate { get; set; }
        [Display(Name = "Trip Duration")]
        public int TripDuration { get; set; }
        public decimal Price { get; set; }
        public Destinations Destinations { get; set; }
        public Status PackageStatus { get; set; }
        //Navigation Properties
        public ICollection<Photo> Photos { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Rating> Ratings { get; set; }
        public double CalcRating()
        {
            if (Ratings.Count==0)
            {
                return 0;
            }
            else
            {
                double rating = 0;
                int sum = 0;
                foreach (var r in Ratings)
                {
                    sum += r.RateScore;
                }
                rating = sum / Ratings.Count;
                return rating;
            }
            
        }
    }
    
}
