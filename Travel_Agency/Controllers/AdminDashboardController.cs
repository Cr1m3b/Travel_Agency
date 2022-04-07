using Entities.Models.ViewModels;
using MyDatabase;
using PersistenceLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers
{
    public class AdminDashboardController : Controller
    {
        private ApplicationDbContext db;
        private BookingRepository repository;
        public AdminDashboardController()
        {
            db = new ApplicationDbContext();
            repository = new BookingRepository(db);
        }


        //[Authorize]
        public ActionResult Index()
        {
            var users = db.Users.ToList();
            var earnings = repository.GetAll().Sum(b => b.PackagesCost);
            var todayBookings = repository.GetAll().Where(b => b.PurchaseDate.Date == DateTime.Now.Date).ToList();
            var recentBookings = repository.GetAllWithRelatedTables().Where(b => b.PurchaseDate.Date >= DateTime.Now.Date.AddDays(-30)).OrderByDescending(b => b.PurchaseDate).ToList();

            DashboardViewModel vm = new DashboardViewModel()
            {
                Users = users,
                Earnings = earnings,
                TodayBookings = todayBookings,
                RecentBookings = recentBookings
            };
            return View(vm);
        }

        //Get: AllUsers
        public ActionResult AllUsers()
        {
            var users = db.Users.Include(u => u.Bookings).ToList();
            return View(users);
        }

        public ActionResult AddUser()
        {
            return View();
        }

        //Get: Edit One User
        public ActionResult EditUser(string username)
        {
            var user = db.Users.ToList().Find(u => u.UserName == username);
            if (user != null)
            {
                return View(user);
            }
            else
            {
                return HttpNotFound();
            }

        }
    }
}