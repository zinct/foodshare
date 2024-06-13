using FoodShareCore.API;
using GUI.Interfaces;
using GUI.Models.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FoodShareCore.Utilities.tableDrivenKategori;

namespace GUI
{
    public partial class FormCreateUser : Form
    {
        public IFetchData Parent { get; set; }

        public FormCreateUser(IFetchData parent) 
        {
            InitializeComponent();
            Parent = parent;
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string username = textBox2.Text;
            string password = textBox3.Text;

            ClientAPI api = new ClientAPI();
            CreateUserRequest body = new CreateUserRequest {  Name = name, Username = username, Password = password };
            HttpResponseMessage response = await api.PostAsJson("/user", body);

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ToString());
            }

            MessageBox.Show("Berhasil menambahkan data");

            Parent.FetchData();
            this.Dispose();
        }
    }
}
