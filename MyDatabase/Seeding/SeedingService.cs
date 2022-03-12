using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entities.Models.Enums;
using Entities.Enums;
using Entities.IdentityUsers;

namespace MyDatabase.Seeding
{
    public class SeedingService
    {
        //Dependency Injection
        ApplicationDbContext db;
        public SeedingService(ApplicationDbContext context)
        {
            db = context;
        }

        //Implementation of Seeding Methods ex. public void SeedPackages()
        public void SeedPackages()
        {
            //Package Seeding
            Package p1 = new Package() { Title = "Barcelona", Description = "Vacations at Barcelone", MainPhoto= "https://c.pxhere.com/photos/a9/f0/spain_barcelona_triumphal_arch_street_view_spain_landscape_building-642076.jpg!d", TripDate = new DateTime(2022, 5, 12), TripDuration = 4, Price = 476, Destinations = Destinations.Barcelona, PackageStatus = Status.Active };
            Package p2 = new Package() { Title = "Paris", Description = "Vacations at Paris",MainPhoto= "https://fadeceilings.com/wp-content/uploads/2019/08/AdobeStock_65117955-720x460.jpeg", TripDate = new DateTime(2022, 5, 3), TripDuration = 3, Price = 699, Destinations = Destinations.Paris, PackageStatus = Status.Active };
            Package p3 = new Package() { Title = "Athens", Description = "Vacations at Athens",MainPhoto= "https://c.pxhere.com/photos/a9/a9/temple_athens_greece_architecture_ancient_greek_history_culture-763875.jpg!s1", TripDate = new DateTime(2022, 9, 1), TripDuration = 5, Price = 355, Destinations = Destinations.Athens, PackageStatus = Status.Pending };
            Package p4 = new Package() { Title = "London", Description = "Vacations at London",MainPhoto= "https://c.pxhere.com/photos/29/2d/london_parliament_england_ben_ben_westminster_tower_city_british-772846.jpg!d", TripDate = new DateTime(2022, 1, 12), TripDuration = 4, Price = 340, Destinations = Destinations.London, PackageStatus = Status.Expired };
            Package p5 = new Package() { Title = "Rome", Description = "Vacations at Rome",MainPhoto= "https://c.pxhere.com/photos/a9/4e/colosseum_rome_italy_roman_architecture_landmark_italian_tourism-744892.jpg!d", TripDate = new DateTime(2021, 5, 12), TripDuration = 6, Price = 529, Destinations = Destinations.Barcelona, PackageStatus = Status.Expired };
            List<Package> packages = new List<Package>() { p1, p2, p3, p4, p5 };
            db.Packages.AddRange(packages);

            //Booking Seeding
            Booking b1 = new Booking() { PurchaseDate = new DateTime(2022, 02, 02) };
            Booking b2 = new Booking() { PurchaseDate = new DateTime(2022, 04, 02) };
            Booking b3 = new Booking() { PurchaseDate = new DateTime(2022, 08, 04) };
            Booking b4 = new Booking() { PurchaseDate = new DateTime(2021, 12, 28) };
            Booking b5 = new Booking() { PurchaseDate = new DateTime(2021, 03, 02) };
            List<Booking> bookings = new List<Booking>() { b1, b2, b3, b4, b5 };
            db.Bookings.AddRange(bookings);

            b1.Package = p1;
            b2.Package = p2;
            b3.Package = p3;
            b4.Package = p4;
            b5.Package = p5;

            //Photo Seeding
            Photo photosAthens = new Photo() { Destinations = Destinations.Athens, Url = "https://3.bp.blogspot.com/-ZfIVrmoK0HA/XfsiM6oOIkI/AAAAAAABsfI/qwIuU7cz9ukjN2pw0wECSCR48Bulvf8IACK4BGAYYCw/s1600/Screenshot_5.jpg" };
            Photo photosBarcelona1 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://c.pxhere.com/photos/fd/f4/museum_historically_architecture_building_barcelona_city_park_spain-1414417.jpg!s1" };
            Photo photosBarcelona2 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://c.pxhere.com/photos/d6/f3/national_palace_palau_nacional_palace_abendstimmung_twilight_afterglow_barcelona_sky-950954.jpg!s1" };
            Photo photosBarcelona3 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://c.pxhere.com/photos/91/ac/barcelona_montjuic_sunset_plaza_espa_a-1068204.jpg!s1" };
            Photo photosLondon = new Photo() { Destinations = Destinations.London, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvp5BzRDdhtlUNh7CGHYdVp_HFwDs_FOx-Ow&usqp=CAU" };
            Photo photosParis = new Photo() { Destinations = Destinations.Paris, Url = "https://c.pxhere.com/photos/3c/c2/eiffel_tower_paris-159.jpg!s1" };
            Photo photosRome = new Photo() { Destinations = Destinations.Rome, Url = "http://www.cosavisitarearoma.it/images/immagini_articoli/piazza-di-spagna.jpg" };
            List<Photo> photos = new List<Photo>() { photosAthens,photosBarcelona1, photosBarcelona2,photosBarcelona3 , photosLondon, photosParis, photosRome };
            db.Photos.AddRange(photos);

            p1.Photos.Add(photosBarcelona1);
            p1.Photos.Add(photosBarcelona2);
            p1.Photos.Add(photosBarcelona3);
            p2.Photos.Add(photosParis);
            p3.Photos.Add(photosAthens);
            p4.Photos.Add(photosLondon);
            p5.Photos.Add(photosRome);



            // Comment Seeding
            Comment com1 = new Comment() { CommentContent = "Excellent! Very good service from beginning to end", PostTime=new DateTime(2022,01,25) };
            Comment com2 = new Comment() { CommentContent = "Awesome support! Very much appreciated",PostTime=new DateTime(2021,05,29) };
            List<Comment> comments = new List<Comment>() { com1, com2 };
            db.Comments.AddRange(comments);

            p1.Comments.Add(com2);
            p5.Comments.Add(com1);


            //Flight Seeding
            Flight f1 = new Flight() { CompanyName = "Aegean Airlines" };
            Flight f2 = new Flight() { CompanyName = "Turkish Airlines" };
            Flight f3 = new Flight() { CompanyName = "Lufthansa Airlines" };
            List<Flight> flights = new List<Flight>() { f1, f2, f3 };
            db.Flights.AddRange(flights);

            p1.Flight = f1;
            p2.Flight = f2;
            p3.Flight = f2;
            p4.Flight = f3;
            p5.Flight = f1;

            //Hotel Seeding
            Hotel h1 = new Hotel() { HotelName = "Saint-Roch", HotelStars = 2, Destinations = Destinations.Paris };
            Hotel h2 = new Hotel() { HotelName = "InnAthens", HotelStars = 3, Destinations = Destinations.Athens };
            Hotel h3 = new Hotel() { HotelName = "Royal House", HotelStars = 4, Destinations = Destinations.Rome };
            Hotel h4 = new Hotel() { HotelName = "Catalonia Atenas", HotelStars = 3, Destinations = Destinations.Barcelona };
            Hotel h5 = new Hotel() { HotelName = "The California", HotelStars = 3, Destinations = Destinations.London };
            List<Hotel> hotels = new List<Hotel>() { h1, h2, h3, h4, h5 };
            db.Hotels.AddRange(hotels);

            p1.Hotel = h4;
            p2.Hotel = h1;
            p3.Hotel = h2;
            p4.Hotel = h3;
            p5.Hotel = h5;

            //Rate Seeding
            Rating r1 = new Rating() { RateScore = 3};
            Rating r2 = new Rating() { RateScore = 5};
            Rating r3 = new Rating() { RateScore = 4};
            List<Rating> ratings = new List<Rating>() { r1, r2, r3 };
            db.Ratings.AddRange(ratings);

            p1.Ratings.Add(r1);
            p1.Ratings.Add(r3);
            p2.Ratings.Add(r2);



            //ApplicationUser Seeding
            ApplicationUser ap1 = new ApplicationUser() { UserName = "John11", Email = "john1@yahoo.gr", FirstName = "John", LastName = "Hopkins" };
            ApplicationUser ap2 = new ApplicationUser() { UserName = "Nick22", Email = "nick1@gmail.com", FirstName = "Nick", LastName = "Hughes" };

            List<ApplicationUser> applicationUsers = new List<ApplicationUser>() { ap1,ap2 };

            db.Users.Add(ap1);
            db.Users.Add(ap2);

            com1.ApplicationUser = ap1;
            com2.ApplicationUser = ap2;



            //ReplyComment Seeding
             ReplyComment rep1=new ReplyComment() {ReplyContent= "All recommendations were within our budget. An invaluable service! Thank you",ReplyPostTime=DateTime.Now };
             ReplyComment rep2=new ReplyComment() {ReplyContent= "The video chat was well worth the fee, and helped us to fell confident about our choices for the trip",ReplyPostTime=DateTime.Now };

        

            List<ReplyComment> replyComments = new List<ReplyComment>() { rep1, rep2 };

            db.ReplyComments.AddRange(replyComments);

            rep1.ApplicationUser = ap1;
            rep2.ApplicationUser = ap2;

            com1.ReplyComments.Add(rep2);
            com2.ReplyComments.Add(rep1);

            db.SaveChanges();
        }

    }
}
