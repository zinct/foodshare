namespace FoodShareUnitTesting;
using FoodShareCore.Utilities;
using static FoodShareCore.Utilities.tableDrivenKategori;
using static FoodShareCore.Utilities.tabledrivenSumber;


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

[TestClass]
public class kategoriTests
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


[TestClass]
public class SumberTest
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


