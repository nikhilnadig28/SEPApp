using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SEPApp.Models;

namespace SEPApp.Controllers
{
    public class HRManagerViewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HRManagerView
        public ActionResult Index()
        {
            return View(db.Recruitments.ToList());
        }

        // GET: HRManagerView/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Recruitment recruitment = db.Recruitments.Find(id);
            if (recruitment == null)
            {
                return HttpNotFound();
            }
            return View(recruitment);
        }

        // GET: HRManagerView/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: HRManagerView/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "RequestId,RequestName,DepartmentId,SkillSet")] Recruitment recruitment)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Recruitments.Add(recruitment);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    return View(recruitment);
        //}

        //// GET: HRManagerView/Edit/5
        //public ActionResult Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Recruitment recruitment = db.Recruitments.Find(id);
        //    if (recruitment == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(recruitment);
        //}

        //// POST: HRManagerView/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "RequestId,RequestName,DepartmentId,SkillSet")] Recruitment recruitment)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(recruitment).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(recruitment);
        //}

        //// GET: HRManagerView/Delete/5
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    Recruitment recruitment = db.Recruitments.Find(id);
        //    if (recruitment == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(recruitment);
        //}

        //// POST: HRManagerView/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public ActionResult DeleteConfirmed(int id)
        //{
        //    Recruitment recruitment = db.Recruitments.Find(id);
        //    db.Recruitments.Remove(recruitment);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

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
