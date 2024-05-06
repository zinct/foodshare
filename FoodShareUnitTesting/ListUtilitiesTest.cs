using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using FoodShareAPI.Models;
using FoodShareCore.Utilities;
namespace FoodShareUnitTesting
{
    [TestClass]
    public class ListUtilitiesTest
    {
        [TestMethod]
        public void isListAddedTest()
        {
            List<Food> expected = new List<Food>();
            expected.Add(new Food(new DateOnly(2020, 12, 12), "Ayam Bakar", "Ayam yang dibakar", "Ayamnya sehat", "restoran pecel lele", "Baik", 10));

            List<Food> result = new List<Food>();
            result = ListUtilities.Create<Food>(result, new Food(new DateOnly(2020, 12, 12), "Ayam Bakar", "Ayam yang dibakar", "Ayamnya sehat", "restoran pecel lele", "Baik", 10));

            Assert.AreEqual(expected.Count(), result.Count());
        }

        [TestMethod]
        public void isListDeletedTest()
        {
            int expected = 0;

            List<Food> result = new List<Food>();
            result.Add(new Food(new DateOnly(2020, 12, 12), "Ayam Bakar", "Ayam yang dibakar", "Ayamnya sehat", "restoran pecel lele", "Baik", 10));
            result = ListUtilities.Delete<Food>(result, 0);

            Assert.AreEqual(expected, result.Count());
        }

        


    }
}
