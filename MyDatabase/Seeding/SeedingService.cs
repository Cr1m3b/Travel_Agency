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
        }

        // User Seeding
        public void SeedUsers()
        {
            User user1 = new User() { FirstName = "John", LastName = "Fox", Email = "JohnFox@yahoo.com",ContactNumber="6984578901",Country="United States of America" };
            User user2 = new User() { FirstName = "Jane", LastName = "Lewis", Email = "JaneLewis@hotmail.com",ContactNumber= "6978798963", Country="Canada" };
            db.USERS.Add(user1);
            db.USERS.Add(user2);
            db.SaveChanges();
        }

        // Comment Seeding
        public void SeedComments()
        {
            Comment com1 = new Comment() { CommentContent = "Excellent! Very good service from beginning to end",FirstName="Kate",LastName="Sutton"};
            Comment com2 = new Comment() { CommentContent = "Awesome support! Very much appreciated", FirstName = "Juan", LastName = "Lasso" };
            db.Comments.Add(com1);
            db.Comments.Add(com2);
            db.SaveChanges();
        }
    }
}
