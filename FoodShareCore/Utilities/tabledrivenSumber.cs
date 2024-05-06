using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShareCore.Utilities
{
    public class tabledrivenSumber
    {
       public enum Sumber
        {
            Restoran = 1,
            Kafe = 2,
            Minimarket = 3,
            Toko = 4,
            Pasar = 5,
            Hotel = 6,
            Katering = 7,
            Kantin = 8,
            Tokoroti = 9
        }

        public static readonly Dictionary<string, Sumber> sumber = new Dictionary<string, Sumber>
        {
            {"Restoran", Sumber.Restoran},
            {"Kafe", Sumber.Kafe},
            {"Minimarket", Sumber.Minimarket},
            {"Toko Kelontong", Sumber.Toko},
            {"Pasar", Sumber.Pasar},
            {"Hotel", Sumber.Hotel},
            {"Katering", Sumber.Katering},
            {"Kantin", Sumber.Kantin},
            {"Toko roti / kue", Sumber.Tokoroti}
        };


        public static Sumber Getsumber(string namaTempat)
        {
            return sumber[namaTempat];
        }
    }


}
