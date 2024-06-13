using FoodShareAPI.Models;
using FoodShareCore.API;
using FoodShareCore.Utilities;
using GUI.Models;

namespace GUI
{
    public partial class EditForm : Form
    {
        private Food food;
        private PageDataMakananMasuk page;
        public EditForm(PageDataMakananMasuk page, Food food)
        {
            InitializeComponent();
            this.page = page;
            this.food = food;
            LoadData(); 
        }

        private void LoadData()
        {
            namaMakananTb.Text = food.Name;
            expiredTb.Text = DateUtilitites.convertToyyyyMMddDateString(food.Expire.ToString());
            kondisiTb.Text = food.Conditions;
            sumberTb.Text = food.Source;
            kategoriTb.Text = food.Category;
            jumlahTb.Text = food.Quantity.ToString();
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
                HttpResponseMessage response = await api.PutAsJson("/food/" + food.Id, body);
                String msg = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(msg);

                if (!response.IsSuccessStatusCode)
                {
                    MessageBox.Show("Pengeditan Makanan Tidak Berhasil!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Pengeditasn Makanan Berhasil!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    page.LoadData();
                    this.Dispose();
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Format Input Salah:  " + ex.Message, "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {

        }
    }
}
