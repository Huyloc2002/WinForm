namespace WinFormsApp2
{
    partial class FromThongtin_Tk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FromThongtin_Tk));
            thongtintk = new DataGridView();
            lb_thongtintk = new Label();
            groupBox1 = new GroupBox();
            button_linkdatsan = new Button();
            button_taikhoan = new Button();
            button2 = new Button();
            btn_formmain = new Button();
            label1 = new Label();
            textbox_username = new TextBox();
            btn_search = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)thongtintk).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // thongtintk
            // 
            thongtintk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            thongtintk.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            thongtintk.BackgroundColor = SystemColors.Control;
            thongtintk.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            thongtintk.Location = new Point(299, 207);
            thongtintk.Name = "thongtintk";
            thongtintk.RowHeadersWidth = 51;
            thongtintk.RowTemplate.Height = 29;
            thongtintk.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            thongtintk.Size = new Size(1087, 790);
            thongtintk.TabIndex = 0;
            // 
            // lb_thongtintk
            // 
            lb_thongtintk.AutoSize = true;
            lb_thongtintk.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_thongtintk.Location = new Point(74, 23);
            lb_thongtintk.Name = "lb_thongtintk";
            lb_thongtintk.Size = new Size(665, 35);
            lb_thongtintk.TabIndex = 4;
            lb_thongtintk.Text = "MY FOOTBALL PITCH - THÔNG TIN TÀI KHOẢN";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(button_linkdatsan);
            groupBox1.Controls.Add(button_taikhoan);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btn_formmain);
            groupBox1.Location = new Point(2, 77);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(288, 920);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // button_linkdatsan
            // 
            button_linkdatsan.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_linkdatsan.ForeColor = SystemColors.ButtonHighlight;
            button_linkdatsan.Image = Properties.Resources.anen;
            button_linkdatsan.Location = new Point(82, 115);
            button_linkdatsan.Margin = new Padding(3, 4, 3, 4);
            button_linkdatsan.Name = "button_linkdatsan";
            button_linkdatsan.Size = new Size(192, 61);
            button_linkdatsan.TabIndex = 3;
            button_linkdatsan.Text = "Đặt Sân";
            button_linkdatsan.UseVisualStyleBackColor = true;
            // 
            // button_taikhoan
            // 
            button_taikhoan.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_taikhoan.ForeColor = SystemColors.ButtonHighlight;
            button_taikhoan.Image = Properties.Resources.anen;
            button_taikhoan.Location = new Point(82, 223);
            button_taikhoan.Margin = new Padding(3, 4, 3, 4);
            button_taikhoan.Name = "button_taikhoan";
            button_taikhoan.Size = new Size(192, 61);
            button_taikhoan.TabIndex = 2;
            button_taikhoan.Text = "Tài Khoàn";
            button_taikhoan.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Image = Properties.Resources.anen;
            button2.Location = new Point(82, 323);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(192, 61);
            button2.TabIndex = 1;
            button2.Text = "Hướng dẫn sử dụng";
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_formmain
            // 
            btn_formmain.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_formmain.ForeColor = SystemColors.ButtonHighlight;
            btn_formmain.Image = Properties.Resources.anen;
            btn_formmain.Location = new Point(82, 29);
            btn_formmain.Margin = new Padding(3, 4, 3, 4);
            btn_formmain.Name = "btn_formmain";
            btn_formmain.Size = new Size(192, 61);
            btn_formmain.TabIndex = 0;
            btn_formmain.Text = "Trang Chủ";
            btn_formmain.UseVisualStyleBackColor = true;
            btn_formmain.Click += btn_formmain_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(149, -43);
            label1.Name = "label1";
            label1.Size = new Size(785, 37);
            label1.TabIndex = 5;
            label1.Text = "MY FOOTBALL PITCH - SÂN BÓNG FELIX                          ";
            // 
            // textbox_username
            // 
            textbox_username.Location = new Point(427, 140);
            textbox_username.Name = "textbox_username";
            textbox_username.Size = new Size(169, 27);
            textbox_username.TabIndex = 7;
            // 
            // btn_search
            // 
            btn_search.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_search.Location = new Point(315, 139);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 8;
            btn_search.Text = "Tìm Kiếm";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1081, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(305, 167);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // FromThongtin_Tk
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1389, 1000);
            Controls.Add(pictureBox1);
            Controls.Add(btn_search);
            Controls.Add(textbox_username);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(lb_thongtintk);
            Controls.Add(thongtintk);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            Name = "FromThongtin_Tk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FromThongtin_Tk";
            Load += FromThongtin_Tk_Load;
            ((System.ComponentModel.ISupportInitialize)thongtintk).EndInit();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView thongtintk;
        private Label lb_thongtintk;
        private GroupBox groupBox1;
        private Button button_linkdatsan;
        private Button button_taikhoan;
        private Button button2;
        private Button btn_formmain;
        private Label label1;
        private TextBox textbox_username;
        private Button btn_search;
        private PictureBox pictureBox1;
    }
}