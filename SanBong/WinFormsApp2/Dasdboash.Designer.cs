namespace WinFormsApp2
{
    partial class Dasdboash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dasdboash));
            menuStrip1 = new MenuStrip();
            Menutrangchu = new ToolStripMenuItem();
            MenuDatsan = new ToolStripMenuItem();
            giasan = new ToolStripMenuItem();
            Menutaikhoan = new ToolStripMenuItem();
            menuKháchHàng = new ToolStripMenuItem();
            DoanhThu = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menutrangchu, MenuDatsan, Menutaikhoan, menuKháchHàng, DoanhThu });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(1371, 38);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menutrangchu
            // 
            Menutrangchu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Menutrangchu.Image = (Image)resources.GetObject("Menutrangchu.Image");
            Menutrangchu.Name = "Menutrangchu";
            Menutrangchu.Size = new Size(189, 32);
            Menutrangchu.Text = "MenuTrangChu";
            Menutrangchu.Click += Menutrangchu_Click;
            // 
            // MenuDatsan
            // 
            MenuDatsan.DropDownItems.AddRange(new ToolStripItem[] { giasan });
            MenuDatsan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            MenuDatsan.Image = (Image)resources.GetObject("MenuDatsan.Image");
            MenuDatsan.Name = "MenuDatsan";
            MenuDatsan.Size = new Size(168, 32);
            MenuDatsan.Text = "MenuDatSan";
            MenuDatsan.Click += MenuDatsan_Click;
            // 
            // giasan
            // 
            giasan.Name = "giasan";
            giasan.Size = new Size(169, 32);
            giasan.Text = "Giá Sân";
            giasan.Click += giasan_Click;
            // 
            // Menutaikhoan
            // 
            Menutaikhoan.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Menutaikhoan.Image = (Image)resources.GetObject("Menutaikhoan.Image");
            Menutaikhoan.Name = "Menutaikhoan";
            Menutaikhoan.Size = new Size(187, 32);
            Menutaikhoan.Text = "MenuTaiKhoan";
            Menutaikhoan.Click += Menutaikhoan_Click;
            // 
            // menuKháchHàng
            // 
            menuKháchHàng.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            menuKháchHàng.Name = "menuKháchHàng";
            menuKháchHàng.Size = new Size(200, 32);
            menuKháchHàng.Text = "Menu Khách Hàng";
            menuKháchHàng.Click += menuKháchHàng_Click;
            // 
            // DoanhThu
            // 
            DoanhThu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            DoanhThu.Name = "DoanhThu";
            DoanhThu.Size = new Size(130, 32);
            DoanhThu.Text = "Doanh Thu";
            DoanhThu.Click += DoanhThu_Click;
            // 
            // Dasdboash
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1371, 953);
            Controls.Add(menuStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Dasdboash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dasdboash";
            Load += Dasdboash_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menutrangchu;
        private ToolStripMenuItem MenuDatsan;
        private ToolStripMenuItem Menutaikhoan;
        private ToolStripMenuItem giasan;
        private ToolStripMenuItem menuKháchHàng;
        private ToolStripMenuItem DoanhThu;
    }
}