using FoodShareCore.API;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class PageUser : Form
    {
        public PageUser()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new FormCreateUser();
            form.Show();
        }

        private void PageUser_Load(object sender, EventArgs e)
        {
            FetchUser();
        }

        private async Task FetchUser()
        {
            ClientAPI api = new ClientAPI();
            HttpResponseMessage response = await api.Get("/food");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
            }

            /**String responseJSON = await response.Content.ReadAsStringAsync();
            List<ReadFoodResponse> foods = JsonConvert.DeserializeObject<List<ReadFoodResponse>>(responseJSON);
            Datatable.Rows.Add("1", "Indra Mahesa", "indramahesa", "12-12-2004");
            Datatable.Rows.Add("2", "Indra Msahesa", "indramahesa", "12-12-2004");**/
        }
    }
}
