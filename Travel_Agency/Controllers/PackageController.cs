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
        PackageRepository packageRepository;

        public PackageController()
        {
            db = new ApplicationDbContext();
            packageRepository = new PackageRepository(db);
        }
        // GET: Package
        public ActionResult Index(string search,decimal? minPrice,decimal? maxPrice, DateTime? checkIn)
        {
            var activePackages = packageRepository.GetAllWithRelatedTables().Where(p => p.PackageStatus == Status.Active).ToList();
           
            if (!String.IsNullOrWhiteSpace(search))
            {
                activePackages = activePackages.Where(p => p.Destinations.ToString().ToUpper().Contains(search.ToUpper())).ToList();
            }
            if (minPrice!=null && minPrice>0)
            {
                activePackages = activePackages.Where(p => p.FinalPrice() >= minPrice).ToList();
            }
            if (maxPrice != null && minPrice > 0)
            {
                activePackages = activePackages.Where(p => p.FinalPrice() <= maxPrice).ToList();
            }
            if (checkIn!=null)
            {
                var minCheckInDate = ((DateTime)checkIn).AddDays(-4);
                var maxCheckInDate = ((DateTime)checkIn).AddDays(4);
                activePackages = activePackages.Where(p => p.TripDate >= minCheckInDate && p.TripDate <=maxCheckInDate).ToList();
            }
            return View(activePackages);
        }
        public ActionResult PackagesPerDestination(string destination)
        {
            var packages = packageRepository.GetAll().Where(p => p.Destinations.ToString().Equals(destination)).ToList();

            return View(packages);
        }


        public ActionResult PackageOffer()
        {
            var packages = packageRepository.GetAllWithRelatedTables().Where(p => p.Discount != 0).ToList();

            return View(packages);
        }
        public ActionResult PackageReviews()
        {
            var allPackagesWithReviews = packageRepository.GetAllWithRelatedTables()
                                        .Where(p=>p.PackageStatus==Status.Expired && p.Comments != null && p.Comments.Count>0)
                                        .ToList();

            return View(allPackagesWithReviews);
        }


        // GET: Package/Details/5
        public ActionResult Details(int? id)
        {
            var package = packageRepository.GetByIdWithRelatedTables(id);
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
