﻿namespace GUI
{
    partial class PageLaporan
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
            MakananMasukGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NamaMakanan = new DataGridViewTextBoxColumn();
            TanggalMasuk = new DataGridViewTextBoxColumn();
            TanggalKadaluwarsa = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)MakananMasukGrid).BeginInit();
            SuspendLayout();
            // 
            // MakananMasukGrid
            // 
            MakananMasukGrid.AllowUserToAddRows = false;
            MakananMasukGrid.AllowUserToDeleteRows = false;
            MakananMasukGrid.AllowUserToResizeColumns = false;
            MakananMasukGrid.AllowUserToResizeRows = false;
            MakananMasukGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            MakananMasukGrid.BackgroundColor = Color.White;
            MakananMasukGrid.BorderStyle = BorderStyle.None;
            MakananMasukGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 95, 239);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MakananMasukGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MakananMasukGrid.ColumnHeadersHeight = 60;
            MakananMasukGrid.Columns.AddRange(new DataGridViewColumn[] { ID, NamaMakanan, TanggalMasuk, TanggalKadaluwarsa, Jumlah });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MakananMasukGrid.DefaultCellStyle = dataGridViewCellStyle2;
            MakananMasukGrid.EnableHeadersVisualStyles = false;
            MakananMasukGrid.GridColor = Color.White;
            MakananMasukGrid.Location = new Point(41, 87);
            MakananMasukGrid.Margin = new Padding(3, 2, 3, 2);
            MakananMasukGrid.MultiSelect = false;
            MakananMasukGrid.Name = "MakananMasukGrid";
            MakananMasukGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            MakananMasukGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MakananMasukGrid.RowHeadersVisible = false;
            MakananMasukGrid.RowHeadersWidth = 60;
            MakananMasukGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MakananMasukGrid.Size = new Size(956, 453);
            MakananMasukGrid.TabIndex = 3;
            MakananMasukGrid.CellContentClick += MakananMasukGrid_CellContentClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(21, 29, 72);
            label2.Location = new Point(26, 19);
            label2.Name = "label2";
            label2.Padding = new Padding(4);
            label2.Size = new Size(244, 45);
            label2.TabIndex = 4;
            label2.Text = "Laporan Makanan";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(666, 41);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(316, 23);
            dateTimePicker1.TabIndex = 18;
            // 
            // PageLaporan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1009, 569);
            ControlBox = false;
            Controls.Add(dateTimePicker1);
            Controls.Add(label2);
            Controls.Add(MakananMasukGrid);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "PageLaporan";
            ShowIcon = false;
            Text = "xsddcasdsa d";
            ((System.ComponentModel.ISupportInitialize)MakananMasukGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView MakananMasukGrid;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalMasuk;
        private DataGridViewTextBoxColumn TanggalKadaluwarsa;
        private DataGridViewTextBoxColumn Jumlah;
        private Label label2;
        private DateTimePicker dateTimePicker1;
    }
}