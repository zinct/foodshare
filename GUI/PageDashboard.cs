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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PageDashboard : Form
    {
        public PageDashboard()
        {
            InitializeComponent();
            LoadNumber();

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

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private async void LoadNumber()
        {
            ClientAPI api = new ClientAPI();
            HttpResponseMessage response = await api.Get("/dashboard");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
            }

            String responseJSON = await response.Content.ReadAsStringAsync();
            DashboardResponse foods = JsonConvert.DeserializeObject<DashboardResponse>(responseJSON);

            label1.Text = foods.TotalFoods.ToString();
            label2.Text = foods.TotalFoodGoodConditions.ToString();
            label3.Text = foods.TotalFoodNotGoods.ToString();
            label4.Text = foods.TotalFoodDistributeds.ToString();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
