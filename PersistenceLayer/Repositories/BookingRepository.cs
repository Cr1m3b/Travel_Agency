using Entities.IdentityUsers;
using Entities.Models;
using MyDatabase;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PersistenceLayer.IRepositories;

namespace PersistenceLayer.Repositories
{
    public class BookingRepository : GenericRepository<Booking>,IBookingRepository
    {
        public BookingRepository(ApplicationDbContext context) : base(context)
        {
        }
        public IEnumerable<Booking> GetAllWithRelatedTables()
        {
            return Context.Bookings.Include(b => b.ApplicationUser)
                                   .Include(b => b.Packages)
                                   .ToList();
        }
    }
}
