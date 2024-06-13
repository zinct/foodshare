using FoodShareAPI.Models;
using FoodShareCore.API;
using FoodShareCore.Utilities;
using GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            expiredTb.Text = DateUtilitites.ConvertDateToApprovedFormatString(food.Expire.ToString());
            kondisiTb.Text = food.Conditions;
            sumberTb.Text = food.Source;
            kategoriTb.Text = food.Category;
            jumlahTb.Text = food.Quantity.ToString();
        }

        private async void SubmitButton_Click(object sender, EventArgs e)
        {
            String expire = expiredTb.Text;
            String namaMakanan = namaMakananTb.Text;
            String condition = kondisiTb.Text;
            String source = sumberTb.Text;
            String category = kategoriTb.Text;
            String quantity = jumlahTb.Text;

            try
            {
                if (!DateUtilitites.ValidateDateInput(expire))
                {
                    throw new FormatException("Format Tanggal Pada Expire Salah 'yyyy-MM-dd'");
                }

                if (namaMakanan.Any(c => char.IsDigit(c)) || condition.Any(c => char.IsDigit(c)) || source.Any(c => char.IsDigit(c)) || category.Any(c => char.IsDigit(c)))
                {
                    throw new FormatException("Tidak Boleh Ada Angka Pada TextBox yang Sekirannya Inputnya String");
                }

                FoodBody body = new FoodBody { Name = namaMakanan, Expire = expire, Conditions = condition, Source = source, Category = category, Quantity = int.Parse(quantity) };
                ClientAPI api = new ClientAPI();
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
