﻿namespace GUI
{
    partial class ExitForm
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
            label2 = new Label();
            textBox1 = new TextBox();
            Submit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(181, 80);
            label1.Name = "label1";
            label1.Size = new Size(213, 32);
            label1.TabIndex = 0;
            label1.Text = "Jumlah Quantitas";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(301, 179);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(107, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(366, 23);
            textBox1.TabIndex = 2;
            // 
            // Submit
            // 
            Submit.Location = new Point(246, 214);
            Submit.Name = "Submit";
            Submit.Size = new Size(93, 35);
            Submit.TabIndex = 3;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            // 
            // ExitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 354);
            Controls.Add(Submit);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ExitForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private Button Submit;
    }
}