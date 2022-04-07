using MyDatabase;
using PersistenceLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers
{
    public class DestinationController : Controller
    {

        private ApplicationDbContext db;
        DestinationRepository repository;

        public DestinationController()
        {
            db = new ApplicationDbContext();
            repository = new DestinationRepository(db);
        }
      
        // GET: Destination
        public ActionResult Index()
        {
            var packages = repository.GetAllPackages();
            return View(packages);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}