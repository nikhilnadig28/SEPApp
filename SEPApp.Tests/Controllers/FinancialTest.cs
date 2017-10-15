using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    class FinancialTest
    {
        SEPApp.Controllers.FeedbackController controller = new SEPApp.Controllers.FeedbackController();
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

            Assert.AreEqual(db.Financials.Find(1), result);
        }
        [TestMethod]
        public void Edit()
        {
            ViewResult result = controller.Edit(1) as ViewResult;

            Assert.AreEqual(db.Financials.Find(1), result);
        }
    }

}
