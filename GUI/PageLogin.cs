using FoodShareCore.API;
using GUI.Models.Requests;
using System.Net;

namespace GUI
{
    public partial class PageLogin : Form
    {
        public PageLogin()
        {
            InitializeComponent();
            this.FormClosing += DashboardClosing;
        }

        private void DashboardClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            String username = (String)textBox1.Text;
            String password = (String)textBox2.Text;

            ClientAPI api = ClientAPI.Instance;
            LoginRequest body = new LoginRequest { Username = username, Password = password };
            HttpResponseMessage responseMassage = await api.PostAsJson("/auth/login", body);

            Console.WriteLine(responseMassage.ToString());  

            if (responseMassage.StatusCode == HttpStatusCode.InternalServerError)
            {

                MessageBox.Show("Username atau Password salah.");

            }
            else if (responseMassage.StatusCode == HttpStatusCode.OK)
            {
                new DashBoard().Show();
                Dispose();
            }
        }
    }
}
