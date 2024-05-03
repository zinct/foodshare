namespace FoodShare
{
    public class AnggotaOrganisasi
    {
        public int id { get; set; }
        public EnumNamaDivisi divisi { get; set; }
        public StatusPerkerjaan status { get; set; }

        public AnggotaOrganisasi(int id, EnumNamaDivisi divisi, StatusPerkerjaan status)
        {
            this.id = id;
            this.divisi = divisi;
            this.status = status;
        }

        public enum EnumNamaDivisi
        {
            Logistik, 
            Humas,
            Distributor
        }

        public enum StatusPerkerjaan
        {
            ToDo,
            OnGoing,
            Finish
        }

        public string OutputDivisi()
        {
            if (divisi == AnggotaOrganisasi.EnumNamaDivisi.Logistik)
            {
                return "Logistik";
            }   else if (divisi == AnggotaOrganisasi.EnumNamaDivisi.Humas)
            {
                return "Humas";
            }   else if (divisi == AnggotaOrganisasi.EnumNamaDivisi.Distributor)
            {
                return "Distributor";
            }

            return "";
        }

        public string OutputStatus()
        {
            if (status == AnggotaOrganisasi.StatusPerkerjaan.ToDo)
            {
                return "To Do";
            } else if (status == AnggotaOrganisasi.StatusPerkerjaan.OnGoing)
            {
                return "On Going";
            } else if (status == AnggotaOrganisasi.StatusPerkerjaan.Finish)
            {
                return "Finish";
            }

            return " ";
        }
    }
}
