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
            label1.Location = new Point(321, 266);
            label1.Name = "label1";
            label1.Size = new Size(0, 30);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(17, 48, 101);
            label2.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(24, 15);
            label2.Name = "label2";
            label2.Padding = new Padding(4, 4, 4, 4);
            label2.Size = new Size(290, 45);
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
            MakananMasukGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(170, 214, 236);
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
            MakananMasukGrid.Location = new Point(24, 100);
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
            MakananMasukGrid.TabIndex = 2;
            MakananMasukGrid.CellContentClick += dataGridView1_CellContentClick;
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
            DeleteButton.Location = new Point(928, 56);
            DeleteButton.Margin = new Padding(3, 2, 3, 2);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(52, 40);
            DeleteButton.TabIndex = 3;
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // EditButton
            // 
            EditButton.Image = (Image)resources.GetObject("EditButton.Image");
            EditButton.Location = new Point(872, 56);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(52, 40);
            EditButton.TabIndex = 4;
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += button2_Click;
            // 
            // AddButton
            // 
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(815, 56);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(52, 40);
            AddButton.TabIndex = 5;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // PageDataMakananMasuk
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1004, 572);
            Controls.Add(AddButton);
            Controls.Add(EditButton);
            Controls.Add(DeleteButton);
            Controls.Add(MakananMasukGrid);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
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
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NamaMakanan;
        private DataGridViewTextBoxColumn TanggalMasuk;
        private DataGridViewTextBoxColumn TanggalKadaluwarsa;
        private DataGridViewTextBoxColumn Jumlah;
        private Button DeleteButton;
        private Button EditButton;
        private Button AddButton;
    }
}