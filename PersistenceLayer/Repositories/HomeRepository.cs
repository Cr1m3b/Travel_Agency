using Entities.Models;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistenceLayer.Repositories
{
    public class HomeRepository
    {
        private ApplicationDbContext db;

       

        public HomeRepository(ApplicationDbContext MyContent)
        {
            db = MyContent; 
        }
         
        public IEnumerable<Package> GetThreeMaxDiscounts()
        {

         var packages= db.Packages.Where(p=>p.Discount!=0).OrderBy(p=>p.Discount).Take<Package>(3).ToList();



            return packages; 






        }
        

    }
}
