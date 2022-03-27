using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Entities.Models;
using Entities.Models.ViewModels;
using MyDatabase;

namespace Travel_Agency.Controllers
{
    public class CommentController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Comment
        public ActionResult Index()
        {
            var comments = db.Comments.Include(x => x.ApplicationUser).Include(x => x.Package).Include(x => x.ReplyComments).ToList();
            return View(comments);
        }

        // GET: Comment/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // GET: Comment/Create
        public ActionResult Create(int id)
        {
            var package=db.Packages.Find(id);
            ViewBag.Title=package.Title;
            return View();
        }

        // POST: Comment/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comment comment,int id)
        {
          comment.PackageId= id;
          comment.PostTime = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Added;
                db.SaveChanges();
                return RedirectToAction("Details", "Package", new { id = id });
            }
            return RedirectToAction("Create", "Comment", new { id = id });
        }

        // GET: Comment/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Comment comment = db.Comments.Find(id);


        //    if (comment == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(comment);
        //}

        public ActionResult Edit()
        {
            return View();
        }





        // POST: Comment/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "CommentId,CommentContent")] Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Package", "Index");
            }
            return View(comment);
        }

        // GET: Comment/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        // POST: Comment/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {

            var comment = db.Comments.Where(c => c.CommentId == id).Include(c => c.ReplyComments).FirstOrDefault();
            if (comment == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.NotFound);
            }

            for (int i = 0; i < comment.ReplyComments.Count; i++)
            {
                var com = comment.ReplyComments.ElementAt(i);

                db.Entry(com).State = EntityState.Deleted;
            }

            comment.ReplyComments.Clear();

            db.Comments.Remove(comment);
            db.SaveChanges();
            return RedirectToAction("Index");
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
