﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Entities.Models.Enums;
using Entities.Enums;

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
            Package p1 = new Package() { Title = "Barcelona", Description = "Vacations at Barcelone", MainPhoto= "https://c.pxhere.com/photos/2c/b3/sagrada_familia_cathedral_architecture_monument_barcelona_pierre_religion_heritage-919514.jpg!s1", TripDate = new DateTime(2022, 5, 12), TripDuration = 4, Price = 476, Destinations = Destinations.Barcelona, PackageStatus = Status.Active };
            Package p2 = new Package() { Title = "Paris", Description = "Vacations at Paris",MainPhoto= "https://c.pxhere.com/photos/31/a4/eiffel_tower_lights_fountains_twilight_city_urban_paris_france-1046619.jpg!d", TripDate = new DateTime(2022, 5, 3), TripDuration = 3, Price = 699, Destinations = Destinations.Paris, PackageStatus = Status.Active };
            Package p3 = new Package() { Title = "Athens", Description = "Vacations at Athens",MainPhoto= "https://c.pxhere.com/photos/da/65/st_peter's_square_underwater_athens_acropolis-1018088.jpg!d", TripDate = new DateTime(2022, 9, 1), TripDuration = 5, Price = 355, Destinations = Destinations.Athens, PackageStatus = Status.Active };
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
            Photo photosBarcelona = new Photo() { Destinations = Destinations.Barcelona, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRdDk_JTBO1VJYeoHp3tnqs8XGkB7wfN9EY6Q&usqp=CAU" };
            Photo photosLondon = new Photo() { Destinations = Destinations.London, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRvp5BzRDdhtlUNh7CGHYdVp_HFwDs_FOx-Ow&usqp=CAU" };
            Photo photosParis = new Photo() { Destinations = Destinations.Paris, Url = "https://c.pxhere.com/photos/3c/c2/eiffel_tower_paris-159.jpg!s1" };
            Photo photosRome = new Photo() { Destinations = Destinations.Rome, Url = "http://www.cosavisitarearoma.it/images/immagini_articoli/piazza-di-spagna.jpg" };
            List<Photo> photos = new List<Photo>() { photosAthens, photosBarcelona, photosLondon, photosParis, photosRome };
            db.Photos.AddRange(photos);

            p1.Photos.Add(photosBarcelona);
            p2.Photos.Add(photosParis);
            p3.Photos.Add(photosAthens);
            p4.Photos.Add(photosLondon);
            p5.Photos.Add(photosRome);



            // Comment Seeding
            Comment com1 = new Comment() { CommentContent = "Excellent! Very good service from beginning to end", PostTime=new DateTime(2022,01,25) };
            Comment com2 = new Comment() { CommentContent = "Awesome support! Very much appreciated",PostTime=new DateTime(2021,05,29) };
            List<Comment> comments = new List<Comment>() { com1, com2 };
            db.Comments.AddRange(comments);

            p4.Comments.Add(com2);
            p5.Comments.Add(com1);


            //Flight Seeding
            Flight f1 = new Flight() { CompanyName = "Aegean" };
            Flight f2 = new Flight() { CompanyName = "Turkish Airlines" };
            Flight f3 = new Flight() { CompanyName = "Lufthansa" };
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
            Rating r1 = new Rating() { RateScore = 3, RatingTime=new DateTime(2022,06,15) };
            Rating r2 = new Rating() { RateScore = 5 ,RatingTime=new DateTime(2022,06,06)};
            Rating r3 = new Rating() { RateScore = 4 ,RatingTime=new DateTime(2022,09,09)};
            List<Rating> ratings = new List<Rating>() { r1, r2, r3 };
            db.Ratings.AddRange(ratings);

            p1.Ratings.Add(r1);
            p1.Ratings.Add(r3);
            p2.Ratings.Add(r2);
            p1.Ratings.Add(r1);


            db.SaveChanges();

        }

    }
}
