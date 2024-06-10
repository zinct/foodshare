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
    public partial class PageDataMakananLayak : Form
    {
        public PageDataMakananLayak()
        {
            InitializeComponent();
        }

        private void MakananKeluarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void PageDataMakananLayak_Load(object sender, EventArgs e)
        {
            MakananLayakGrid.Rows.Add("1", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananLayakGrid.Rows.Add("2", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananLayakGrid.Rows.Add("3", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananLayakGrid.Rows.Add("4", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananLayakGrid.Rows.Add("5", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
        }
    }
}
