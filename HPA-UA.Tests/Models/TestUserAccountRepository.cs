using System;

using System.Text;
using System.Collections.Generic;
using System.Linq;
using HPA_UA.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HPA_UA.Tests.Models
{
    /// <summary>
    /// Summary description for TestUserAccountRepository
    /// </summary>
    [TestClass]
    public class TestUserAccountRepository
    {
        [TestMethod]
        public void TestUserAccountRepositoryCreation()
        {
            IUserAccountRepository _userRepo = new UserAccountRepository();
            Assert.IsNotNull(_userRepo.GetPage("givenName", 0, 10));
            Assert.AreEqual(10, _userRepo.GetPage("givenName", 0, 10).Count());
        }
    }
}
