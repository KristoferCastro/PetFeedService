using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PetFeed.Models;

namespace PetFeed.Tests
{
    [TestFixture]
    class PetServiceTest
    {
        [Test]
        public void CanGetPetByID()
        {
            PetService service = new PetService();
            Assert.IsNotNull(service);
            Pet loadedPet = service.GetById(0);
            Assert.AreEqual("Patches", loadedPet.Name);
        }

        [Test]
        public void CanChangeTime()
        {
            PetService service = new PetService();
            service.UpdateLastMealDate(0);
            Pet loadedPet = service.GetById(0);
            Debug.WriteLine("=========================================================================");
            Debug.WriteLine("====================   Testing Can Change Time !         ================");
            Debug.WriteLine("=========================================================================");
            Debug.WriteLine(String.Format("DateTime.Now : {0} , DB Time Stamp: {1}", DateTime.Now, loadedPet.Last_Meal_Date));
            Debug.WriteLine("=========================================================================");
            Assert.AreEqual(DateTime.Now.Minute, loadedPet.Last_Meal_Date.Minute);
        }

        [Test]
        public void CanGetAllPetById()
        {
            PetService service = new PetService();
            UserService userService = new UserService();

            User myUser = userService.GetUserById(0);
            Assert.IsNotNull(myUser);

            IList<Pet> pets  = service.GetAllPet(myUser);

            Debug.WriteLine("=========================================================================");
            Debug.WriteLine("====================   Testing Get All Pet!         ================");
            Debug.WriteLine("=========================================================================");
            Debug.WriteLine(String.Format("Actual Size: {0}, Expected Size: {1}", pets.Count, 2));
            Debug.WriteLine("=========================================================================");

            Assert.AreEqual(2, pets.Count);
        }
    }
}
