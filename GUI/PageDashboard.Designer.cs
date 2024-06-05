namespace GUI
{
    partial class PageDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            panel2 = new Panel();
            TableNotifikasi = new DataGridView();
            TipeNotifikasi = new DataGridViewTextBoxColumn();
            NamaMakanan = new DataGridViewTextBoxColumn();
            TanggalMasuk = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TableNotifikasi).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlLight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 643);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Segoe UI Semibold", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(24, 361);
            button1.Name = "button1";
            button1.Size = new Size(265, 51);
            button1.TabIndex = 2;
            button1.Text = "Masukkan Makanan";
            button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 17.8217812F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(9, 258);
            label2.Name = "label2";
            label2.Size = new Size(310, 35);
            label2.TabIndex = 1;
            label2.Text = "Makanan Telah Dibagikan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36.3564339F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(66, 149);
            label1.Name = "label1";
            label1.Size = new Size(174, 68);
            label1.TabIndex = 0;
            label1.Text = "10000";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.9603958F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(16, 29);
            label3.Name = "label3";
            label3.Size = new Size(145, 38);
            label3.TabIndex = 2;
            label3.Text = "Notifikasi";
            // 
            // panel2
            // 
            panel2.Controls.Add(TableNotifikasi);
            panel2.Location = new Point(363, 113);
            panel2.Name = "panel2";
            panel2.Size = new Size(597, 529);
            panel2.TabIndex = 1;
            // 
            // TableNotifikasi
            // 
            TableNotifikasi.AllowUserToAddRows = false;
            TableNotifikasi.AllowUserToDeleteRows = false;
            TableNotifikasi.AllowUserToResizeColumns = false;
            TableNotifikasi.AllowUserToResizeRows = false;
            TableNotifikasi.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            TableNotifikasi.BackgroundColor = Color.White;
            TableNotifikasi.BorderStyle = BorderStyle.None;
            TableNotifikasi.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(170, 214, 236);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            TableNotifikasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            TableNotifikasi.ColumnHeadersHeight = 60;
            TableNotifikasi.Columns.AddRange(new DataGridViewColumn[] { TipeNotifikasi, NamaMakanan, TanggalMasuk, Jumlah });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            TableNotifikasi.DefaultCellStyle = dataGridViewCellStyle2;
            TableNotifikasi.EnableHeadersVisualStyles = false;
            TableNotifikasi.GridColor = Color.White;
            TableNotifikasi.Location = new Point(0, 3);
            TableNotifikasi.MultiSelect = false;
            TableNotifikasi.Name = "TableNotifikasi";
            TableNotifikasi.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            TableNotifikasi.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            TableNotifikasi.RowHeadersVisible = false;
            TableNotifikasi.RowHeadersWidth = 60;
            TableNotifikasi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TableNotifikasi.Size = new Size(594, 523);
            TableNotifikasi.TabIndex = 3;
            TableNotifikasi.CellContentClick += TableNotifikasi_CellContentClick;
            // 
            // TipeNotifikasi
            // 
            TipeNotifikasi.HeaderText = "Tipe";
            TipeNotifikasi.Name = "TipeNotifikasi";
            TipeNotifikasi.ReadOnly = true;
            TipeNotifikasi.Width = 105;
            // 
            // NamaMakanan
            // 
            NamaMakanan.HeaderText = "Nama Makanan";
            NamaMakanan.Name = "NamaMakanan";
            NamaMakanan.ReadOnly = true;
            NamaMakanan.Width = 105;
            // 
            // TanggalMasuk
            // 
            TanggalMasuk.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TanggalMasuk.HeaderText = "Tanggal Masuk";
            TanggalMasuk.MinimumWidth = 6;
            TanggalMasuk.Name = "TanggalMasuk";
            TanggalMasuk.ReadOnly = true;
            // 
            // Jumlah
            // 
            Jumlah.HeaderText = "Jumlah";
            Jumlah.Name = "Jumlah";
            Jumlah.ReadOnly = true;
            Jumlah.Width = 105;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(17, 48, 101);
            panel3.Controls.Add(label3);
            panel3.Font = new Font("Segoe UI Semibold", 9.267326F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.ForeColor = Color.White;
            panel3.Location = new Point(366, -1);
            panel3.Name = "panel3";
            panel3.Size = new Size(594, 98);
            panel3.TabIndex = 3;
            // 
            // PageDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(972, 654);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PageDashboard";
            Text = "PageDashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)TableNotifikasi).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Button button1;
        private Label label3;
        private Panel panel2;
        private Panel panel3;
        private DataGridView TableNotifikasi;
        private DataGridViewTextBoxColumn TipeNotifikasi;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalMasuk;
        private DataGridViewTextBoxColumn Jumlah;
    }
}