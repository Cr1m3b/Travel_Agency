using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
    
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
            Package p1 = new Package() { Title = "Beautiful Spain", Description = "Vacations at Barcelone", TripDate = new DateTime(2022, 5, 12), TripDuration = 4, Price = 476 };
            Booking b1 = new Booking() { PurchaseDate = new DateTime(2022, 02, 02) };
            db.Packages.Add(p1);
            db.Bookings.Add(b1);
            b1.Package = p1;
            db.SaveChanges();
            //(V)TodoSeedingfor her classes


            // Comment Seeding

            Comment com1 = new Comment() { CommentContent = "Excellent! Very good service from beginning to end" };
            Comment com2 = new Comment() { CommentContent = "Awesome support! Very much appreciated" };
            db.Comments.Add(com1);
            db.Comments.Add(com2);
            db.SaveChanges();

        }

    }
}
