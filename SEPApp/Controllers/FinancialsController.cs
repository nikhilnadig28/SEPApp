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
    public class FinancialsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Financials
        public ActionResult Index()
        {
            return View(db.Financials.ToList());
        }

        // GET: Financials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Financial financial = db.Financials.Find(id);
            if (financial == null)
            {
                return HttpNotFound();
            }
            return View(financial);
        }

        // GET: Financials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Financials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RequestId,EventId,ExpectedBudgetIncrease,Justification")] Financial financial)
        {
            if (ModelState.IsValid)
            {
                db.Financials.Add(financial);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(financial);
        }

        // GET: Financials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Financial financial = db.Financials.Find(id);
            if (financial == null)
            {
                return HttpNotFound();
            }
            return View(financial);
        }

        // POST: Financials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RequestId,EventId,ExpectedBudgetIncrease,Justification")] Financial financial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(financial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(financial);
        }

        // GET: Financials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Financial financial = db.Financials.Find(id);
            if (financial == null)
            {
                return HttpNotFound();
            }
            return View(financial);
        }

        // POST: Financials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Financial financial = db.Financials.Find(id);
            db.Financials.Remove(financial);
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
