using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MyDatabase.Seeding;

namespace MyDatabase.Initializers
{
    public class MockupDbInitializer : DropCreateDatabaseAlways<ApplicationDbContext>
    {
        protected override void Seed(ApplicationDbContext db)
        {
            SeedingService service = new SeedingService(db);
            //Seeding Methods ex. service.SeedPackages();
            service.SeedPackages();

            base.Seed(db);
        }
    }
}
