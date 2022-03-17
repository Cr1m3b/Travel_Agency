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
using MyDatabase;

namespace Travel_Agency.Controllers
{
    public class PackageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Package
        public ActionResult Index()
        {
            var packages = db.Packages.Include(p => p.Flight).Include(p => p.Hotel).Include(p=>p.Photos);
            return View(packages.ToList());
        }
        public ActionResult PackagesPerDestination(string destination)
        {
            var packages = db.Packages.Where(p => p.Destinations.ToString().Equals(destination)).ToList();
          
            return View(packages);
        }
      

        public ActionResult PackageOffer()
        {
            var packages = db.Packages.Where(p=>p.Discount!=0).Include(p => p.Flight).Include(p => p.Hotel).Include(p => p.Photos).ToList();
         
            return View(packages);
        }
        public ActionResult PackageReviews()
        {
            var packages = db.Packages.Include(p => p.Flight).Include(p => p.Hotel).Include(p => p.Photos).Where(p=>p.PackageStatus == Status.Expired).ToList();
            return View(packages);
        }


        // GET: Package/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Package package = db.Packages.Include(p=>p.Photos)
                                         .Include(p=>p.Comments.Select(a=>a.ApplicationUser))
                                         .Include(p => p.Flight)
                                         .Include(p => p.Hotel)
                                         .ToList().Find(x=>x.PackageId==id);
            if (package == null)
            {
                return HttpNotFound();
            }
            return View(package);
        }


        // GET: Package/Create
        public ActionResult Create()
        {
            ViewBag.FlightId = new SelectList(db.Flights, "FlightId", "CompanyName");
            ViewBag.HotelId = new SelectList(db.Hotels, "HotelId", "HotelName");
            return View();
        }

        // POST: Package/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PackageId,Title,Description,TripDate,TripDuration,Price,Destinations,PackageStatus,HotelId,FlightId")] Package package)
        {
            if (ModelState.IsValid)
            {
                db.Packages.Add(package);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.FlightId = new SelectList(db.Flights, "FlightId", "CompanyName", package.FlightId);
            ViewBag.HotelId = new SelectList(db.Hotels, "HotelId", "HotelName", package.HotelId);
            return View(package);
        }

        // GET: Package/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Package package = db.Packages.Find(id);
            if (package == null)
            {
                return HttpNotFound();
            }
            ViewBag.FlightId = new SelectList(db.Flights, "FlightId", "CompanyName", package.FlightId);
            ViewBag.HotelId = new SelectList(db.Hotels, "HotelId", "HotelName", package.HotelId);
            return View(package);
        }

        // POST: Package/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PackageId,Title,Description,TripDate,TripDuration,Price,Destinations,PackageStatus,HotelId,FlightId")] Package package)
        {
            if (ModelState.IsValid)
            {
                db.Entry(package).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.FlightId = new SelectList(db.Flights, "FlightId", "CompanyName", package.FlightId);
            ViewBag.HotelId = new SelectList(db.Hotels, "HotelId", "HotelName", package.HotelId);
            return View(package);
        }

        // GET: Package/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Package package = db.Packages.Find(id);
            if (package == null)
            {
                return HttpNotFound();
            }
            return View(package);
        }

        // POST: Package/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Package package = db.Packages.Find(id);
            db.Packages.Remove(package);
            db.SaveChanges();
            return RedirectToAction("Index");
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
