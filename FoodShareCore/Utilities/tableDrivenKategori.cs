using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FoodShareCore.Utilities
{
    internal class tableDrivenKategori
    {
         enum Kategori
        {
            Daging = 1,
            Ayam = 2,
            Ikan = 3,
            Sayuran = 4,
            Buah = 5,
            Perbijian = 6,
            Susu = 7,
            RotiKue = 8,
            Cemilan = 9,
            Instan = 10
        }

        private static readonly Dictionary<string, Kategori> kategori = new Dictionary<string, Kategori>
        {
            {"Daging", Kategori.Daging},
            {"Ayam",Kategori.Ayam},
            {"Ikan / Produk laut", Kategori.Ikan},
            {"Sayuran", Kategori.Sayuran},
            {"Buah", Kategori.Buah},
            {"BIji=bijian",Kategori.Perbijian},
            {"Susu", Kategori.Susu},
            {"Roti / Kue", Kategori.RotiKue},
            {"Cemilan", Kategori.Cemilan},
            {"Siap Saji",Kategori.Instan}
        };

        public static Kategori Getkategori(string namaMakanan)
        {
            return kategori[namaMakanan];
        }
    }
}
