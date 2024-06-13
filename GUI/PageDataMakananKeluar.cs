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
    public partial class PageDataMakananKeluar : Form
    {
        List<FoodGoodConditionResponse> goodConditions = new List<FoodGoodConditionResponse>();
        int selectedIndex = 0;
        
        public PageDataMakananKeluar()
        {
            InitializeComponent();
        }

        public async void Dataload()
        {
            goodConditions.Clear();
            MakananKeluarGrid.ClearSelection();
            MakananKeluarGrid.Rows.Clear();

            ClientAPI api = new ClientAPI();
            HttpResponseMessage response = await api.Get("/food/good-condition");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
            }

            String responseJSON = await response.Content.ReadAsStringAsync();
            
            List<FoodGoodConditionResponse> foods = JsonConvert.DeserializeObject<List<FoodGoodConditionResponse>>(responseJSON);

            int i = 1;
            foreach (var food in foods)
            {
                MakananKeluarGrid.Rows.Add(i, food.Name, food.Expire, food.Conditions, food.Source, food.Category, food.Quantity);
                i++;
                goodConditions.Add(food);
            }
           
        }

        private async void PageDataMakananKeluar_Load(object sender, EventArgs e)
        {
            Dataload();
        }

        private void MakananKeluarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedIndex = e.RowIndex;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            ExitForm exitForm = new ExitForm(this);
            exitForm.food = goodConditions[selectedIndex];
            exitForm.ShowDialog();
        }
    }
}
