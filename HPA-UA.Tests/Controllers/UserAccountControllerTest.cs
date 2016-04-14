using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HPA_UA.Controllers;
using HPA_UA.Models;

namespace HPA_UA.Tests.Controllers
{
    [TestClass]
    public class UserAccountControllerTest
    {
        [TestMethod]
        [Ignore]
        public void Get()
        {
            UserAccountController controller = new UserAccountController();
            IEnumerable<UserAccount> result = controller.Get();
            Assert.IsNotNull(result);
            Assert.IsTrue(result.Count() > 100);
        }
        [TestMethod]
        public void TestGetPage()
        {
            UserAccountController controller = new UserAccountController();
            IEnumerable<UserAccount> result = controller.Get("giveName", 10, 0);
            Assert.IsNotNull(result);
            Assert.AreEqual(10, result.Count());
        }
    }
}
