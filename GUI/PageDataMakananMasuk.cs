using FoodShareAPI.Models;
using FoodShareCore.API;
using Newtonsoft.Json;


namespace GUI
{
    public partial class PageDataMakananMasuk : Form
    {
        List<Food> foodList = new List<Food>();
        int selectedIndex = 0;
        public PageDataMakananMasuk()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            selectedIndex = e.RowIndex;
        }

        private async void PageDataMakananMasuk_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            EditForm editForm = new EditForm(this, foodList[selectedIndex]);
            editForm.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddForm addForm = new AddForm(this);
            addForm.Show();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            int selectedId = foodList[selectedIndex].Id;
            String url = "/food/" + selectedId;
            Console.WriteLine(foodList[selectedIndex].Name);

            ClientAPI api = ClientAPI.Instance;
            HttpResponseMessage response = await api.Delete(url);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Terjadi kesalahan dalam melakukan penghapusan data");

            } else
            {
                LoadData();
            }
        }

        public async void LoadData()
        {
            foodList.Clear();
            MakananMasukGrid.ClearSelection();
            MakananMasukGrid.Rows.Clear();
            ClientAPI api = ClientAPI.Instance;
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
                MakananMasukGrid.Rows.Add(i, food.Name, food.CreatedAt, food.Expire, food.Conditions, food.Source, food.Status, food.Quantity);
                i++;
            }
        }
    }
}
