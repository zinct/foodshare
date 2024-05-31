namespace GUI
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
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
    }
}
