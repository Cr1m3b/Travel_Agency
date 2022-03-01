using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            b1.Package = p1;
            db.SaveChanges();
        }
       
    }
}
