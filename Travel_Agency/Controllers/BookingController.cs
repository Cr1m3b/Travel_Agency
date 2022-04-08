using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities.IdentityUsers;
using Entities.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using MyDatabase;
using PersistenceLayer.Repositories;


namespace Travel_Agency.Controllers
{
    public class BookingController : Controller
    {
        private ApplicationDbContext db;
        BookingRepository repository;
        public BookingController()
        {
            db = new ApplicationDbContext();
            repository = new BookingRepository(db);
        }

        // GET: Booking
        public ActionResult Index()
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());

            var bookings = repository.GetAllWithRelatedTables().Where(b => b.ApplicationUser.Id == user.Id);
 
            return View(bookings);
        }

        // GET: Booking/Create
        public ActionResult Create(string cancel)
        {
            ViewBag.Cancel = cancel;

            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
            var cart = (List<Item>)Session["cart"];
            if (cart != null)
            {
                decimal cost = 0;
                foreach (var item in cart)
                {
                    cost = cost + item.Package.FinalPrice() * item.Quantity;
                }
                ViewBag.PackageCost = cost;
            }
            if (user != null)
            {
                ViewBag.User = user;
            }
            return View();
        }

        // POST: Booking/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Booking booking)
        {
            ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());

            if (ModelState.IsValid)
            {
                if (user != null)
                {
                    booking.ApplicationUser = user;
                }
                var cart = (List<Item>)Session["cart"];
                if (cart != null)
                {
                    List<Package> packages = new List<Package>();
                    decimal cost = 0;
                    foreach (var item in cart)
                    {
                        packages.Add(item.Package);
                        cost = cost + item.Package.FinalPrice() * item.Quantity;
                    }
                    booking.Packages = packages;
                    booking.PackagesCost = cost;
                }
                booking.PurchaseDate = DateTime.Now;
            }
            Session["lastBooking"] = booking;
            return RedirectToAction("PaymentWithPaypal", "Paypal");
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
