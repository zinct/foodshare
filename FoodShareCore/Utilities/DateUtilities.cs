namespace FoodShareCore.Utilities
{
    public class DateUtilitites
    {
        //public enum DayOfWeekInEnglish { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday };
        //public string[] DayOfWeekInIndonesian = { "Senin", "Selasa", "Rabu", "Kamis", "Jumat", "Sabtu", "Minggu" };
        internal static string ConvertIntToMonthString(int month)
        {
            String[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            return months[month - 1];
        }
        public static string ConvertDateOnlyToString(DateOnly date)
        {
            string dayOfWeek = date.DayOfWeek.ToString();
            string day = date.Day.ToString();
            string month = ConvertIntToMonthString(Int32.Parse(date.Month.ToString()));
            string year = date.Year.ToString();
            return dayOfWeek + ", " + day + " " + month + " " + year;
        }

        //input 2069-02-02
        public bool ValidateDateInput(String date)
        {
            if (date.Length > 10) return false;

            int[] totalDayInAMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(5, 2));
            int day = int.Parse(date.Substring(8, 2));

            bool isLeapYear = year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
            
            return year >= 0 && year <= 9999 && month >= 0 && month <= 12 && ((day >= 0 && day <= totalDayInAMonth[month-1]) || (isLeapYear && day >= 0 && day <= 29 ));  
        }
    }
}
