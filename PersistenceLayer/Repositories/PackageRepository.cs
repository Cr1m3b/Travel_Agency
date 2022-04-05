using Entities.Models;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PersistenceLayer.Repositories
{
    public class PackageRepository : GenericRepository<Package>
    {
        public PackageRepository(ApplicationDbContext context) : base(context)
        {
        }

        public IEnumerable<Package> GetAllWithRelatedTables()
        {
            return Context.Packages.Include(p => p.Flight)
                                   .Include(p => p.Hotel)
                                   .Include(p => p.Photos)
                                   .Include(p=> p.Ratings)
                                   .Include(p => p.Comments)
                                   .Include(p => p.Bookings)
                                   .ToList();
        }
        public Package GetByIdWithRelatedTables(int? id)
        {
            if(id== null)
            {
                throw new ArgumentException("Bad Request");
            }
            var package= Context.Packages.Include(p => p.Photos)
                                         .Include(p => p.Comments.Select(a => a.ApplicationUser))
                                         .Include(p => p.Comments.Select(r => r.ReplyComments))
                                         .Include(p => p.Flight)
                                         .Include(p => p.Hotel)
                                         .ToList().Find(x => x.PackageId == id);
            return package;
        }
    }
}
