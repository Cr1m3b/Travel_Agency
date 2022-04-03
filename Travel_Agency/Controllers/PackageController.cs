using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities.Enums;
using Entities.Models;
using Entities.Models.Enums;
using Entities.Models.ViewModels;
using MyDatabase;
using PersistenceLayer.Repositories;

namespace Travel_Agency.Controllers
{
    public class PackageController : Controller
    {
        private ApplicationDbContext db;
        PackageRepository repository;

        public PackageController()
        {
            db = new ApplicationDbContext();
            repository = new PackageRepository(db);
        }
        // GET: Package
        public ActionResult Index()
        {
            var packages = repository.GetAllWithRelatedTables().Where(p => p.PackageStatus == Status.Active);
            //var activePackages = repository.GetAllWithRelatedTables().Where(p => p.PackageStatus == Status.Active).ToList();
            //var packageOffer = activePackages.Where(p => p.Discount != 0).Take(3).ToList();
            //var popularPackages = activePackages.Where(p => p.AveragePackageRating() >= 3).Take(3).ToList();

            //PackageViewModel vm = new PackageViewModel()
            //{
            //    ActivePackages=activePackages,
            //    PackageOffer = packageOffer,
            //    PopularPackages=popularPackages
            //};
            //return View(vm);
            return View(packages);
        }
        public ActionResult PackagesPerDestination(string destination)
        {
            var packages = db.Packages.Where(p => p.Destinations.ToString().Equals(destination)).ToList();

            return View(packages);
        }


        public ActionResult PackageOffer()
        {
            var packages = db.Packages.Where(p => p.Discount != 0).Include(p => p.Flight).Include(p => p.Hotel).Include(p => p.Photos).ToList();

            return View(packages);
        }
        public ActionResult PackageReviews()
        {
            var packages = db.Packages.Include(p => p.Flight)
                                      .Include(p => p.Comments.Select(a => a.ApplicationUser))
                                      .Include(p => p.Comments.Select(r => r.ReplyComments))
                                      .Include(p => p.Hotel)
                                      .Include(p => p.Photos)
                                      .Where(p => p.PackageStatus == Status.Expired).ToList();
            return View(packages);
        }


        // GET: Package/Details/5
        public ActionResult Details(int? id)
        {
            var package = repository.GetByIdWithRelatedTables(id);
            package.Comments.Select(a => a.ApplicationUser);
            package.Comments.Select(r => r.ReplyComments);
            if (package == null)
                {
                    return HttpNotFound();
                }
            
            return View(package);
        }

        // GET: Package/Edit/5

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
