using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShareCore.Utilities;
using static FoodShareCore.Utilities.DateUtilitites;

namespace FoodShareUnitTesting;
{
[TestClass]
public class AritmatikaTest
{
    [TestMethod]
    public void TestMethod1()
    {
        int a = 1;
        int b = 1;
        int expected = 2;

        Assert.AreEqual(2, expected);
    }
}




