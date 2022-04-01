using Entities.Models;
using MyDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Travel_Agency.Controllers
{
    public class WishListController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        // GET: WishList
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Add(int id)
        {

            if (Session["wishlist"] == null)
            {
                List<WishListItem> wishlist = new List<WishListItem>();
                wishlist.Add(new WishListItem { Package = db.Packages.Find(id), Quantity = 1 });
                Session["wishlist"] = wishlist;
            }
            else
            {
                List<WishListItem> wishlist = (List<WishListItem>)Session["wishlist"];
                int index = isExist(id);
                if (index != -1)
                {
                    wishlist[index].Quantity++;
                }
                else
                {
                    wishlist.Add(new WishListItem { Package = db.Packages.Find(id), Quantity = 1 });
                }
                Session["wishlist"] = wishlist;
            }

            return RedirectToAction("Index");
        }

        public ActionResult Remove(int id)
        {
            List<WishListItem> wishlist = (List<WishListItem>)Session["wishlist"];
            int index = isExist(id);
            wishlist.RemoveAt(index);
            Session["wishlist"] = wishlist;
            return RedirectToAction("Index");
        }
        private int isExist(int id)
        {
            List<WishListItem> wishlist = (List<WishListItem>)Session["wishlist"];
            for (int i = 0; i < wishlist.Count; i++)
                if (wishlist[i].Package.PackageId.Equals(id))
                    return i;
            return -1;
        }
    }
}