using Entities.IdentityUsers;
using Entities.Models;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers
{
    public class ImageController : Controller
    {
        private ApplicationDbContext db;

        public ImageController()
        {
            db = new ApplicationDbContext();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Add(Image newImage)
        {
            string fileName = Path.GetFileNameWithoutExtension(newImage.ImageFile.FileName);
            string extension = Path.GetExtension(newImage.ImageFile.FileName);
            fileName = fileName + extension;
            newImage.ImagePath = "~/Content/UsersImages/" + fileName;
            fileName = Path.Combine(Server.MapPath("~/Content/UsersImages/"), fileName);
            newImage.ImageFile.SaveAs(fileName);
            db.Images.Add(newImage);
            db.SaveChanges();
            return View();
        }

    }
}