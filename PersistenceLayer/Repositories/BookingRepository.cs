using Entities.IdentityUsers;
using Entities.Models;
using MyDatabase;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PersistenceLayer.Repositories
{
    public class BookingRepository : GenericRepository<Booking>
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
