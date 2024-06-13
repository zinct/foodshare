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
            try
            {
                String username = (String)textBox1.Text;
                String password = (String)textBox2.Text;

                ClientAPI api = new ClientAPI();
                LoginRequest body = new LoginRequest { Username = username, Password = password };
                HttpResponseMessage responseMassage = await api.PostAsJson("/auth/login", body);

                Console.WriteLine(responseMassage.ToString());  

                if (responseMassage.StatusCode == HttpStatusCode.InternalServerError)
                {

                    MessageBox.Show("Username atau Password salah.");
                    throw new Exception("Terjadi kesalahan ketika melakukan request ke API");

                }
                else if (responseMassage.StatusCode == HttpStatusCode.OK)
                {
                    new DashBoard().Show();
                    Dispose();
                }

            }
            catch (Exception ex)
            {
                throw;
            }
 
        }
    }
}
