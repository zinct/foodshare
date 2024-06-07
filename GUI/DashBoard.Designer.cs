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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            SidePanel = new Panel();
            DashboardButton = new Button();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            DataMakananLayakButton = new Button();
            DataMakananKeluarButton = new Button();
            DataMakananMasukButton = new Button();
            MainPanel = new Panel();
            bindingSource1 = new BindingSource(components);
            imageList1 = new ImageList(components);
            button2 = new Button();
            SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // SidePanel
            // 
            SidePanel.BackColor = Color.FromArgb(93, 95, 239);
            SidePanel.Controls.Add(button2);
            SidePanel.Controls.Add(DashboardButton);
            SidePanel.Controls.Add(pictureBox1);
            SidePanel.Controls.Add(button1);
            SidePanel.Controls.Add(DataMakananLayakButton);
            SidePanel.Controls.Add(DataMakananKeluarButton);
            SidePanel.Controls.Add(DataMakananMasukButton);
            SidePanel.Dock = DockStyle.Left;
            SidePanel.Location = new Point(0, 0);
            SidePanel.Margin = new Padding(3, 2, 3, 2);
            SidePanel.Name = "SidePanel";
            SidePanel.Size = new Size(256, 650);
            SidePanel.TabIndex = 0;
            SidePanel.Paint += SidePanel_Paint;
            // 
            // DashboardButton
            // 
            DashboardButton.AutoEllipsis = true;
            DashboardButton.BackColor = Color.FromArgb(93, 95, 239);
            DashboardButton.BackgroundImageLayout = ImageLayout.Zoom;
            DashboardButton.FlatAppearance.BorderSize = 0;
            DashboardButton.FlatAppearance.MouseDownBackColor = Color.White;
            DashboardButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            DashboardButton.FlatStyle = FlatStyle.Flat;
            DashboardButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DashboardButton.ForeColor = SystemColors.ButtonFace;
            DashboardButton.Image = (Image)resources.GetObject("DashboardButton.Image");
            DashboardButton.ImageAlign = ContentAlignment.MiddleLeft;
            DashboardButton.Location = new Point(0, 162);
            DashboardButton.Margin = new Padding(3, 2, 3, 2);
            DashboardButton.Name = "DashboardButton";
            DashboardButton.Padding = new Padding(20, 0, 0, 0);
            DashboardButton.Size = new Size(256, 44);
            DashboardButton.TabIndex = 6;
            DashboardButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            DashboardButton.UseVisualStyleBackColor = false;
            DashboardButton.Click += DashboardButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(23, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(190, 78);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // button1
            // 
            button1.AutoEllipsis = true;
            button1.BackColor = Color.FromArgb(93, 95, 239);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ButtonFace;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(0, 356);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Padding = new Padding(20, 0, 0, 0);
            button1.Size = new Size(256, 44);
            button1.TabIndex = 7;
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // DataMakananLayakButton
            // 
            DataMakananLayakButton.AutoEllipsis = true;
            DataMakananLayakButton.BackColor = Color.FromArgb(93, 95, 239);
            DataMakananLayakButton.FlatAppearance.BorderSize = 0;
            DataMakananLayakButton.FlatAppearance.MouseDownBackColor = Color.White;
            DataMakananLayakButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            DataMakananLayakButton.FlatStyle = FlatStyle.Flat;
            DataMakananLayakButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataMakananLayakButton.ForeColor = SystemColors.ButtonFace;
            DataMakananLayakButton.Image = (Image)resources.GetObject("DataMakananLayakButton.Image");
            DataMakananLayakButton.ImageAlign = ContentAlignment.MiddleLeft;
            DataMakananLayakButton.Location = new Point(0, 259);
            DataMakananLayakButton.Margin = new Padding(3, 2, 3, 2);
            DataMakananLayakButton.Name = "DataMakananLayakButton";
            DataMakananLayakButton.Padding = new Padding(20, 0, 0, 0);
            DataMakananLayakButton.Size = new Size(256, 44);
            DataMakananLayakButton.TabIndex = 5;
            DataMakananLayakButton.TextAlign = ContentAlignment.MiddleLeft;
            DataMakananLayakButton.UseVisualStyleBackColor = false;
            DataMakananLayakButton.Click += DataMakananLayakButton_Click;
            // 
            // DataMakananKeluarButton
            // 
            DataMakananKeluarButton.AutoEllipsis = true;
            DataMakananKeluarButton.BackColor = Color.FromArgb(93, 95, 239);
            DataMakananKeluarButton.FlatAppearance.BorderSize = 0;
            DataMakananKeluarButton.FlatAppearance.MouseDownBackColor = Color.White;
            DataMakananKeluarButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            DataMakananKeluarButton.FlatStyle = FlatStyle.Flat;
            DataMakananKeluarButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataMakananKeluarButton.ForeColor = SystemColors.ButtonFace;
            DataMakananKeluarButton.Image = (Image)resources.GetObject("DataMakananKeluarButton.Image");
            DataMakananKeluarButton.ImageAlign = ContentAlignment.MiddleLeft;
            DataMakananKeluarButton.Location = new Point(0, 308);
            DataMakananKeluarButton.Margin = new Padding(3, 2, 3, 2);
            DataMakananKeluarButton.Name = "DataMakananKeluarButton";
            DataMakananKeluarButton.Padding = new Padding(20, 0, 0, 0);
            DataMakananKeluarButton.Size = new Size(256, 44);
            DataMakananKeluarButton.TabIndex = 3;
            DataMakananKeluarButton.TextAlign = ContentAlignment.MiddleLeft;
            DataMakananKeluarButton.UseVisualStyleBackColor = false;
            DataMakananKeluarButton.Click += DataMakananKeluarButton_Click;
            // 
            // DataMakananMasukButton
            // 
            DataMakananMasukButton.AutoEllipsis = true;
            DataMakananMasukButton.BackColor = Color.FromArgb(93, 95, 239);
            DataMakananMasukButton.FlatAppearance.BorderSize = 0;
            DataMakananMasukButton.FlatAppearance.MouseDownBackColor = Color.White;
            DataMakananMasukButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            DataMakananMasukButton.FlatStyle = FlatStyle.Flat;
            DataMakananMasukButton.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DataMakananMasukButton.ForeColor = SystemColors.ButtonFace;
            DataMakananMasukButton.Image = (Image)resources.GetObject("DataMakananMasukButton.Image");
            DataMakananMasukButton.ImageAlign = ContentAlignment.MiddleLeft;
            DataMakananMasukButton.Location = new Point(0, 210);
            DataMakananMasukButton.Margin = new Padding(3, 2, 3, 2);
            DataMakananMasukButton.Name = "DataMakananMasukButton";
            DataMakananMasukButton.Padding = new Padding(20, 0, 0, 0);
            DataMakananMasukButton.Size = new Size(256, 44);
            DataMakananMasukButton.TabIndex = 1;
            DataMakananMasukButton.TextAlign = ContentAlignment.MiddleLeft;
            DataMakananMasukButton.UseVisualStyleBackColor = false;
            DataMakananMasukButton.Click += DataMakananMasukButton_Click;
            // 
            // MainPanel
            // 
            MainPanel.Location = new Point(257, 0);
            MainPanel.Margin = new Padding(3, 2, 3, 2);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(988, 650);
            MainPanel.TabIndex = 1;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(200, 200);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // button2
            // 
            button2.AutoEllipsis = true;
            button2.BackColor = Color.FromArgb(93, 95, 239);
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.White;
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(64, 89, 131);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonFace;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(0, 404);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(20, 0, 0, 0);
            button2.Size = new Size(256, 44);
            button2.TabIndex = 9;
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1244, 650);
            Controls.Add(MainPanel);
            Controls.Add(SidePanel);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DashBoard";
            Text = "FoodShare";
            SidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel SidePanel;
        private Button DataMakananMasukButton;
        private Button DataMakananKeluarButton;
        private Panel MainPanel;
        private Button DataMakananLayakButton;
        private BindingSource bindingSource1;
        private Button DashboardButton;
        private Button button1;
        private PictureBox pictureBox1;
        private ImageList imageList1;
        private Button button2;
    }
}
