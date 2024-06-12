using System;

namespace GUI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
            LoadForm(new PageDashboard());
            this.FormClosing += DashboardClosing;
        }

        private void DashboardClosing(Object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void LoadForm(Object Form)
        {
            if (this.MainPanel.Controls.Count > 0)
            {
                this.MainPanel.Controls.RemoveAt(0);
            }

            Form form = Form as Form;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            this.MainPanel.Controls.Add(form);
            this.MainPanel.Tag = form;
            form.Show();
        }

        private void DataMakananMasukButton_Click(object sender, EventArgs e)
        {
            LoadForm(new PageDataMakananMasuk());
        }

        private void DataMakananLayakButton_Click(object sender, EventArgs e)
        {
            LoadForm(new PageDataMakananLayak());
        }

        private void DataMakananKeluarButton_Click(object sender, EventArgs e)
        {
            LoadForm(new PageDataMakananKeluar());
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            LoadForm(new PageDashboard());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadForm(new PageLaporan());
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var form = new PageLogin();
            form.Show();
            this.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LoadForm(new PageUser());
        }
    }
}
