using Microsoft.VisualStudio.TestTools.UnitTesting;
using SEPApp.Controllers;
using SEPApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using SEPApp;

namespace SEPApp.Tests.Controllers
{
    [TestClass]
    public class AccountTest
    {

        [TestMethod]
        public void Login()
        {
            AccountController controller = new AccountController();
            LoginViewModel model = new LoginViewModel() { Email = "servicemanager", Password = "servicemanager" };
            Task<ActionResult> result = controller.Login(model, "/Home/") as Task<ActionResult>;

            Assert.IsNotNull(result);
        }
    }
}
