using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    public class DateUtilitites
    {
        //public enum DayOfWeekInEnglish { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        //public string[] DayOfWeekInIndonesian = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };
        public static string ConvertIntToMonthString(int month)
        {
            String[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"};
            return months[month-1];
        }
        public static string ConvertDateOnlyToString(DateOnly date)
        {
            string dayOfWeek = date.DayOfWeek.ToString();
            string day = date.Day.ToString();
            string month = ConvertIntToMonthString(Int32.Parse(date.Month.ToString()));
            string year = date.Year.ToString();
            return dayOfWeek + ", " + day + " " + month + " " + year;  
        }
    }
}
