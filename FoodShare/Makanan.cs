namespace FoodShare
{
    public class Makanan
    {
        public int id { get; set; }
        public DateOnly tanggal { get; set; }
        public string makanan { get; set; }
        public DateOnly expire { get; set; }
        public int quantity { get; set; }

        public Makanan(int id, string makanan, int quantity, int thnExp, int blnExp, int tglExp)
        {
            this.id = id;
            today();
            setExpired(new DateOnly(thnExp,blnExp,tglExp));
            this.makanan = makanan;
            this.quantity = quantity;
        }

        private void today()
        {
            tanggal = DateOnly.FromDateTime(DateTime.Today);
        }

        public void setExpired(DateOnly expire)
        {
            this.expire = expire;
        }
    }
}
