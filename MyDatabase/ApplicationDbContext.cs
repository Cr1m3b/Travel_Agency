using Entities.IdentityUsers;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDatabase.Initializers;

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

    }
}
