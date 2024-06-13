using FoodShareCore.API;
using GUI.Interfaces;
using GUI.Models.Response;
using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace GUI
{
    public partial class PageUser : Form, IFetchData
    {
        public List<GetUserResponse> userList = new List<GetUserResponse>();
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
                throw new Exception(response.ToString());
            }

            String responseJSON = await response.Content.ReadAsStringAsync();
            List<GetUserResponse> users = JsonConvert.DeserializeObject<List<GetUserResponse>>(responseJSON);

            int i = 1;
            Datatable.Rows.Clear();
            userList.Clear();
            foreach (var user in users)
            {
                userList.Add(user);
                Datatable.Rows.Add(i, user.Name, user.Username, user.CreatedAt);
                i++;
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            var form = new FormEditUser(this, userList[Datatable.CurrentCell.RowIndex]);
            form.Show();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if(Datatable.CurrentCell.RowIndex == -1)
            {
                MessageBox.Show("Pilih Data terlebih dahulu!", "Terjadi Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            ClientAPI api = new ClientAPI();
            HttpResponseMessage response = await api.Delete("/user/" + userList[Datatable.CurrentCell.RowIndex].Id);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ToString());
            }

            MessageBox.Show("Data Berhasil dihapus", "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information);
            FetchData();
        }
    }
}
