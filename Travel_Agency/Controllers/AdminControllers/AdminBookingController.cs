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
using Entities.Models.ViewModels;
using MyDatabase;
using PersistenceLayer.Repositories;

namespace Travel_Agency.Controllers.AdminController
{
    public class AdminBookingController : Controller
    {
        private ApplicationDbContext db;
        private BookingRepository repository;
        private PackageRepository packageRepository;
        public AdminBookingController()
        {
            db =  new ApplicationDbContext();
            repository = new BookingRepository(db);
            packageRepository = new PackageRepository(db);
        }
        // GET: AdminBooking
        public ActionResult Index(string sortOrder)
        {
            var bookings = repository.GetAllWithRelatedTables().ToList();
            var packages = packageRepository.GetAllWithRelatedTables().ToList();


            switch (sortOrder)
            {
                case "BookAscend": bookings = bookings.OrderBy(b => b.PurchaseDate).ToList(); break;
                case "TripAscend": packages = packages.OrderBy(p => p.TripDate).ToList(); break;
            }


            AdminBookingViewModel AdBookVm = new AdminBookingViewModel()
            {

                AdminBookings = bookings,
                AdminPackages = packages
            };

            return View(AdBookVm);
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