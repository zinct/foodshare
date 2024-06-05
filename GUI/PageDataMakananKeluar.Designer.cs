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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            MakananKeluarGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NamaMakanan = new DataGridViewTextBoxColumn();
            TanggalMasuk = new DataGridViewTextBoxColumn();
            TanggalKadaluwarsa = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            DeleteButton = new Button();
            label1 = new Label();
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(170, 214, 236);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            MakananKeluarGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            MakananKeluarGrid.ColumnHeadersHeight = 60;
            MakananKeluarGrid.Columns.AddRange(new DataGridViewColumn[] { ID, NamaMakanan, TanggalMasuk, TanggalKadaluwarsa, Jumlah });
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            MakananKeluarGrid.DefaultCellStyle = dataGridViewCellStyle5;
            MakananKeluarGrid.EnableHeadersVisualStyles = false;
            MakananKeluarGrid.GridColor = Color.White;
            MakananKeluarGrid.Location = new Point(30, 112);
            MakananKeluarGrid.Margin = new Padding(3, 2, 3, 2);
            MakananKeluarGrid.MultiSelect = false;
            MakananKeluarGrid.Name = "MakananKeluarGrid";
            MakananKeluarGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            MakananKeluarGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
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
            DeleteButton.Image = Properties.Resources.Group_37295;
            DeleteButton.Location = new Point(928, 43);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(58, 55);
            DeleteButton.TabIndex = 4;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(308, 32);
            label1.TabIndex = 5;
            label1.Text = "DATA MAKANAN KELUAR";
            label1.Click += label1_Click;
            // 
            // PageDataMakananKeluar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 594);
            Controls.Add(label1);
            Controls.Add(DeleteButton);
            Controls.Add(MakananKeluarGrid);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "PageDataMakananKeluar";
            Text = "PageDataMakananKeluar";
            Load += PageDataMakananKeluar_Load;
            ((System.ComponentModel.ISupportInitialize)MakananKeluarGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MakananKeluarGrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalMasuk;
        private DataGridViewTextBoxColumn TanggalKadaluwarsa;
        private DataGridViewTextBoxColumn Jumlah;
        private Button DeleteButton;
        private Label label1;
    }
}