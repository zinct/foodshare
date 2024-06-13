namespace GUI
{
    partial class AddForm
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
            label1 = new Label();
            namaMakananTb = new TextBox();
            label3 = new Label();
            kondisiTb = new TextBox();
            label4 = new Label();
            submitButton = new Button();
            expiredTb = new TextBox();
            sumberTb = new TextBox();
            label6 = new Label();
            Kategori = new Label();
            jumlahTb = new TextBox();
            label7 = new Label();
            kategoriTb = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(106, 46);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 0;
            label1.Text = "Nama Makanan";
            // 
            // namaMakananTb
            // 
            namaMakananTb.Location = new Point(331, 46);
            namaMakananTb.Name = "namaMakananTb";
            namaMakananTb.Size = new Size(360, 27);
            namaMakananTb.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(106, 87);
            label3.Name = "label3";
            label3.Size = new Size(212, 28);
            label3.TabIndex = 4;
            label3.Text = "Tanggal Kadaluwarsa";
            // 
            // kondisiTb
            // 
            kondisiTb.Location = new Point(331, 127);
            kondisiTb.Name = "kondisiTb";
            kondisiTb.Size = new Size(360, 27);
            kondisiTb.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(106, 127);
            label4.Name = "label4";
            label4.Size = new Size(82, 28);
            label4.TabIndex = 6;
            label4.Text = "Kondisi";
            // 
            // submitButton
            // 
            submitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            submitButton.Location = new Point(306, 343);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(151, 46);
            submitButton.TabIndex = 10;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButton_Click;
            // 
            // expiredTb
            // 
            expiredTb.Location = new Point(331, 87);
            expiredTb.Name = "expiredTb";
            expiredTb.Size = new Size(360, 27);
            expiredTb.TabIndex = 12;
            // 
            // sumberTb
            // 
            sumberTb.Location = new Point(331, 167);
            sumberTb.Name = "sumberTb";
            sumberTb.Size = new Size(360, 27);
            sumberTb.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(106, 172);
            label6.Name = "label6";
            label6.Size = new Size(0, 28);
            label6.TabIndex = 15;
            // 
            // Kategori
            // 
            Kategori.AutoSize = true;
            Kategori.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Kategori.Location = new Point(106, 210);
            Kategori.Name = "Kategori";
            Kategori.Size = new Size(93, 28);
            Kategori.TabIndex = 16;
            Kategori.Text = "Kategori";
            Kategori.Click += label2_Click;
            // 
            // jumlahTb
            // 
            jumlahTb.Location = new Point(331, 249);
            jumlahTb.Name = "jumlahTb";
            jumlahTb.Size = new Size(360, 27);
            jumlahTb.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(108, 249);
            label7.Name = "label7";
            label7.Size = new Size(80, 28);
            label7.TabIndex = 19;
            label7.Text = "Jumlah";
            // 
            // kategoriTb
            // 
            kategoriTb.Location = new Point(331, 211);
            kategoriTb.Name = "kategoriTb";
            kategoriTb.Size = new Size(360, 27);
            kategoriTb.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 167);
            label2.Name = "label2";
            label2.Size = new Size(84, 28);
            label2.TabIndex = 21;
            label2.Text = "Sumber";
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(kategoriTb);
            Controls.Add(label7);
            Controls.Add(jumlahTb);
            Controls.Add(Kategori);
            Controls.Add(label6);
            Controls.Add(sumberTb);
            Controls.Add(expiredTb);
            Controls.Add(submitButton);
            Controls.Add(kondisiTb);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(namaMakananTb);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox namaMakananTb;
        private Label label3;
        private TextBox kondisiTb;
        private Label label4;
        private Button submitButton;
        private TextBox expiredTb;
      
        private TextBox sumberTb;
        private Label label6;
        private Label Kategori;
        private TextBox jumlahTb;
        private Label label7;
        private TextBox kategoriTb;
        private Label label2;
    }
}