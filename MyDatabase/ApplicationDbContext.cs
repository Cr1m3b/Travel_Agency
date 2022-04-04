using Entities.IdentityUsers;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDatabase.Initializers;
using Entities.Models;

namespace MyDatabase
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<ApplicationDbContext>(new MockupDbInitializer());
            Database.Initialize(false);
        }


        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        //Declaration of the DbSets
        public DbSet<Package> Packages { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<Rating> Ratings { get; set; }
       
   
        public DbSet<ReplyComment> ReplyComments { get; set; }

    }
}
