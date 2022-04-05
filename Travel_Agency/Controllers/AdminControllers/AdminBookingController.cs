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
        BookingRepository repositroy;
        public AdminBookingController()
        {
            db =  new ApplicationDbContext();
            repositroy = new BookingRepository(db);
        }
        // GET: AdminBooking
        public ActionResult Index()
        {
            var bookings = repositroy.GetAllWithRelatedTables();
            return View(bookings);
        }

        // GET: AdminBooking/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = repositroy.GetById(id);
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