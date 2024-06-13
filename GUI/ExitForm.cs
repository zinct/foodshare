using FoodShareCore.API;
using GUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ExitForm : Form
    {
        public FoodGoodConditionResponse food;
        public PageDataMakananKeluar page;

        public ExitForm(PageDataMakananKeluar page)
        {
            InitializeComponent();
            this.page = page;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                // Validasi jika input lebih besar dari 0
                if (!int.TryParse(InputDistribution.Text, out int quantity) || quantity <= 0)
                {
                    MessageBox.Show("Masukkan jumlah distribusi yang valid.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InputDistribution.Text = string.Empty; 
                    return;
                }

                // Validasi jika jumlah distribusi melebihi stok yang tersedia
                if (quantity > food.Quantity)
                {
                    MessageBox.Show($"Jumlah distribusi tidak boleh lebih dari {food.Quantity}.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    InputDistribution.Text = string.Empty; 
                    return;
                }

                ClientAPI api = new ClientAPI();
                DistributeRequest body = new DistributeRequest {Amount = quantity};
                HttpResponseMessage response = await api.PostAsJson("/food/distributed/" + food.Id, body);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("/food/distributed/" + food.Id);
                    throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
                }

                String responseJSON = await response.Content.ReadAsStringAsync();
                List<FoodGoodConditionResponse> foods = JsonConvert.DeserializeObject<List<FoodGoodConditionResponse>>(responseJSON);

            } catch
            {
                throw;
            }
            page.DataLoad();
            MessageBox.Show("Distribusi berhasil!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InputDistribution_TextChanged(object sender, EventArgs e)
        {
            // Validasi jika input bukan angka
            if (!Regex.IsMatch(InputDistribution.Text, "^[0-9]*$"))
            {
                MessageBox.Show("Inputan berupa Angka!.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                InputDistribution.Text = string.Empty; //Clear input
            }
        }
    }
}
