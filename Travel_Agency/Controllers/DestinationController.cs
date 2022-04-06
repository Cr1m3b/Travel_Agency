using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers
{
    public class DestinationController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Destination
        public ActionResult Index()
        {
            var packages = db.Packages.ToList();
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