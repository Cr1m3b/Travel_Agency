using Entities.Models.ViewModels;
using MyDatabase;
using PersistenceLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private ApplicationDbContext db;
        private PackageRepository repository;
        private CommentRepository commentRepository;
        public HomeController()
        {
            db = new ApplicationDbContext();
            repository = new PackageRepository(db);
            commentRepository =new CommentRepository(db);
        }
        
        public ActionResult Index()
        {
            var packageOffer = repository.GetAllWithRelatedTables().Where(p => p.Discount != 0).Take(3).ToList();
            var topDestinationsPackages = repository.GetAllWithRelatedTables().Where(p => p.AveragePackageRating()>=2).Take(6).ToList();
            var popularPackages = repository.GetAllWithRelatedTables().OrderByDescending(p => p.Bookings.Count).Take(3).ToList();
            var RecentComments = commentRepository.GetAllWithRelatedTables().OrderBy(c=>c.PostTime).Take(3).ToList();


            PackageViewModel vm = new PackageViewModel()
            {
                PackageOffer = packageOffer,
                PopularPackages = popularPackages,
                TopDestinationsPackages = topDestinationsPackages,
                TopComments = RecentComments
            };
            return View(vm);
        }
        public ActionResult Chat()
        {
            return View();
        }

        public ActionResult About()
        {


            return View();
        }
        
        public ActionResult Contact()
        {


            return View();
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