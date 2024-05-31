namespace GUI
{
    partial class DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            SidePanel = new Panel();
            DashboardButton = new Button();
            button3 = new Button();
            DataMakananLayakButton = new Button();
            DataMakananKeluarButton = new Button();
            DataMakananMasukButton = new Button();
            MainPanel = new Panel();
            bindingSource1 = new BindingSource(components);
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(17, 48, 101);
            SidePanel.Controls.Add(DashboardButton);
            SidePanel.Controls.Add(button3);
            SidePanel.Controls.Add(DataMakananLayakButton);
            SidePanel.Controls.Add(DataMakananKeluarButton);
            SidePanel.Controls.Add(DataMakananMasukButton);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(275, 763);
            SidePanel.TabIndex = 0;
            // 
            // DashboardButton
            // 
            DashboardButton.AutoEllipsis = true;
            DashboardButton.BackColor = Color.FromArgb(17, 48, 101);
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatAppearance.MouseDownBackColor = Color.White;
            DashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardButton.ForeColor = SystemColors.ButtonFace;
            DashboardButton.Location = new Point(13, 215);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Padding = new Padding(5, 0, 0, 0);
            DashboardButton.Size = new Size(244, 59);
            DashboardButton.TabIndex = 6;
            DashboardButton.Text = "Dashboard";
            DashboardButton.TextAlign = ContentAlignment.MiddleLeft;
            DashboardButton.UseVisualStyleBackColor = false;
            DashboardButton.Click += DashboardButton_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Aqua;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.White;
            button3.FlatAppearance.MouseOverBackColor = Color.White;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = SystemColors.ButtonFace;
            button3.Location = new Point(13, 12);
            button3.Name = "button3";
            button3.Size = new Size(244, 160);
            button3.TabIndex = 4;
            button3.Text = "LOGO";
            button3.UseVisualStyleBackColor = false;
            // 
            // DataMakananLayakButton
            // 
            DataMakananLayakButton.AutoEllipsis = true;
            DataMakananLayakButton.BackColor = Color.FromArgb(17, 48, 101);
            DataMakananLayakButton.FlatAppearance.BorderSize = 0;
            DataMakananLayakButton.FlatAppearance.MouseDownBackColor = Color.White;
            DataMakananLayakButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            DataMakananLayakButton.FlatStyle = FlatStyle.Flat;
            DataMakananLayakButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataMakananLayakButton.ForeColor = SystemColors.ButtonFace;
            DataMakananLayakButton.Location = new Point(13, 345);
            DataMakananLayakButton.Name = "DataMakananLayakButton";
            DataMakananLayakButton.Padding = new Padding(5, 0, 0, 0);
            DataMakananLayakButton.Size = new Size(244, 59);
            DataMakananLayakButton.TabIndex = 5;
            DataMakananLayakButton.Text = "Data Makanan Layak";
            DataMakananLayakButton.TextAlign = ContentAlignment.MiddleLeft;
            DataMakananLayakButton.UseVisualStyleBackColor = false;
            DataMakananLayakButton.Click += DataMakananLayakButton_Click;
            // 
            // DataMakananKeluarButton
            // 
            DataMakananKeluarButton.AutoEllipsis = true;
            DataMakananKeluarButton.BackColor = Color.FromArgb(17, 48, 101);
            DataMakananKeluarButton.FlatAppearance.BorderSize = 0;
            DataMakananKeluarButton.FlatAppearance.MouseDownBackColor = Color.White;
            DataMakananKeluarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            DataMakananKeluarButton.FlatStyle = FlatStyle.Flat;
            DataMakananKeluarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataMakananKeluarButton.ForeColor = SystemColors.ButtonFace;
            DataMakananKeluarButton.Location = new Point(13, 410);
            DataMakananKeluarButton.Name = "DataMakananKeluarButton";
            DataMakananKeluarButton.Padding = new Padding(5, 0, 0, 0);
            DataMakananKeluarButton.Size = new Size(244, 59);
            DataMakananKeluarButton.TabIndex = 3;
            DataMakananKeluarButton.Text = "Data Makanan Keluar";
            DataMakananKeluarButton.TextAlign = ContentAlignment.MiddleLeft;
            DataMakananKeluarButton.UseVisualStyleBackColor = false;
            DataMakananKeluarButton.Click += DataMakananKeluarButton_Click;
            // 
            // DataMakananMasukButton
            // 
            DataMakananMasukButton.AutoEllipsis = true;
            DataMakananMasukButton.BackColor = Color.FromArgb(17, 48, 101);
            DataMakananMasukButton.FlatAppearance.BorderSize = 0;
            DataMakananMasukButton.FlatAppearance.MouseDownBackColor = Color.White;
            DataMakananMasukButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            DataMakananMasukButton.FlatStyle = FlatStyle.Flat;
            DataMakananMasukButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataMakananMasukButton.ForeColor = SystemColors.ButtonFace;
            DataMakananMasukButton.Location = new Point(13, 280);
            DataMakananMasukButton.Name = "DataMakananMasukButton";
            DataMakananMasukButton.Padding = new Padding(5, 0, 0, 0);
            DataMakananMasukButton.Size = new Size(244, 59);
            DataMakananMasukButton.TabIndex = 1;
            DataMakananMasukButton.Text = "Data Makanan Masuk";
            DataMakananMasukButton.TextAlign = ContentAlignment.MiddleLeft;
            DataMakananMasukButton.UseVisualStyleBackColor = false;
            DataMakananMasukButton.Click += DataMakananMasukButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(275, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1147, 763);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 763);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            Name = "DashBoard";
            Text = "FoodShare";
            SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel;
        private Button DataMakananMasukButton;
        private Button button3;
        private Button DataMakananKeluarButton;
        private Panel MainPanel;
        private Button DataMakananLayakButton;
        private BindingSource bindingSource1;
        private Button DashboardButton;
    }
}
