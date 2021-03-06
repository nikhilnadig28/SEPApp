﻿using System;
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
    [Authorize(Roles ="HRManager")]
    public class HiringTrackersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: HiringTrackers
        public ActionResult Index()
        {
            return View(db.HiringTrackers.ToList());
        }

        // GET: HiringTrackers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HiringTracker hiringTracker = db.HiringTrackers.Find(id);
            if (hiringTracker == null)
            {
                return HttpNotFound();
            }
            return View(hiringTracker);
        }

        // GET: HiringTrackers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HiringTrackers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "HireId,SkillSet,Status")] HiringTracker hiringTracker)
        {
            if (ModelState.IsValid)
            {
                db.HiringTrackers.Add(hiringTracker);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hiringTracker);
        }

        // GET: HiringTrackers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HiringTracker hiringTracker = db.HiringTrackers.Find(id);
            if (hiringTracker == null)
            {
                return HttpNotFound();
            }
            return View(hiringTracker);
        }

        // POST: HiringTrackers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HireId,SkillSet,Status")] HiringTracker hiringTracker)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hiringTracker).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hiringTracker);
        }

        // GET: HiringTrackers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HiringTracker hiringTracker = db.HiringTrackers.Find(id);
            if (hiringTracker == null)
            {
                return HttpNotFound();
            }
            return View(hiringTracker);
        }

        // POST: HiringTrackers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HiringTracker hiringTracker = db.HiringTrackers.Find(id);
            db.HiringTrackers.Remove(hiringTracker);
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
