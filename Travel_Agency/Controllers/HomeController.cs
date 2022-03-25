using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers
{
    
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult AdminIndex()
        {
            return View();
        }
        
        public ActionResult Index()
        {
            return View();
        }
        [Authorize]
        public ActionResult About()
        {
           

            return View();
        }
        [Authorize]
        public ActionResult Contact()
        {
            

            return View();
        }
    }
}