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

        [TestMethod]
        public void isListUpdatedTest()
        {
            bool expected = true;

            List<Food> list1 = new List<Food>();
            list1.Add(new Food(new DateOnly(2020, 12, 12), "Ayam Bakar", "Ayam yang dibakar", "Ayamnya sehat", "restoran pecel lele", "Baik", 10));
            List<Food> list2 = new List<Food>();
            list2.Add(new Food(new DateOnly(2020, 12, 13), "Ayam Terbakar", "Ayam yang dibakar", "Ayamnya sehat", "restoran pecel lele", "Baik", 10));
            list2 = ListUtilities.Update<Food>(list2, new Food(new DateOnly(2020, 12, 12), "Ayam Bakar", "Ayam yang dibakar", "Ayamnya sehat", "restoran pecel lele", "Baik", 10), 0);
            bool result = list1[0].Expire == list2[0].Expire && list1[0].Name == list2[0].Name && list1[0].Description == list2[0].Description && 
                list1[0].Condition == list2[0].Condition && list1[0].Source == list2[0].Source && list1[0].Category == list2[0].Category && list1[0].Quantity == list2[0].Quantity;
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void isListReadedTest()
        {
            List<Food> expected = new List<Food>();
            expected.Add(new Food(new DateOnly(2020, 12, 12), "Ayam Bakar", "Ayam yang dibakar", "Ayamnya sehat", "restoran pecel lele", "Baik", 10));

            List<Food> result = ListUtilities.Read<Food>(expected);

            Assert.AreEqual(expected.Count(), result.Count());
        }

        [TestMethod]
        public void isListReadedbyIDTest()
        {
            bool expected = true;

            List<Food> list1 = new List<Food>();
            list1.Add(new Food(new DateOnly(2020, 12, 12), "Ayam Bakar", "Ayam yang dibakar", "Ayamnya sehat", "restoran pecel lele", "Baik", 10));
            List<Food> list2 = new List<Food>();
            list2.Add(ListUtilities.ReadByID<Food>(list1, 0));
            
            bool result = list1[0].Expire == list2[0].Expire && list1[0].Name == list2[0].Name && list1[0].Description == list2[0].Description && list1[0].Condition == list2[0].Condition && list1[0].Source == list2[0].Source && list1[0].Category == list2[0].Category && list1[0].Quantity == list2[0].Quantity;
            Assert.AreEqual(expected, result);
        }

    }
}
