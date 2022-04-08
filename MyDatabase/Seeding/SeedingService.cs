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
            Package p1 = new Package() { Title = "Barcelona", Description = "Vacations at Barcelone",Program="1- Visiting city and museums 2-Barcelone Zoo  3-Seaside walk", MainPhoto= "https://c.pxhere.com/photos/a9/f0/spain_barcelona_triumphal_arch_street_view_spain_landscape_building-642076.jpg!d", TripDate = new DateTime(2022, 6, 12), TripDuration = 4, Price = 476, Destinations = Destinations.Barcelona, PackageStatus = Status.Active };
            Package p2 = new Package() { Title = "Paris", Description = "Vacations at Paris", Program = "1- Visiting city and museums 2-Barcelone Zoo  3-Seaside walk", MainPhoto= "https://fadeceilings.com/wp-content/uploads/2019/08/AdobeStock_65117955-720x460.jpeg", TripDate = new DateTime(2022, 5, 3), TripDuration = 3, Price = 699, Destinations = Destinations.Paris, PackageStatus = Status.Active };
            Package p3 = new Package() { Title = "Athens", Description = "Vacations at Athens", Program = "1- Visiting city and museums 2-Barcelone Zoo  3-Seaside walk", MainPhoto = "https://c.pxhere.com/photos/a9/a9/temple_athens_greece_architecture_ancient_greek_history_culture-763875.jpg!s1", TripDate = new DateTime(2022, 9, 1),Discount=25, TripDuration = 5, Price = 355, Destinations = Destinations.Athens, PackageStatus = Status.Pending };
            Package p4 = new Package() { Title = "London", Description = "Vacations at London", Program = "1- Visiting city and museums 2-Barcelone Zoo  3-Seaside walk", MainPhoto = "https://c.pxhere.com/photos/29/2d/london_parliament_england_ben_ben_westminster_tower_city_british-772846.jpg!d", TripDate = new DateTime(2022, 1, 12), TripDuration = 4, Price = 340, Destinations = Destinations.London, PackageStatus = Status.Expired };
            Package p5 = new Package() { Title = "Rome", Description = "Vacations at Rome", Program = "1- Visiting city and museums 2-Barcelone Zoo  3-Seaside walk", MainPhoto = "https://c.pxhere.com/photos/a9/4e/colosseum_rome_italy_roman_architecture_landmark_italian_tourism-744892.jpg!d", TripDate = new DateTime(2021, 5, 12), TripDuration = 6, Price = 529, Destinations = Destinations.Rome, PackageStatus = Status.Expired };
            Package p6 = new Package() { Title = "Lisbon", Description = "Vacations at Lisbon", Program = "1- Visiting city and museums 2-Barcelone Zoo  3-Seaside walk", MainPhoto = "https://www.nationsonline.org/gallery/Portugal/Praca-do-Comercio-Lisbon.jpg", TripDate = new DateTime(2022, 4, 30), TripDuration = 3, Price = 329, Discount=30, Destinations = Destinations.Lisbon, PackageStatus = Status.Active };
            Package p7 = new Package() { Title = "Cappadocia", Description = "Explore Cappadocia", Program = "1- Visiting city and museums 2-Barcelone Zoo  3-Seaside walk", MainPhoto = "https://d1hjkbq40fs2x4.cloudfront.net/2020-12-07/files/16072849260.jpg", TripDate = new DateTime(2022, 8, 15), TripDuration = 5, Price = 633, Discount = 20, Destinations = Destinations.Cappadocia, PackageStatus = Status.Active };

            List<Package> packages = new List<Package>() { p1, p2, p3, p4, p5,p6,p7};
            db.Packages.AddRange(packages);


            //ApplicationUser Seeding
            ApplicationUser ap1 = new ApplicationUser() { UserName = "John11", FirstName = "John", LastName = "Hopkins", PhoneNumber = "+30 6984548965", Email = "john1@yahoo.gr", Birthday = new DateTime(1990, 8, 1), Country = "France", City = "Paris", ZipCode = "75001", Address = "Rue Pierre Guérin 21" };
            ApplicationUser ap2 = new ApplicationUser() { UserName = "Nick22", FirstName = "Nick", LastName = "Hughes", PhoneNumber = "+30 6981236365", Email = "nick1@gmail.com", Birthday = new DateTime(1984, 5, 10), Country = "Greece", City = "Athens", ZipCode = "10431", Address = "Patision 32" };

            db.Users.Add(ap1);
            db.Users.Add(ap2);

            //Booking Seeding
            Booking b1 = new Booking() { FirstName = ap1.FirstName, LastName = ap1.LastName, Email = ap1.Email, PhoneNumber = ap1.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 02), PackagesCost = 476 };
            Booking b2 = new Booking() { FirstName = ap2.FirstName, LastName = ap2.LastName, Email = ap2.Email, PhoneNumber = ap2.PhoneNumber, PurchaseDate = new DateTime(2022, 04, 05), PackagesCost = 699 };
            Booking b3 = new Booking() { FirstName = "John", LastName = "Smith", Email = " j.s@gmail.com", PhoneNumber = "+306547896325", PurchaseDate = new DateTime(2022, 03, 29), PackagesCost = 962 };
            Booking b4 = new Booking() { FirstName = "Tim", LastName = "Correy", Email = " t.c@gmail.com", PhoneNumber = "+306544566325", PurchaseDate = new DateTime(2022, 03, 31), PackagesCost = 800 };
            Booking b5 = new Booking() { FirstName = "Olivia", LastName = "Elem", Email = " olivia.el@gmail.com", PhoneNumber = "+410644566325", PurchaseDate = new DateTime(2021, 10, 04), PackagesCost = 340 };
            Booking b6 = new Booking() { FirstName = "Ema", LastName = "Diana", Email = " em.diana@gmail.com", PhoneNumber = "+416564866325", PurchaseDate = new DateTime(2021, 04, 04), PackagesCost = 529 };
            Booking b7 = new Booking() { FirstName = "Bora", LastName = "Rraja", Email = " bora@rraja@gmail.com", PhoneNumber = "+3553694566325", PurchaseDate = new DateTime(2022, 08, 02), PackagesCost = 355 };
            Booking b8 = new Booking() { FirstName = "Sara", LastName = "Nosedive", Email = " sar.rrota@gmail.com", PhoneNumber = "+906544566325", PurchaseDate = new DateTime(2022, 06, 15), PackagesCost = 355 };
            Booking b9 = new Booking() { FirstName = "Ilda", LastName = "Tufa", Email = " i.tufa@gmail.com", PhoneNumber = "+35565445665695", PurchaseDate = new DateTime(2022, 07, 19), PackagesCost = 355 };

            List<Booking> bookings = new List<Booking>() { b1, b2, b3, b4, b5, b6, b7, b8, b9 };
           
            db.Bookings.AddRange(bookings);

            b1.Packages.Add(p1);
            b2.Packages.Add(p2);
            b3.Packages.Add(p6);
            b3.Packages.Add(p7);
            b2.Packages.Add(p1);
            b3.Packages.Add(p1);
            b4.Packages.Add(p2);

            b1.ApplicationUser = ap1;
            b2.ApplicationUser = ap2;
            b4.Packages.Add(p4);
            b5.Packages.Add(p4);
            b6.Packages.Add(p5);
            b7.Packages.Add(p3);
            b8.Packages.Add(p3);
            b9.Packages.Add(p3);


            //Photo Seeding
            Photo photosAthens = new Photo() { Destinations = Destinations.Athens, Url = "https://3.bp.blogspot.com/-ZfIVrmoK0HA/XfsiM6oOIkI/AAAAAAABsfI/qwIuU7cz9ukjN2pw0wECSCR48Bulvf8IACK4BGAYYCw/s1600/Screenshot_5.jpg" };
            Photo photosBarcelona1 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://c.pxhere.com/photos/fd/f4/museum_historically_architecture_building_barcelona_city_park_spain-1414417.jpg!s1" };
            Photo photosBarcelona2 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://c.pxhere.com/photos/d6/f3/national_palace_palau_nacional_palace_abendstimmung_twilight_afterglow_barcelona_sky-950954.jpg!s1" };
            Photo photosBarcelona3 = new Photo() { Destinations = Destinations.Barcelona, Url = "https://c.pxhere.com/photos/91/ac/barcelona_montjuic_sunset_plaza_espa_a-1068204.jpg!s1" };
            Photo photosLondon = new Photo() { Destinations = Destinations.London, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvp5BzRDdhtlUNh7CGHYdVp_HFwDs_FOx-Ow&usqp=CAU" };
            Photo photosParis = new Photo() { Destinations = Destinations.Paris, Url = "https://c.pxhere.com/photos/3c/c2/eiffel_tower_paris-159.jpg!s1" };
            Photo photosRome = new Photo() { Destinations = Destinations.Rome, Url = "http://www.cosavisitarearoma.it/images/immagini_articoli/piazza-di-spagna.jpg" };
            Photo photosLisbon = new Photo() { Destinations = Destinations.Lisbon, Url = "https://www.nationsonline.org/gallery/Portugal/Praca-do-Comercio-Lisbon.jpg" };
            Photo photoCappadocia = new Photo() { Destinations = Destinations.Cappadocia, Url = "https://www.acetestravel.com/tour-image/cappadocia-27.webp" };
            Photo photoCappadocia1 = new Photo() { Destinations = Destinations.Cappadocia, Url = "https://cf.bstatic.com/xdata/images/hotel/max1024x768/318992085.jpg?k=5a5214d69215f0998e8b9aaeb42c90330a66c60c64dfd2ee18dbeece0af43c78&o=&hp=1" };


            List<Photo> photos = new List<Photo>() { photosAthens,photosBarcelona1, photosBarcelona2,photosBarcelona3 , photosLondon, photosParis, photosRome, photosLisbon,photoCappadocia,photoCappadocia1 };
            db.Photos.AddRange(photos);

            p1.Photos.Add(photosBarcelona1);
            p1.Photos.Add(photosBarcelona2);
            p1.Photos.Add(photosBarcelona3);
            p2.Photos.Add(photosParis);
            p3.Photos.Add(photosAthens);
            p4.Photos.Add(photosLondon);
            p5.Photos.Add(photosRome);
            p6.Photos.Add(photosLisbon);
            p7.Photos.Add(photoCappadocia);
            p7.Photos.Add(photoCappadocia1);

            // Comment Seeding
            Comment com1 = new Comment() { CommentContent = "Excellent! Very good service from beginning to end", PostTime=new DateTime(2022,01,25),Rating=4 };
            Comment com2 = new Comment() { CommentContent = "Awesome support! Very much appreciated",PostTime=new DateTime(2021,05,29), Rating = 5 };
            List<Comment> comments = new List<Comment>() { com1, com2 };
            db.Comments.AddRange(comments);

            p1.Comments.Add(com2);
            p5.Comments.Add(com1);

            com1.ApplicationUser = ap1;
            com2.ApplicationUser = ap2;


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
            p6.Flight = f3;
            p7.Flight = f2;
        

            //Hotel Seeding
           
            Hotel h1 = new Hotel() { HotelName = "Saint-Roch", MapEmbededUrl= "https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d1371578.3464393283!2d0.4517993!3d47.8228538!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x47e66e2fc254a387%3A0x577904b1300e4ac7!2sH%C3%B4tel%20Saint%20Roch!5e0!3m2!1sen!2sgr!4v1647555131144!5m2!1sen!2sgr", HotelStars = 2, Destinations = Destinations.Paris };
            Hotel h2 = new Hotel() { HotelName = "InnAthens", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3145.1600039324967!2d23.732028314815786!3d37.97339510848113!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x14a1bd3e119676e7%3A0x93f811d49b5e927d!2sINNATHENS%20HOTEL!5e0!3m2!1sen!2sgr!4v1647557551859!5m2!1sen!2sgr", HotelStars = 3, Destinations = Destinations.Athens };
            Hotel h3 = new Hotel() { HotelName = "Royal Palace Luxury Hotel", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d23755.145321876313!2d12.46329223955078!3d41.90590610000001!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x132f6055aa8c9451%3A0x6136f4b5c3fb2d3c!2sRoyal%20Palace%20Luxury%20Hotel!5e0!3m2!1sen!2sgr!4v1647563026489!5m2!1sen!2sgr", HotelStars = 4, Destinations = Destinations.Rome };
            Hotel h4 = new Hotel() { HotelName = "Catalonia Atenas", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d5984.501640833719!2d2.1822930631818833!3d41.412073656162754!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x12a4a32887f34395%3A0xd83c995bbcadbca8!2sHotel%20Catalonia%20Atenas!5e0!3m2!1sen!2sgr!4v1647557627131!5m2!1sen!2sgr", HotelStars = 3, Destinations = Destinations.Barcelona };
            Hotel h5 = new Hotel() { HotelName = "The California", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2482.111756808161!2d-0.12565318469073225!3d51.52951001690808!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x48761b395f8925f1%3A0xb1a49585b93e2b35!2sThe%20California%20Hotel!5e0!3m2!1sen!2sgr!4v1647557761307!5m2!1sen!2sgr", HotelStars = 3, Destinations = Destinations.London };
            Hotel h6 = new Hotel() { HotelName = "Patio São Vicente", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3113.096701465115!2d-9.1302479851608!3d38.715588765246316!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0xd19338a3d909c55%3A0x583a038c8d45001f!2sPatio%20S%C3%A3o%20Vicente%20Guest%20Houses!5e0!3m2!1sen!2sgr!4v1647557953711!5m2!1sen!2sgr", HotelStars = 4, Destinations = Destinations.Lisbon };
            Hotel h7 = new Hotel() { HotelName = "Artemis Cave Suits", MapEmbededUrl = "https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3116.350357757421!2d34.8294108148368!3d38.64082366963287!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x152a687723611df9%3A0xf53172bac40e5847!2sArtemis%20Cave%20Suites!5e0!3m2!1sen!2sgr!4v1647558056432!5m2!1sen!2sgr", HotelStars = 2, Destinations = Destinations.Cappadocia };

            List<Hotel> hotels = new List<Hotel>() { h1, h2, h3, h4, h5,h6,h7 };
            db.Hotels.AddRange(hotels);

            p1.Hotel = h4;
            p2.Hotel = h1;
            p3.Hotel = h2;
            p4.Hotel = h5;
            p5.Hotel = h3;
            p6.Hotel = h6;
            p7.Hotel = h7;
          

            //Rate Seeding
            Rating r1 = new Rating() { RateScore = 3};
            Rating r2 = new Rating() { RateScore = 5};
            Rating r3 = new Rating() { RateScore = 4};
            List<Rating> ratings = new List<Rating>() { r1, r2, r3 };
            db.Ratings.AddRange(ratings);

            p1.Ratings.Add(r1);
            p1.Ratings.Add(r3);
            p2.Ratings.Add(r2);

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
