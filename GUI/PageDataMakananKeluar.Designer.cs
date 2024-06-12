namespace GUI
{
    partial class PageDataMakananKeluar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageDataMakananKeluar));
            MakananKeluarGrid = new DataGridView();
            label1 = new Label();
            EditButton = new Button();
            ID = new DataGridViewTextBoxColumn();
            NamaMakanan = new DataGridViewTextBoxColumn();
            TanggalMasuk = new DataGridViewTextBoxColumn();
            TanggalKadaluwarsa = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Sumber = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)MakananKeluarGrid).BeginInit();
            SuspendLayout();
            // 
            // MakananKeluarGrid
            // 
            MakananKeluarGrid.AllowUserToAddRows = false;
            MakananKeluarGrid.AllowUserToDeleteRows = false;
            MakananKeluarGrid.AllowUserToResizeColumns = false;
            MakananKeluarGrid.AllowUserToResizeRows = false;
            MakananKeluarGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            MakananKeluarGrid.BackgroundColor = Color.White;
            MakananKeluarGrid.BorderStyle = BorderStyle.None;
            MakananKeluarGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 95, 239);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MakananKeluarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MakananKeluarGrid.ColumnHeadersHeight = 60;
            MakananKeluarGrid.Columns.AddRange(new DataGridViewColumn[] { ID, NamaMakanan, TanggalMasuk, TanggalKadaluwarsa, Status, Sumber, Jumlah });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MakananKeluarGrid.DefaultCellStyle = dataGridViewCellStyle2;
            MakananKeluarGrid.EnableHeadersVisualStyles = false;
            MakananKeluarGrid.GridColor = Color.White;
            MakananKeluarGrid.Location = new Point(34, 149);
            MakananKeluarGrid.MultiSelect = false;
            MakananKeluarGrid.Name = "MakananKeluarGrid";
            MakananKeluarGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            MakananKeluarGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MakananKeluarGrid.RowHeadersVisible = false;
            MakananKeluarGrid.RowHeadersWidth = 60;
            MakananKeluarGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MakananKeluarGrid.Size = new Size(1093, 604);
            MakananKeluarGrid.TabIndex = 3;
            MakananKeluarGrid.CellContentClick += MakananKeluarGrid_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 65);
            label1.Name = "label1";
            label1.Size = new Size(382, 41);
            label1.TabIndex = 5;
            label1.Text = "DATA MAKANAN KELUAR";
            label1.Click += label1_Click;
            // 
            // EditButton
            // 
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.ForeColor = Color.Transparent;
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.Location = new Point(896, 65);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(231, 68);
            EditButton.TabIndex = 6;
            EditButton.UseVisualStyleBackColor = true;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 61;
            // 
            // NamaMakanan
            // 
            NamaMakanan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NamaMakanan.HeaderText = "Nama Makanan";
            NamaMakanan.MinimumWidth = 6;
            NamaMakanan.Name = "NamaMakanan";
            NamaMakanan.ReadOnly = true;
            // 
            // TanggalMasuk
            // 
            TanggalMasuk.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TanggalMasuk.HeaderText = "Tanggal Masuk";
            TanggalMasuk.MinimumWidth = 6;
            TanggalMasuk.Name = "TanggalMasuk";
            TanggalMasuk.ReadOnly = true;
            // 
            // TanggalKadaluwarsa
            // 
            TanggalKadaluwarsa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TanggalKadaluwarsa.HeaderText = "Tanggal Kadaluwarsa";
            TanggalKadaluwarsa.MinimumWidth = 6;
            TanggalKadaluwarsa.Name = "TanggalKadaluwarsa";
            TanggalKadaluwarsa.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
            // 
            // Sumber
            // 
            Sumber.HeaderText = "Sumber";
            Sumber.MinimumWidth = 6;
            Sumber.Name = "Sumber";
            Sumber.ReadOnly = true;
            Sumber.Width = 125;
            // 
            // Jumlah
            // 
            Jumlah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jumlah.HeaderText = "Jumlah";
            Jumlah.MinimumWidth = 6;
            Jumlah.Name = "Jumlah";
            Jumlah.ReadOnly = true;
            // 
            // PageDataMakananKeluar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1166, 792);
            Controls.Add(EditButton);
            Controls.Add(label1);
            Controls.Add(MakananKeluarGrid);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PageDataMakananKeluar";
            Text = "PageDataMakananKeluar";
            Load += PageDataMakananKeluar_Load;
            ((System.ComponentModel.ISupportInitialize)MakananKeluarGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MakananKeluarGrid;
        private Label label1;
        private Button EditButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalMasuk;
        private DataGridViewTextBoxColumn TanggalKadaluwarsa;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Sumber;
        private DataGridViewTextBoxColumn Jumlah;
    }
}