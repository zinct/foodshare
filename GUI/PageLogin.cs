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

        private void AddButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            new DashBoard().Show();
        }
    }
}
