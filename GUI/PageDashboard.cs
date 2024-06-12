using FoodShareCore.API;
using Newtonsoft.Json;
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
    public partial class PageDashboard : Form
    {
        public PageDashboard()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private async Task label1_Click(object sender, EventArgs e)
        {
            ClientAPI api = new ClientAPI();
            HttpResponseMessage response = await api.Get("/food");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
            }

            String responseJSON = await response.Content.ReadAsStringAsync();
           // List<ReadFoodResponse> foods = JsonConvert.DeserializeObject<List<ReadFoodResponse>>(responseJSON);
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
