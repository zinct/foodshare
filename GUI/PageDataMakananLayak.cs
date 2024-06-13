using FoodShareAPI.Models;
using FoodShareCore.API;
using GUI.Interfaces;
using GUI.Models.Response;
using Newtonsoft.Json;
using System.Data;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Xml.Linq;
using GUI.Models.Requests;

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
            LoadData();
        }

        private void MakananLayakGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ChangeStatusButton_Click(object sender, EventArgs e)
        {
        }

        public async void LoadData()
        {
            foodList.Clear();
            Datatable.ClearSelection();
            Datatable.Rows.Clear();
            ClientAPI api = ClientAPI.Instance;
            HttpResponseMessage response = await api.Get("/food");
            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ToString());

            }
            String responseJSON = await response.Content.ReadAsStringAsync();

            List<Food> foods = JsonConvert.DeserializeObject<List<Food>>(responseJSON);

            int i = 1;
            foreach (Food food in foods)
            {
                foodList.Add(food);
                Datatable.Rows.Add(i, food.Name, food.Expire, food.Conditions, food.Source, food.Category, food.Status);
                i++;
            }
        }

        public async void ChangeStatus()
        {

        }

        private async void ChangeStatusButton_Click_1(object sender, EventArgs e)
        {
            if (Datatable.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Pilih Data terlebih dahulu!", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClientAPI api = ClientAPI.Instance;
            ChangeStatusRequest body = new ChangeStatusRequest { status = "good" };
            HttpResponseMessage response = await api.PostAsJson("/food/change-status/" + foodList[Datatable.CurrentCell.RowIndex].Id, body);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ToString());
            }

            MessageBox.Show("Status makanan berhasil diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (Datatable.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Pilih Data terlebih dahulu!", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClientAPI api = ClientAPI.Instance;
            ChangeStatusRequest body = new ChangeStatusRequest { status = "bad" };
            HttpResponseMessage response = await api.PostAsJson("/food/change-status/" + foodList[Datatable.CurrentCell.RowIndex].Id, body);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ToString());
            }

            MessageBox.Show("Status makanan berhasil diubah", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            LoadData();
        }
    }
}
