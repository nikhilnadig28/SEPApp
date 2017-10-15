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
    [Authorize(Roles = "ProductionManager, ServiceManager")]
    public class ManagerViewController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ManagerView
        public ActionResult Index()
        {
            return View(db.Events.Where(m => m.AdministrativeManagerApprove == true && m.SeniorCustomerApprove == true).ToList());
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
