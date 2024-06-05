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
    public partial class PageDataMakananKeluar : Form
    {
        public PageDataMakananKeluar()
        {
            InitializeComponent();
        }

        private void PageDataMakananKeluar_Load(object sender, EventArgs e)
        {
            MakananKeluarGrid.Rows.Add("1", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananKeluarGrid.Rows.Add("2", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananKeluarGrid.Rows.Add("3", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananKeluarGrid.Rows.Add("4", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
            MakananKeluarGrid.Rows.Add("5", "Nasi Goreng", "12-12-2003", "12-12-2004", "1000");
        }

        private void MakananKeluarGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            ExitForm exitForm = new ExitForm();
            exitForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
