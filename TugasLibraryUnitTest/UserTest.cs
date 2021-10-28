using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TugasLibrary;
using NUnit.Framework;

namespace TugasLibraryUnitTest
{
    [TestFixture]
    public class UserTest
    {
        private User user;

        [SetUp]
        public void Init()
        {
            user = new User();
        }

        [Test]
        public void TestValidUser()
        {
            var userName = " admin";
            var password = " admin";

            Assert.IsFalse(user.IsValidUser(userName, password));
        }
    }
}
