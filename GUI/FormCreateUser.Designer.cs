namespace GUI
{
    partial class FormCreateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCreateUser));
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox3 = new TextBox();
            AddButton = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(303, 133);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(316, 23);
            textBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(184, 133);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 2;
            label1.Text = "Nama";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(184, 189);
            label2.Name = "label2";
            label2.Size = new Size(87, 21);
            label2.TabIndex = 4;
            label2.Text = "Username";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(303, 191);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(316, 23);
            textBox2.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(184, 247);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 6;
            label3.Text = "Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(303, 249);
            textBox3.Margin = new Padding(3, 2, 3, 2);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(316, 23);
            textBox3.TabIndex = 7;
            // 
            // AddButton
            // 
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.ForeColor = Color.Transparent;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(332, 333);
            AddButton.Margin = new Padding(3, 2, 3, 2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(123, 51);
            AddButton.TabIndex = 8;
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Microsoft YaHei UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(21, 29, 72);
            label4.Location = new Point(263, 26);
            label4.Name = "label4";
            label4.Padding = new Padding(4);
            label4.Size = new Size(282, 44);
            label4.TabIndex = 9;
            label4.Text = "Tambah Pengguna";
            // 
            // FormCreateUser
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(AddButton);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "FormCreateUser";
            Text = "v";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Button AddButton;
        private Label label4;
    }
}