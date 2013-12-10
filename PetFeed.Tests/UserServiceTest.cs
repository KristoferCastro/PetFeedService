using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PetFeed.Models;
using System.Diagnostics;

namespace PetFeed.Tests
{
    [TestFixture]
    class UserServiceTest
    {
        [Test]
        public void CanGetUserByID()
        {
            UserService service = new UserService();
            Assert.IsNotNull(service);
            User loadedUser = service.GetUserById(0);
            Debug.WriteLine(String.Format("Actual: {0} , Expected {1}", loadedUser.Name, "Nancy"));
            Assert.AreEqual("Nancy", loadedUser.Name);
        }
    }
}
