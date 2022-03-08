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
using MyDatabase;

namespace Travel_Agency.Controllers.AdminController
{
    public class AdminPackageController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: AdminPackage
        public ActionResult Index(string status)
        {
            var packages = db.Packages.Include(x => x.Flight).Include(x => x.Hotel).ToList();
            if (status == "active")
            {
              packages= packages.Where(x => x.PackageStatus == Status.Active).ToList();
            }
            if (status == "pending")
            {
                packages = packages.Where(x => x.PackageStatus == Status.Pending).ToList();
            }
            if (status == "expired")
            {
                packages = packages.Where(x => x.PackageStatus == Status.Expired).ToList();
            }
 
            return View(packages);
        }

        // GET: AdminPackage/Details/5
        public ActionResult Details(int? id)
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

        // GET: AdminPackage/Create
        public ActionResult Create()
        {
            ViewBag.FlightId = new SelectList(db.Flights, "FlightId", "CompanyName");
            ViewBag.HotelId = new SelectList(db.Hotels, "HotelId", "HotelName");
            return View();
        }

        // POST: AdminPackage/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PackageId,Title,MainPhoto,Description,TripDate,TripDuration,Price,Destinations,PackageStatus,HotelId,FlightId")] Package package)
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

        // GET: AdminPackage/Edit/5
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

        // POST: AdminPackage/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PackageId,Title,MainPhoto,Description,TripDate,TripDuration,Price,Destinations,PackageStatus,HotelId,FlightId")] Package package)
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

        // GET: AdminPackage/Delete/5
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

        // POST: AdminPackage/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var package = db.Packages.Where(x => x.PackageId == id).Include(x => x.Comments).Include(x => x.Ratings).FirstOrDefault();
            if (package == null)
            {
                return HttpNotFound();
            }
            var commentIds = package.Comments.Select(x => x.CommentId).ToList();
            foreach (var com in commentIds)
            {
                var comment = db.Comments.Find(com);
                db.Entry(comment).State = EntityState.Deleted;
            }
            db.SaveChanges();
            var ratingIds = package.Ratings.Select(x => x.RatingId).ToList();
            foreach (var rate in ratingIds)
            {
                var rating = db.Ratings.Find(rate);
                db.Entry(rating).State = EntityState.Deleted;
            }
            db.SaveChanges();
            db.Entry(package).State = EntityState.Deleted;
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
