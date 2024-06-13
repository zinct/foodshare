namespace GUI
{
    partial class EditForm
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
            SubmitButton = new Button();
            label2 = new Label();
            kategoriTb = new TextBox();
            label7 = new Label();
            jumlahTb = new TextBox();
            Kategori = new Label();
            label6 = new Label();
            sumberTb = new TextBox();
            expiredTb = new TextBox();
            kondisiTb = new TextBox();
            label4 = new Label();
            label3 = new Label();
            namaMakananTb = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.Location = new Point(318, 325);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(151, 45);
            SubmitButton.TabIndex = 19;
            SubmitButton.Text = "Edit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(121, 166);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 34;
            label2.Text = "Sumber";
            // 
            // kategoriTb
            // 
            kategoriTb.Location = new Point(348, 210);
            kategoriTb.Name = "kategoriTb";
            kategoriTb.Size = new Size(360, 27);
            kategoriTb.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(121, 247);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 32;
            label7.Text = "Jumlah";
            // 
            // jumlahTb
            // 
            jumlahTb.Location = new Point(348, 248);
            jumlahTb.Name = "jumlahTb";
            jumlahTb.Size = new Size(360, 27);
            jumlahTb.TabIndex = 31;
            // 
            // Kategori
            // 
            Kategori.AutoSize = true;
            Kategori.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Kategori.Location = new Point(121, 206);
            Kategori.Name = "Kategori";
            Kategori.Size = new Size(93, 28);
            Kategori.TabIndex = 30;
            Kategori.Text = "Kategori";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(123, 171);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 29;
            // 
            // sumberTb
            // 
            sumberTb.Location = new Point(348, 166);
            sumberTb.Name = "sumberTb";
            sumberTb.Size = new Size(360, 27);
            sumberTb.TabIndex = 28;
            // 
            // expiredTb
            // 
            expiredTb.Location = new Point(348, 86);
            expiredTb.Name = "expiredTb";
            expiredTb.Size = new Size(360, 27);
            expiredTb.TabIndex = 27;
            // 
            // kondisiTb
            // 
            kondisiTb.Location = new Point(348, 126);
            kondisiTb.Name = "kondisiTb";
            kondisiTb.Size = new Size(360, 27);
            kondisiTb.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(123, 126);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 25;
            label4.Text = "Kondisi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(123, 86);
            label3.Name = "label3";
            label3.Size = new Size(212, 28);
            label3.TabIndex = 24;
            label3.Text = "Tanggal Kadaluwarsa";
            // 
            // namaMakananTb
            // 
            namaMakananTb.Location = new Point(348, 45);
            namaMakananTb.Name = "namaMakananTb";
            namaMakananTb.Size = new Size(360, 27);
            namaMakananTb.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(123, 45);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 22;
            label1.Text = "Nama Makanan";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(label2);
            Controls.Add(kategoriTb);
            Controls.Add(label7);
            Controls.Add(jumlahTb);
            Controls.Add(Kategori);
            Controls.Add(label6);
            Controls.Add(sumberTb);
            Controls.Add(expiredTb);
            Controls.Add(kondisiTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(namaMakananTb);
            Controls.Add(label1);
            Controls.Add(SubmitButton);
            Name = "EditForm";
            Text = "EditForm";
            Load += EditForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button SubmitButton;
        private Label label2;
        private TextBox kategoriTb;
        private Label label7;
        private TextBox jumlahTb;
        private Label Kategori;
        private Label label6;
        private TextBox sumberTb;
        private TextBox expiredTb;
        private TextBox kondisiTb;
        private Label label4;
        private Label label3;
        private TextBox namaMakananTb;
        private Label label1;
    }
}