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
    public class ServiceTaskLists1Controller : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ServiceTaskLists1
        public ActionResult Index()
        {
            return View(db.ServiceTaskLists.ToList());
        }

        // GET: ServiceTaskLists1/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceTaskList serviceTaskList = db.ServiceTaskLists.Find(id);
            if (serviceTaskList == null)
            {
                return HttpNotFound();
            }
            return View(serviceTaskList);
        }

        // GET: ServiceTaskLists1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServiceTaskLists1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TaskId,TaskName,EmployeeId,TaskDetails,TaskFeedback")] ServiceTaskList serviceTaskList)
        {
            if (ModelState.IsValid)
            {
                db.ServiceTaskLists.Add(serviceTaskList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(serviceTaskList);
        }

        // GET: ServiceTaskLists1/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceTaskList serviceTaskList = db.ServiceTaskLists.Find(id);
            if (serviceTaskList == null)
            {
                return HttpNotFound();
            }
            return View(serviceTaskList);
        }

        // POST: ServiceTaskLists1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TaskId,TaskName,EmployeeId,TaskDetails,TaskFeedback")] ServiceTaskList serviceTaskList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(serviceTaskList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(serviceTaskList);
        }

        // GET: ServiceTaskLists1/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ServiceTaskList serviceTaskList = db.ServiceTaskLists.Find(id);
            if (serviceTaskList == null)
            {
                return HttpNotFound();
            }
            return View(serviceTaskList);
        }

        // POST: ServiceTaskLists1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ServiceTaskList serviceTaskList = db.ServiceTaskLists.Find(id);
            db.ServiceTaskLists.Remove(serviceTaskList);
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
