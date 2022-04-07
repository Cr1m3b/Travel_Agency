using Entities.Models;
using MyDatabase;
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
        public ApplicationDbContext db;
        public AdminDashboardController()
        {
            db = new ApplicationDbContext();
        }
        

        //[Authorize]
        public ActionResult Index()
        {
            var bookings = db.Bookings.Include(p => p.Packages).ToList();
            var packages = db.Packages.Include(b=>b.Bookings).ToList();
            

            List<int> times=new List<int>();
            List<string> Titles = new List<string> ();
            List<decimal> Income=new List<decimal> ();  

            foreach (var package in packages)
            {

                times.Add(package.Bookings.Count);  

            }
            foreach (var package in packages)
            {

                Income.Add(package.Bookings.Count* package.Price);

            }
            foreach (var package in packages)
            {
                Titles.Add(package.Title);
            }
            ViewBag.Titles = Titles;
            ViewBag.Times = times;
            ViewBag.Income= Income; 

            return View();
        }

        //Get: AllUsers
        public ActionResult AllUsers()
        {
            var users = db.Users.Include(u=>u.Bookings).ToList();
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
            else {
                return HttpNotFound();
            }
            
        }
    }
}