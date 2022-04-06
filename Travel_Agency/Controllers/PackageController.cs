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
        public ActionResult Index(string search)
        {
            var activePackages = repository.GetAllWithRelatedTables().Where(p => p.PackageStatus == Status.Active).ToList();

            if (!String.IsNullOrWhiteSpace(search))
            {
                activePackages = activePackages.Where(p => p.Title.ToUpper().Contains(search.ToUpper())  ||
                                                      p.Description.ToUpper().Contains(search.ToUpper()) || 
                                                      p.Program.ToUpper().Contains(search.ToUpper()) ||
                                                      p.Destinations.ToString().ToUpper().Contains(search.ToUpper()))
                                                      .ToList();
            }
            return View(activePackages);
        }
        public ActionResult PackagesPerDestination(string destination)
        {
            var packages = repository.GetAll().Where(p => p.Destinations.ToString().Equals(destination)).ToList();

            return View(packages);
        }


        public ActionResult PackageOffer()
        {
            var packages = repository.GetAllWithRelatedTables().Where(p => p.Discount != 0).ToList();

            return View(packages);
        }
        public ActionResult PackageReviews()
        {
            var allPackagesWithReviews = repository.GetAllWithRelatedTables()
                                        .Where(p=>p.PackageStatus==Status.Expired && p.Comments != null && p.Comments.Count>0)
                                        .ToList();

            return View(allPackagesWithReviews);
        }


        // GET: Package/Details/5
        public ActionResult Details(int? id)
        {
            var package = repository.GetByIdWithRelatedTables(id);
            if (package == null)
                {
                    return HttpNotFound();
                }
            
            return View(package);
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
