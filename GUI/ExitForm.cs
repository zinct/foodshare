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
    public partial class ExitForm : Form
    {
        public FoodGoodConditionResponse food;
        public PageDataMakananKeluar page;

        public ExitForm(PageDataMakananKeluar page)
        {
            InitializeComponent();
            this.page = page;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                int quantity = int.Parse(InputDistribution.Text);

                ClientAPI api = new ClientAPI();
                DistributeRequest body = new DistributeRequest {Amount = quantity};
                HttpResponseMessage response = await api.PostAsJson("/food/distributed/" + food.Id, body);

                if (!response.IsSuccessStatusCode)
                {
                    Console.WriteLine("/food/distributed/" + food.Id);
                    throw new Exception("Terjadi kesalahan ketika melakukan request ke API");
                }

                String responseJSON = await response.Content.ReadAsStringAsync();
                List<FoodGoodConditionResponse> foods = JsonConvert.DeserializeObject<List<FoodGoodConditionResponse>>(responseJSON);

            } catch
            {
                throw;
            }
            page.Dataload();
            MessageBox.Show("Distribusi berhasil!", "INFORMASI", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void InputDistribution_TextChanged(object sender, EventArgs e)
        {


        }
    }
}
