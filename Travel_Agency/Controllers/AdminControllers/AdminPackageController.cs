using Entities.Enums;
using Entities.Models;
using MyDatabase;
using PersistenceLayer.Repositories;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers.AdminController
{
    public class AdminPackageController : Controller
    {
        private ApplicationDbContext db ;
        private PackageRepository packageRepository;
        public AdminPackageController()
        {
            db = new ApplicationDbContext();
            packageRepository = new PackageRepository(db);
        }
        // GET: AdminPackage
        public ActionResult Index(string status, string sortOrder)
        {
            var packages = packageRepository.GetAllWithRelatedTables().ToList();
            if (status == "active")
            {
                packages = packages.Where(x => x.PackageStatus == Status.Active).ToList();
            }
            if (status == "pending")
            {
                packages = packages.Where(x => x.PackageStatus == Status.Pending).ToList();
            }
            if (status == "expired")
            {
                packages = packages.Where(x => x.PackageStatus == Status.Expired).ToList();
            }

            switch (sortOrder)
            {
                case "TripAscend": packages = packages.OrderBy(p => p.TripDate).ToList(); break;
            }


            return View(packages);
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
        public ActionResult Create([Bind(Include = "PackageId,Title,MainPhoto,Description,Program,TripDate,TripDuration,Price,Discount,Destinations,PackageStatus,HotelId,FlightId")] Package package, HttpPostedFileBase[] galleryPhotos, HttpPostedFileBase packagePhoto)
        {
            if (galleryPhotos != null)
            {
                List<Photo> packagePhotos = new List<Photo>();
                foreach (var photo in galleryPhotos)
                {
                    string url = "/Content/Images/" + photo.FileName;
                    photo.SaveAs(Server.MapPath(url));
                    var ph = new Photo() { Destinations = package.Destinations, Url = url };
                    packagePhotos.Add(ph);
                }
                package.Photos = packagePhotos;
            }
            if (packagePhoto != null)
            {
                string url = "/Content/Images/" + packagePhoto.FileName;
                packagePhoto.SaveAs(Server.MapPath(url));
                package.MainPhoto = url;
            }

            if (ModelState.IsValid)
            {
                packageRepository.Add(package);
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
            Package package =packageRepository.GetByIdWithRelatedTables(id);
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
        public ActionResult Edit(Package package, HttpPostedFileBase[] galleryPhotos, HttpPostedFileBase packagePhoto)
        {
            if (packagePhoto != null)
            {
                string url = "/Content/Images/" + packagePhoto.FileName;
                packagePhoto.SaveAs(Server.MapPath(url));
                package.MainPhoto = url;
            }
            if (galleryPhotos != null)
            {
             
                //var photoIds= package.Photos.Select(x => x.PhotoId).ToList();
                //foreach (var id in photoIds)
                //{
                //    var photo = db.Photos.Find(id);
                //    db.Entry(photo).State = EntityState.Deleted;
                //    db.SaveChanges();
                //}

                List<Photo> packagePhotos = new List<Photo>();
                foreach (var photo in galleryPhotos)
                {
                    if (photo != null)
                    {
                        string url = "/Content/Images/" + photo.FileName;
                        photo.SaveAs(Server.MapPath(url));
                        var ph = new Photo() { Destinations = package.Destinations, Url = url };
                        packagePhotos.Add(ph);
                    }
                }
                if (packagePhotos.Count > 0)
                {
                    package.Photos = packagePhotos;
                    foreach (var photo in package.Photos)
                    {
                        db.Entry(photo).State = EntityState.Added;
                    }
                }
            }

            
            if (ModelState.IsValid)
            {
                packageRepository.Edit(package);
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
            Package package =packageRepository.GetByIdWithRelatedTables(id);
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
            var package = packageRepository.GetByIdWithRelatedTables(id);
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
            packageRepository.Delete(id);

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
