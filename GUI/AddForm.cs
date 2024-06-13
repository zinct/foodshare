using FoodShareAPI.Models;
using FoodShareCore.API;
using FoodShareCore.Utilities;
using GUI.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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

                FoodBody body = new FoodBody { 
                    Name = namaMakanan, 
                    Expire = expire, 
                    Conditions = condition, 
                    Source = source, 
                    Category = category, 
                    Quantity = int.Parse(quantity) 
                
                };
                ClientAPI api = new ClientAPI();

                HttpResponseMessage response = await api.PostAsJson("/food", body);

                if (!response.IsSuccessStatusCode)
                {
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
