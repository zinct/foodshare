using FoodShareCore.Utilities;
using static FoodShareCore.Utilities.tableDrivenKategori;

namespace FoodShareUnitTesting
{
    [TestClass]
    public class kategoritests
    {
        [TestMethod]
        public void TestDaging()
        {
            string namaMakanan = "Daging";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Daging, value);
        }

        [TestMethod]
        public void TestAyam()
        {
            string namaMakanan = "Ayam";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Ayam, value);
        }

        [TestMethod]
        public void TestIkan()
        {
            string namaMakanan = "Ikan / Produk laut";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Ikan, value);
        }

        [TestMethod]
        public void TestSayuran()
        {
            string namaMakanan = "Sayuran";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Sayuran, value);
        }

        [TestMethod]
        public void TestBuah()
        {
            string namaMakanan = "Buah";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Buah, value);
        }

        [TestMethod]
        public void TestPerbijian()
        {
            string namaMakanan = "Biji-bijian";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Perbijian, value);
        }

        [TestMethod]
        public void TestSusu()
        {
            string namaMakanan = "Susu";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Susu, value);
        }

        [TestMethod]
        public void TestRotiKue()
        {
            string namaMakanan = "Roti / Kue";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.RotiKue, value);
        }

        [TestMethod]
        public void TestCemilan()
        {
            string namaMakanan = "Cemilan";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Cemilan, value);
        }

        [TestMethod]
        public void TestInstan()
        {
            string namaMakanan = "Siap Saji";
            Kategori value = tableDrivenKategori.Getkategori(namaMakanan);
            Assert.AreEqual(Kategori.Instan, value);
        }
    }

}

