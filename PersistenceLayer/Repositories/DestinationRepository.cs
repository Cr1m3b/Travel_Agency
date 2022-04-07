using Entities.Models;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repositories
{
    public class DestinationRepository : GenericRepository<Package>
    {
        public DestinationRepository(ApplicationDbContext context) : base(context)
        {


        }
        public IEnumerable<Package> GetAllPackages()
        {
            return Context.Packages.ToList();
        }
    }
}
