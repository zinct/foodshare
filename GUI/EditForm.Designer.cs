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
            label1 = new Label();
            SubmitButton = new Button();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            JumlahTB = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            NamaMakananTB = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(189, 110);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // SubmitButton
            // 
            SubmitButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SubmitButton.Location = new Point(318, 305);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(151, 46);
            SubmitButton.TabIndex = 19;
            SubmitButton.Text = "Edit";
            SubmitButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(333, 179);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(360, 27);
            dateTimePicker2.TabIndex = 18;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(333, 141);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(360, 27);
            dateTimePicker1.TabIndex = 17;
            // 
            // JumlahTB
            // 
            JumlahTB.Location = new Point(333, 218);
            JumlahTB.Name = "JumlahTB";
            JumlahTB.Size = new Size(360, 27);
            JumlahTB.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(108, 214);
            label4.Name = "label4";
            label4.Size = new Size(80, 28);
            label4.TabIndex = 15;
            label4.Text = "Jumlah";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(108, 177);
            label3.Name = "label3";
            label3.Size = new Size(212, 28);
            label3.TabIndex = 14;
            label3.Text = "Tanggal Kadaluwarsa";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(108, 139);
            label2.Name = "label2";
            label2.Size = new Size(154, 28);
            label2.TabIndex = 13;
            label2.Text = "Tanggal Masuk";
            // 
            // NamaMakananTB
            // 
            NamaMakananTB.Location = new Point(333, 100);
            NamaMakananTB.Name = "NamaMakananTB";
            NamaMakananTB.Size = new Size(360, 27);
            NamaMakananTB.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(108, 100);
            label5.Name = "label5";
            label5.Size = new Size(161, 28);
            label5.TabIndex = 11;
            label5.Text = "Nama Makanan";
            // 
            // EditForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SubmitButton);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(JumlahTB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(NamaMakananTB);
            Controls.Add(label5);
            Controls.Add(label1);
            Name = "EditForm";
            Text = "EditForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button SubmitButton;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private TextBox JumlahTB;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox NamaMakananTB;
        private Label label5;
    }
}