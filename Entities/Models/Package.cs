using Entities.Enums;
using Entities.Models.CustomValidations;
using Entities.IdentityUsers;
using Entities.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Entities.Models
{
    public class Package
    {
        public Package()
        {
            Photos = new HashSet<Photo>();
            Comments= new HashSet<Comment>();
            Bookings = new HashSet<Booking>();
        }
        public int PackageId { get; set; }
        [Required(ErrorMessage ="Title is required")]
        public string Title { get; set; }
        public string MainPhoto { get; set; }
        [Required(ErrorMessage = "Description is required")]
        public string Description { get; set; }
        public string Program { get; set; }
        [Required]
        [Display(Name = "Trip Date")]
        public DateTime TripDate { get; set; }
        [Required,Range(0,int.MaxValue, ErrorMessage ="Trip duration must be greater than 0")]
        [Display(Name = "Trip Duration")]
        public int TripDuration { get; set; }
        [Required]
        [CustomValidation(typeof(MyValidations), "ValidateGreaterToZero")]
        public decimal Price { get; set; }
        [Range(0, 100, ErrorMessage = "The percentage of offer must be equal or greater to zero and equal or smaller than 100")]
        public int Discount { get; set; } = 0;
        public Destinations Destinations { get; set; }
        public Status PackageStatus { get; set; }
        
        //Navigation Properties
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int FlightId { get; set; }
        public Flight Flight { get; set; }
        public ICollection<Photo> Photos { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Booking> Bookings { get; set; }

        /// <summary>
        /// Final price of package (after calculating discount, if any)
        /// </summary>
        /// <returns>decimal price</returns>
        public decimal FinalPrice()
        {
            var finalPrice= Price - ((Price * Discount / 100));
            return Math.Floor(finalPrice);
        }
        public double AveragePackageRating()
        {
            double sum = 0;
            foreach (var com in Comments)
            {
                sum += com.Rating.RateScore;
            }
            return Math.Round(sum / Comments.Count, MidpointRounding.ToEven);
        }
        
    }
    
}
