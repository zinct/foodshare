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
    public partial class PageDashboard : Form
    {
        public PageDashboard()
        {
            InitializeComponent();
        }

        private void TableNotifikasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TableNotifikasi_Load(object sender, EventArgs e)
        {
            TableNotifikasi.Rows.Add("Makanan Masuk", "Nasi Goreng", "12-12-2003", "+1000");
            TableNotifikasi.Rows.Add("Makanan Tidak Layak", "Nasi Goreng", "12-12-2003", "-500");
            TableNotifikasi.Rows.Add("Makanan Layak", "Nasi Goreng", "12-12-2003", "+500");
            TableNotifikasi.Rows.Add("Makanan Dibagikan", "Nasi Goreng", "12-12-2003", "+500");
            TableNotifikasi.Rows.Add("Makanan Masuk", "Nasi Goreng", "12-12-2003", "+1000");
        }
    }
}
