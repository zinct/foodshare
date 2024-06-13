using FoodShareCore.API;
using GUI.Interfaces;
using GUI.Models.Response;
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
    public partial class PageLaporan : Form, IFetchData
    {
        public PageLaporan()
        {
            InitializeComponent();
        }

        private void MakananMasukGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public async void FetchData()
        {
            ClientAPI api = ClientAPI.Instance;
            HttpResponseMessage response = await api.Get("/transaction");

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception(response.ToString());
            }

            String responseJSON = await response.Content.ReadAsStringAsync();
            List<GetTransactionResponse> transactions = JsonConvert.DeserializeObject<List<GetTransactionResponse>>(responseJSON);

            int i = 1;
            DataTable.Rows.Clear();
            foreach (var transaction in transactions)
            {
                DataTable.Rows.Add(i, transaction.CreatedAt, transaction.Food.Name, transaction.User.Name, transaction.Amount);
                i++;
            }
        }

        private void PageLaporan_Load(object sender, EventArgs e)
        {
            FetchData();
        }
    }
}
