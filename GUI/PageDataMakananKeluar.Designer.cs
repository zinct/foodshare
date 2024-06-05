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
            ID = new DataGridViewTextBoxColumn();
            NamaMakanan = new DataGridViewTextBoxColumn();
            TanggalMasuk = new DataGridViewTextBoxColumn();
            TanggalKadaluwarsa = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            DeleteButton = new Button();
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
            dataGridViewCellStyle1.BackColor = Color.FromArgb(170, 214, 236);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MakananKeluarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MakananKeluarGrid.ColumnHeadersHeight = 60;
            MakananKeluarGrid.Columns.AddRange(new DataGridViewColumn[] { ID, NamaMakanan, TanggalMasuk, TanggalKadaluwarsa, Jumlah });
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
            MakananKeluarGrid.Location = new Point(12, 112);
            MakananKeluarGrid.Margin = new Padding(3, 2, 3, 2);
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
            MakananKeluarGrid.Size = new Size(956, 453);
            MakananKeluarGrid.TabIndex = 3;
            MakananKeluarGrid.CellContentClick += MakananKeluarGrid_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 51;
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
            // Jumlah
            // 
            Jumlah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jumlah.HeaderText = "Jumlah";
            Jumlah.MinimumWidth = 6;
            Jumlah.Name = "Jumlah";
            Jumlah.ReadOnly = true;
            // 
            // DeleteButton
            // 
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(916, 68);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(52, 40);
            DeleteButton.TabIndex = 4;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // PageDataMakananKeluar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 576);
            Controls.Add(DeleteButton);
            Controls.Add(MakananKeluarGrid);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PageDataMakananKeluar";
            Text = "PageDataMakananKeluar";
            Load += PageDataMakananKeluar_Load;
            ((System.ComponentModel.ISupportInitialize)MakananKeluarGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView MakananKeluarGrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalMasuk;
        private DataGridViewTextBoxColumn TanggalKadaluwarsa;
        private DataGridViewTextBoxColumn Jumlah;
        private Button DeleteButton;
    }
}