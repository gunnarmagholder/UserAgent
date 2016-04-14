using System;
using System.Linq;
using HPA_UA.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HPA_UA.Tests.Models
{
    [TestClass]
    public class TestGroupRepository
    {
        [TestMethod]
        public void TestMethod1()
        {
            IGroupRepository _repo = new GroupRepository();
            Assert.IsTrue(_repo.GetAll().Count() >  0);
        }
    }
}
