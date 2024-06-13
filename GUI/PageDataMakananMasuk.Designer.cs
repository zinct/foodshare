namespace GUI
{
    partial class PageDataMakananMasuk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageDataMakananMasuk));
            label1 = new Label();
            label2 = new Label();
            MakananMasukGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NamaMakanan = new DataGridViewTextBoxColumn();
            TanggalMasuk = new DataGridViewTextBoxColumn();
            TanggalKadaluwarsa = new DataGridViewTextBoxColumn();
            Kondisi = new DataGridViewTextBoxColumn();
            Source = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            Jumlah = new DataGridViewTextBoxColumn();
            DeleteButton = new Button();
            EditButton = new Button();
            AddButton = new Button();
            ((System.ComponentModel.ISupportInitialize)MakananMasukGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(367, 355);
            label1.Name = "label1";
            label1.Size = new Size(0, 38);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(21, 29, 72);
            label2.Location = new Point(27, 20);
            label2.Name = "label2";
            label2.Padding = new Padding(5);
            label2.Size = new Size(404, 55);
            label2.TabIndex = 1;
            label2.Text = "Data Makanan Masuk";
            label2.Click += label2_Click;
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
            MakananMasukGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(93, 95, 239);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.Transparent;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            MakananMasukGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            MakananMasukGrid.ColumnHeadersHeight = 60;
            MakananMasukGrid.Columns.AddRange(new DataGridViewColumn[] { ID, NamaMakanan, TanggalMasuk, TanggalKadaluwarsa, Kondisi, Source, Status, Jumlah });
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
            MakananMasukGrid.Location = new Point(14, 144);
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
            MakananMasukGrid.Size = new Size(1093, 604);
            MakananMasukGrid.TabIndex = 2;
            MakananMasukGrid.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "No";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 67;
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
            // Kondisi
            // 
            Kondisi.HeaderText = "Kondisi";
            Kondisi.MinimumWidth = 6;
            Kondisi.Name = "Kondisi";
            Kondisi.ReadOnly = true;
            Kondisi.Width = 125;
            // 
            // Source
            // 
            Source.HeaderText = "Sumber";
            Source.MinimumWidth = 6;
            Source.Name = "Source";
            Source.ReadOnly = true;
            Source.Width = 125;
            // 
            // Status
            // 
            Status.HeaderText = "Kondisi";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Width = 125;
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
            DeleteButton.FlatStyle = FlatStyle.Flat;
            DeleteButton.ForeColor = Color.Transparent;
            DeleteButton.Image = (Image)resources.GetObject("DeleteButton.Image");
            DeleteButton.Location = new Point(959, 65);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(147, 68);
            DeleteButton.TabIndex = 3;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.FlatStyle = FlatStyle.Flat;
            EditButton.ForeColor = Color.Transparent;
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.Location = new Point(808, 65);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(144, 68);
            EditButton.TabIndex = 4;
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += button2_Click;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.ForeColor = Color.Transparent;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(661, 65);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(141, 68);
            AddButton.TabIndex = 5;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // PageDataMakananMasuk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 251, 252);
            ClientSize = new Size(1147, 763);
            Controls.Add(AddButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(MakananMasukGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PageDataMakananMasuk";
            Text = "PageDataMakananMasuk";
            Load += PageDataMakananMasuk_Load;
            ((System.ComponentModel.ISupportInitialize)MakananMasukGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView MakananMasukGrid;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalMasuk;
        private DataGridViewTextBoxColumn TanggalKadaluwarsa;
        private DataGridViewTextBoxColumn Kondisi;
        private DataGridViewTextBoxColumn Source;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Jumlah;
    }
}