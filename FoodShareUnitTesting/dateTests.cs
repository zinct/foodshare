using static FoodShareCore.Utilities.DateUtilitites;

namespace FoodShareUnitTesting
{
    [TestClass]
    public class dateTests
    {
        [TestMethod]
        public void testIntToDate()
        {
            int month = 1;
            string expected= "January";
            string actual = ConvertIntToMonthString(month);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void dateToStringTest()
        {
         
            DateOnly date = new DateOnly(2024, 01, 01);
            string expected = "Monday, 1 January 2024";
            string actual = ConvertDateOnlyToString(date);
            Assert.AreEqual(expected, actual);
        }
    }
}
