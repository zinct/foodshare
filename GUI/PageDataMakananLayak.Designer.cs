namespace GUI
{
    partial class PageDataMakananLayak
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
            label2 = new Label();
            MakananLayakGrid = new DataGridView();
            No = new DataGridViewTextBoxColumn();
            NamaMakanan = new DataGridViewTextBoxColumn();
            TanggalKadaluwarsa = new DataGridViewTextBoxColumn();
            Kondisi = new DataGridViewTextBoxColumn();
            Sumber = new DataGridViewTextBoxColumn();
            Kategori = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            ChangeStatusButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)MakananLayakGrid).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(28, 41);
            label2.Name = "label2";
            label2.Size = new Size(410, 46);
            label2.TabIndex = 1;
            label2.Text = "DATA MAKANAN LAYAK";
            label2.Click += label2_Click;
            // 
            // MakananLayakGrid
            // 
            MakananLayakGrid.AllowUserToAddRows = false;
            MakananLayakGrid.AllowUserToDeleteRows = false;
            MakananLayakGrid.AllowUserToResizeColumns = false;
            MakananLayakGrid.AllowUserToResizeRows = false;
            MakananLayakGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
            MakananLayakGrid.BackgroundColor = Color.White;
            MakananLayakGrid.BorderStyle = BorderStyle.None;
            MakananLayakGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 95, 239);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MakananLayakGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MakananLayakGrid.ColumnHeadersHeight = 60;
            MakananLayakGrid.Columns.AddRange(new DataGridViewColumn[] { No, NamaMakanan, TanggalKadaluwarsa, Kondisi, Sumber, Kategori, Jumlah });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            MakananLayakGrid.DefaultCellStyle = dataGridViewCellStyle2;
            MakananLayakGrid.EnableHeadersVisualStyles = false;
            MakananLayakGrid.GridColor = Color.White;
            MakananLayakGrid.Location = new Point(28, 122);
            MakananLayakGrid.MultiSelect = false;
            MakananLayakGrid.Name = "MakananLayakGrid";
            MakananLayakGrid.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            MakananLayakGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            MakananLayakGrid.RowHeadersVisible = false;
            MakananLayakGrid.RowHeadersWidth = 60;
            MakananLayakGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            MakananLayakGrid.Size = new Size(1065, 604);
            MakananLayakGrid.TabIndex = 4;
            MakananLayakGrid.CellContentClick += MakananLayakGrid_CellContentClick;
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
            // ChangeStatusButton
            // 
            ChangeStatusButton.BackColor = Color.Lime;
            ChangeStatusButton.FlatStyle = FlatStyle.Flat;
            ChangeStatusButton.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ChangeStatusButton.ForeColor = Color.White;
            ChangeStatusButton.Location = new Point(900, 34);
            ChangeStatusButton.Margin = new Padding(3, 2, 3, 2);
            ChangeStatusButton.Name = "ChangeStatusButton";
            ChangeStatusButton.Size = new Size(117, 69);
            ChangeStatusButton.TabIndex = 7;
            ChangeStatusButton.Text = "Layak ";
            ChangeStatusButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(1023, 34);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(117, 69);
            button1.TabIndex = 8;
            button1.Text = "Tidak Layak";
            button1.UseVisualStyleBackColor = false;
            // 
            // PageDataMakananLayak
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1174, 680);
            Controls.Add(button1);
            Controls.Add(ChangeStatusButton);
            Controls.Add(MakananLayakGrid);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PageDataMakananLayak";
            Text = "Form1";
            Load += PageDataMakananLayak_Load;
            ((System.ComponentModel.ISupportInitialize)MakananLayakGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private DataGridView MakananLayakGrid;
        private DataGridViewTextBoxColumn No;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalKadaluwarsa;
        private DataGridViewTextBoxColumn Kondisi;
        private DataGridViewTextBoxColumn Sumber;
        private DataGridViewTextBoxColumn Kategori;
        private DataGridViewTextBoxColumn Jumlah;
        private Button ChangeStatusButton;
        private Button button1;
    }
}