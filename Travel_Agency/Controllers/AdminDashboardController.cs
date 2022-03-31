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
            return View();
        }

        //Get: AllUsers
        public ActionResult Users()
        {
            var users = db.Users.Include(u=>u.Bookings).ToList();
            return View(users);
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