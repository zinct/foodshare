﻿namespace GUI
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
            No = new DataGridViewTextBoxColumn();
            NamaMakanan = new DataGridViewTextBoxColumn();
            TanggalKadaluwarsa = new DataGridViewTextBoxColumn();
            Kondisi = new DataGridViewTextBoxColumn();
            Sumber = new DataGridViewTextBoxColumn();
            Kategori = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            label1 = new Label();
            DistributionButton = new Button();
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
            MakananKeluarGrid.Columns.AddRange(new DataGridViewColumn[] { No, NamaMakanan, TanggalKadaluwarsa, Kondisi, Sumber, Kategori, Jumlah });
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
            // No
            // 
            No.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            No.HeaderText = "No";
            No.MinimumWidth = 6;
            No.Name = "No";
            No.ReadOnly = true;
            No.Width = 68;
            // 
            // NamaMakanan
            // 
            NamaMakanan.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NamaMakanan.HeaderText = "Nama Makanan";
            NamaMakanan.MinimumWidth = 6;
            NamaMakanan.Name = "NamaMakanan";
            NamaMakanan.ReadOnly = true;
            // 
            // TanggalKadaluwarsa
            // 
            TanggalKadaluwarsa.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TanggalKadaluwarsa.HeaderText = "Tanggal Kadaluwarsa";
            TanggalKadaluwarsa.MinimumWidth = 6;
            TanggalKadaluwarsa.Name = "TanggalKadaluwarsa";
            TanggalKadaluwarsa.ReadOnly = true;
            // 
            // Kondisi
            // 
            Kondisi.HeaderText = "Kondisi";
            Kondisi.MinimumWidth = 6;
            Kondisi.Name = "Kondisi";
            Kondisi.ReadOnly = true;
            Kondisi.Width = 125;
            // 
            // Sumber
            // 
            Sumber.HeaderText = "Sumber";
            Sumber.MinimumWidth = 6;
            Sumber.Name = "Sumber";
            Sumber.ReadOnly = true;
            Sumber.Width = 125;
            // 
            // Kategori
            // 
            Kategori.HeaderText = "Kategori";
            Kategori.MinimumWidth = 6;
            Kategori.Name = "Kategori";
            Kategori.ReadOnly = true;
            Kategori.Width = 125;
            // 
            // Jumlah
            // 
            Jumlah.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Jumlah.HeaderText = "Jumlah";
            Jumlah.MinimumWidth = 6;
            Jumlah.Name = "Jumlah";
            Jumlah.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 49);
            label1.Name = "label1";
            label1.Size = new Size(382, 41);
            label1.TabIndex = 5;
            label1.Text = "DATA MAKANAN KELUAR";
            label1.Click += label1_Click;
            // 
            // DistributionButton
            // 
            DistributionButton.FlatStyle = FlatStyle.Flat;
            DistributionButton.ForeColor = Color.Transparent;
            DistributionButton.Image = (Image)resources.GetObject("DistributionButton.Image");
            DistributionButton.Location = new Point(784, 49);
            DistributionButton.Margin = new Padding(3, 2, 3, 2);
            DistributionButton.Name = "DistributionButton";
            DistributionButton.Size = new Size(202, 51);
            DistributionButton.TabIndex = 6;
            DistributionButton.UseVisualStyleBackColor = true;
            DistributionButton.Click += EditButton_Click;
            // 
            // PageDataMakananKeluar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1195, 594);
            Controls.Add(DistributionButton);
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
        private Button DistributionButton;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalKadaluwarsa;
        private DataGridViewTextBoxColumn Kondisi;
        private DataGridViewTextBoxColumn Sumber;
        private DataGridViewTextBoxColumn Kategori;
        private DataGridViewTextBoxColumn Jumlah;
    }
}