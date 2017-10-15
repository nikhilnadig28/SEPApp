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
