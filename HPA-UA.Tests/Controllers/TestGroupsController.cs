using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using HPA_UA.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HPA_UA.Tests.Controllers
{
    /// <summary>
    /// Summary description for TestGroupsController
    /// </summary>
    [TestClass]
    public class TestGroupsController
    {
        [TestMethod]
        public void TestGet()
        {
            GroupsController controller = new GroupsController();
            IEnumerable<string> result = controller.Get();
            Assert.IsNotNull(result);
            Assert.AreEqual(8, result.Count());
        }
    }
}
