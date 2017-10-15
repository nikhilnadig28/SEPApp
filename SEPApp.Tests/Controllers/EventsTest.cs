using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEPApp.Controllers;
using SEPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SEPApp.Tests.Controllers
{
    [TestClass]
    public class EventsTest
    {
        EventsController controller = new EventsController();
        private ApplicationDbContext db = new ApplicationDbContext();


        [TestMethod]
        public void Index()
        {
            ActionResult result = controller.Index() as ActionResult;

            Assert.IsNotNull(result);
        }


        [TestMethod]
        public void Details()
        {
            ViewResult result = controller.Details(1) as ViewResult;

            Assert.AreEqual(db.Events.Find(1), result);
        }


        [TestMethod]
        public void Edit()
        {
            ViewResult result = controller.Edit(1) as ViewResult;

            Assert.AreEqual(db.Events.Find(1), result);
        }

        [TestMethod]
        public void Delete()
        {
            ViewResult result = controller.Delete(1) as ViewResult;

            Assert.AreEqual(db.Events.Find(1), result);
        }

    }
}
