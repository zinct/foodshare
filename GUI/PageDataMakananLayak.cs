using FoodShareAPI.Models;
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
    public partial class PageDataMakananLayak : Form
    {
        List<Food> foodList = new List<Food>();
        int selectedIndex = 0;
        public PageDataMakananLayak()
        {
            InitializeComponent();
        }

        private void MakananKeluarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PageDataMakananLayak_Load(object sender, EventArgs e)
        {
            MakananLayakGrid.Rows.Add("1", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananLayakGrid.Rows.Add("2", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananLayakGrid.Rows.Add("3", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananLayakGrid.Rows.Add("4", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananLayakGrid.Rows.Add("5", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
        }

        private void MakananLayakGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
            ChangeStatusform change = new ChangeStatusform();
            change.Show();
        }

        public async void LoadData()
        {
            foodList.Clear();
            MakananLayakGrid.ClearSelection();
            MakananLayakGrid.Rows.Clear();
            ClientAPI api = new ClientAPI();
            HttpResponseMessage response = await api.Get("/food");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Terjadi kesalahan dalam melakukan request ke API");

            }
            String responseJSON = await response.Content.ReadAsStringAsync();

            List<Food> foods = JsonConvert.DeserializeObject<List<Food>>(responseJSON);

            int i = 1;
            foreach (Food food in foods)
            {
                foodList.Add(food);
                MakananLayakGrid.Rows.Add(i, food.Name, food.CreatedAt, food.Expire, food.Conditions, food.Source, food.Status, food.Quantity);
                i++;
            }
        }

        public async void ChangeStatus()
        {

        }
    }
}
