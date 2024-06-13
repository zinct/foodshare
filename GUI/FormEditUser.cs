using FoodShareCore.API;
using GUI.Interfaces;
using GUI.Models.Request;
using GUI.Models.Response;
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
    public partial class FormEditUser : Form
    {
        public GetUserResponse User { get; set; }
        public IFetchData Parent { get; set; }
        public FormEditUser(IFetchData parent, GetUserResponse user)
        {
            InitializeComponent();
            User = user;
            Parent = parent;

            textBox1.Text = User.Name;
            textBox2.Text = User.Username;
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;

            ClientAPI api = ClientAPI.Instance;
            CreateUserRequest body = new CreateUserRequest { Name = name, Username = username, Password = password };
            HttpResponseMessage response = await api.PutAsJson("/user/" + User.Id, body);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ToString());
            }

            MessageBox.Show("Data Berhasil DiUbah!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Parent.FetchData();
            this.Dispose();
        }
    }
}
