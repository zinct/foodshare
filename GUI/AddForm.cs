using FoodShareCore.API;
using FoodShareCore.Utilities;
using GUI.Models;

namespace GUI
{
    public partial class AddForm : Form
    {
        private PageDataMakananMasuk page;
        public AddForm(PageDataMakananMasuk page)
        {
            InitializeComponent();
            this.page = page;
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            String expire = expiredTb.Text;
            String namaMakanan = namaMakananTb.Text;
            String conditions = kondisiTb.Text;
            String source = sumberTb.Text;
            String category = kategoriTb.Text;
            String quantity = jumlahTb.Text;

            try
            {
                if (!DateUtilitites.ValidateDateInput(expire))
                {
                    throw new FormatException("Format Tanggal Pada Expire Salah 'yyyy-MM-dd'");
                }

                FoodBody body = new FoodBody { Name = namaMakanan, Expire = expire, Conditions = conditions, Source = source, Category = category, Quantity = int.Parse(quantity) };
                ClientAPI api = ClientAPI.Instance;

                HttpResponseMessage response = await api.PostAsJson("/food", body);

                if (!response.IsSuccessStatusCode)
                {

                    Console.WriteLine(response.StatusCode);
                    Console.WriteLine(response.Headers);
                    MessageBox.Show("Penambahan Makanan Tidak Berhasil!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Penambahan Makanan Berhasil!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    page.LoadData();
                    this.Dispose();
                }
            } catch (FormatException ex)
            {
                MessageBox.Show("Format Input Salah:  " + ex.Message, "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }
    }
}
