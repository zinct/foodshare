using FoodShareCore.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FoodShareCore.Utilities;
using static FoodShareCore.Utilities.tabledrivenSumber;

namespace FoodShareUnitTesting
{
    [TestClass]
    public class sumberTests
    {
        [TestMethod]
        public void TestRestoran()
        {
            string namaSumber = "Restoran";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Restoran, value);

        }

        [TestMethod]
        public void TestKafe()
        {
            string namaSumber = "Kafe";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Kafe, value);

        }


        [TestMethod]
        public void TestMinimarket()
        {
            string namaSumber = "Minimarket";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Minimarket, value);

        }


        [TestMethod]
        public void TestTokoKelontong()
        {
            string namaSumber = "Toko Kelontong";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Toko, value);

        }


        [TestMethod]
        public void TestPasar()
        {
            string namaSumber = "Pasar";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Pasar, value);

        }


        [TestMethod]
        public void TestHotel()
        {
            string namaSumber = "Hotel";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Hotel, value);

        }


        [TestMethod]
        public void TestKatering()
        {
            string namaSumber = "Katering";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Katering, value);

        }

        [TestMethod]
        public void TestKantin()
        {
            string namaSumber = "Kantin";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Kantin, value);

        }


        [TestMethod]
        public void TestTokoroti()
        {
            string namaSumber = "Toko roti / kue";
            Sumber value = tabledrivenSumber.Getsumber(namaSumber);
            Assert.AreEqual(Sumber.Tokoroti, value);

        }
    }
}
