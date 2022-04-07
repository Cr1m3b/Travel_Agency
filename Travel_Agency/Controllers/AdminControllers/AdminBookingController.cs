using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities.IdentityUsers;
using Entities.Models;
using MyDatabase;
using PersistenceLayer.Repositories;

namespace Travel_Agency.Controllers.AdminController
{
    public class AdminBookingController : Controller
    {
        private ApplicationDbContext db;
        BookingRepository repository;
        public AdminBookingController()
        {
            db =  new ApplicationDbContext();
            repository = new BookingRepository(db);
        }
        // GET: AdminBooking
        public ActionResult Index(string sortOrder)
        {
            var bookings = db.Bookings.Include(b => b.ApplicationUser).Include(b => b.Packages).ToList();

            switch (sortOrder)
            {
                case "BookAscend": bookings = bookings.OrderBy(b => b.PurchaseDate).ToList();break;
            }

            var bookings = repository.GetAllWithRelatedTables().OrderByDescending(b => b.PurchaseDate);
            return View(bookings);
        }

        // GET: AdminBooking/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = repository.GetById(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
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