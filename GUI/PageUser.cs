using FoodShareCore.API;
using GUI.Interfaces;
using GUI.Models.Response;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class PageUser : Form, IFetchData 
    {
        public PageUser()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var form = new FormCreateUser(this);
            form.Show();
        }

        private void PageUser_Load(object sender, EventArgs e)
        {
            FetchData();
        }

        public async void FetchData()
        {
            ClientAPI api = new ClientAPI();
            HttpResponseMessage response = await api.Get("/user");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
            }

            String responseJSON = await response.Content.ReadAsStringAsync();
            List<GetUserResponse> users = JsonConvert.DeserializeObject<List<GetUserResponse>>(responseJSON);

            int i = 1;
            Datatable.Rows.Clear();
            foreach (var user in users)
            {
                Datatable.Rows.Add(i, user.Name, user.Username, user.CreatedAt);
                i++;
            }
        }
    }
}
