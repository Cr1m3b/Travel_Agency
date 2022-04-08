using Entities.Models.ViewModels;
using Entities.IdentityUsers;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using MyDatabase;
using PersistenceLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Travel_Agency.Models;

namespace Travel_Agency.Controllers
{
    public class AdminDashboardController : Controller
    {
        private ApplicationDbContext db;
        private BookingRepository repository;
        private ApplicationSignInManager _signInManager;
        private ApplicationUserManager _userManager;
        public AdminDashboardController()
        {
            db = new ApplicationDbContext();
            repository = new BookingRepository(db);
        }
        public AdminDashboardController(ApplicationUserManager userManager, ApplicationSignInManager signInManager)
        {
            UserManager = userManager;
            SignInManager = signInManager;
        }
        public ApplicationSignInManager SignInManager
        {
            get
            {
                return _signInManager ?? HttpContext.GetOwinContext().Get<ApplicationSignInManager>();
            }
            private set
            {
                _signInManager = value;
            }
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
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

        //GET: AdminDashboard/AddUser
        public ActionResult AddUser()
        {
            return View();
        }

        //POST: AdminDashboard/AddUser
        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> AddUser(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var birthDay = Convert.ToDateTime(model.Birthday);
                var user = new ApplicationUser { UserName = model.UserName, FirstName = model.FirstName, LastName = model.LastName, Email = model.Email, Birthday = birthDay /*,ContactNumber=model.ContactNumber*/};
                var result = await UserManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await SignInManager.SignInAsync(user, isPersistent: false, rememberBrowser: false);

                    // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                    // Send an email with this link
                    // string code = await UserManager.GenerateEmailConfirmationTokenAsync(user.Id);
                    // var callbackUrl = Url.Action("ConfirmEmail", "Account", new { userId = user.Id, code = code }, protocol: Request.Url.Scheme);
                    // await UserManager.SendEmailAsync(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>");
                    db.Entry(user).State = EntityState.Added;
                    try
                    {
                        db.SaveChanges();
                    }
                    catch (DbEntityValidationException ex)
                    {
                        foreach (var entityValidationErrors in ex.EntityValidationErrors)
                        {
                            foreach (var validationError in entityValidationErrors.ValidationErrors)
                            {
                                Response.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                            }
                        }
                    }
                    return RedirectToAction("Adduser", "AdminDashboard");
                }
                AddErrors(result);
            }

            // If we got this far, something failed, redisplay form
            return View(model);
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
                ViewBag.NotFoundUsername = username;
                return View(user);
            }

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditUser([Bind(Include = "Id,UserName,Email,Password,ConfirmPassword,FirstName,LastName,Birthday,Country,City,Address,ZipCode")] ApplicationUser user)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                ViewBag.EditedUsername = user.UserName;
                return RedirectToAction("AllUsers", "AdminDashboard");
            }
            ViewBag.NotEditedUsername = user.UserName;
            return RedirectToAction("AllUsers", "AdminDashboard");
        }
        public ActionResult Delete(string username)
        {
            var user = db.Users.Where(u => u.UserName == username).First();
            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                return View(user);
            }
        }

        [HttpPost]
        public ActionResult DeleteUser(string username)
        {
            var user = db.Users.Where(u => u.UserName == username)
                               .Include(u => u.Comments)
                               .Include(u => u.ReplyComments)
                               .Include(u => u.Bookings)
                               .First();

            if (user == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            else
            {
                foreach (var comment in user.Comments)
                {
                    comment.ApplicationUser = null;
                }
                foreach (var reply in user.ReplyComments)
                {
                    reply.ApplicationUser = null;
                }
                foreach (var booking in user.Bookings)
                {
                    booking.ApplicationUser = null;
                }
                db.Entry(user).State = EntityState.Deleted;
                try
                {
                    db.SaveChanges();
                }
                catch (DbEntityValidationException ex)
                {
                    foreach (var entityValidationErrors in ex.EntityValidationErrors)
                    {
                        foreach (var validationError in entityValidationErrors.ValidationErrors)
                        {
                            Response.Write("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                        }
                    }
                }
            }
            return RedirectToAction("AllUsers", "AdminDashboard");
        }

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_userManager != null)
                {
                    _userManager.Dispose();
                    _userManager = null;
                }

                if (_signInManager != null)
                {
                    _signInManager.Dispose();
                    _signInManager = null;
                }
            }

            base.Dispose(disposing);
        }
    }
}