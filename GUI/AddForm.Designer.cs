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
            NamaMakananTB = new TextBox();
            label2 = new Label();
            label3 = new Label();
            JumlahTB = new TextBox();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(89, 137);
            label1.Name = "label1";
            label1.Size = new Size(161, 28);
            label1.TabIndex = 0;
            label1.Text = "Nama Makanan";
            // 
            // NamaMakananTB
            // 
            NamaMakananTB.Location = new Point(314, 137);
            NamaMakananTB.Name = "NamaMakananTB";
            NamaMakananTB.Size = new Size(360, 27);
            NamaMakananTB.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(89, 176);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 2;
            label2.Text = "Tanggal Masuk";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(89, 214);
            label3.Name = "label3";
            label3.Size = new Size(212, 28);
            label3.TabIndex = 4;
            label3.Text = "Tanggal Kadaluwarsa";
            // 
            // JumlahTB
            // 
            JumlahTB.Location = new Point(314, 255);
            JumlahTB.Name = "JumlahTB";
            JumlahTB.Size = new Size(360, 27);
            JumlahTB.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(89, 251);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 6;
            label4.Text = "Jumlah";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(314, 178);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 27);
            dateTimePicker1.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(314, 216);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(360, 27);
            dateTimePicker2.TabIndex = 9;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(JumlahTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NamaMakananTB);
            Controls.Add(label1);
            Name = "AddForm";
            Text = "AddForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NamaMakananTB;
        private Label label2;
        private Label label3;
        private TextBox JumlahTB;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
    }
}