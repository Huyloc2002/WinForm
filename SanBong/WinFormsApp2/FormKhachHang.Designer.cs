namespace WinFormsApp2
{
    partial class FormKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            groupBox1 = new GroupBox();
            button_linkdatsan = new Button();
            button_taikhoan = new Button();
            button2 = new Button();
            btn_formmain = new Button();
            danh_sach_khachhang = new DataGridView();
            lb_thongtinKhachhang = new Label();
            txt_tenkhachhang = new TextBox();
            txt_email = new TextBox();
            txt_phone = new TextBox();
            txt_diachi = new TextBox();
            lb_hoten = new Label();
            lb_email = new Label();
            lb_diachi = new Label();
            lb_sodienthoai = new Label();
            btn_themkhachhang = new Button();
            btn_sua = new Button();
            btn_xoa = new Button();
            btn_cancel = new Button();
            pictureBox1 = new PictureBox();
            textbox_Tenkhachhang = new TextBox();
            label1 = new Label();
            btn_timkiem = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danh_sach_khachhang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(button_linkdatsan);
            groupBox1.Controls.Add(button_taikhoan);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btn_formmain);
            groupBox1.Location = new Point(2, 79);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(288, 919);
            groupBox1.TabIndex = 7;
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
            // 
            // danh_sach_khachhang
            // 
            danh_sach_khachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danh_sach_khachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danh_sach_khachhang.Location = new Point(296, 315);
            danh_sach_khachhang.Name = "danh_sach_khachhang";
            danh_sach_khachhang.ReadOnly = true;
            danh_sach_khachhang.RowHeadersWidth = 51;
            danh_sach_khachhang.RowTemplate.Height = 29;
            danh_sach_khachhang.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danh_sach_khachhang.Size = new Size(1050, 683);
            danh_sach_khachhang.TabIndex = 8;
            danh_sach_khachhang.CellContentClick += danh_sach_khachhang_CellContentClick;
            // 
            // lb_thongtinKhachhang
            // 
            lb_thongtinKhachhang.AutoSize = true;
            lb_thongtinKhachhang.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lb_thongtinKhachhang.Location = new Point(77, 27);
            lb_thongtinKhachhang.Name = "lb_thongtinKhachhang";
            lb_thongtinKhachhang.Size = new Size(694, 35);
            lb_thongtinKhachhang.TabIndex = 9;
            lb_thongtinKhachhang.Text = "MY FOOTBALL PITCH - THÔNG TIN KHÁCH HÀNG";
            // 
            // txt_tenkhachhang
            // 
            txt_tenkhachhang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tenkhachhang.Location = new Point(451, 105);
            txt_tenkhachhang.Name = "txt_tenkhachhang";
            txt_tenkhachhang.Size = new Size(193, 34);
            txt_tenkhachhang.TabIndex = 10;
            // 
            // txt_email
            // 
            txt_email.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_email.Location = new Point(451, 163);
            txt_email.Name = "txt_email";
            txt_email.Size = new Size(193, 34);
            txt_email.TabIndex = 10;
            // 
            // txt_phone
            // 
            txt_phone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_phone.Location = new Point(795, 104);
            txt_phone.Name = "txt_phone";
            txt_phone.Size = new Size(197, 34);
            txt_phone.TabIndex = 10;
            // 
            // txt_diachi
            // 
            txt_diachi.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_diachi.Location = new Point(795, 163);
            txt_diachi.Name = "txt_diachi";
            txt_diachi.Size = new Size(197, 34);
            txt_diachi.TabIndex = 10;
            // 
            // lb_hoten
            // 
            lb_hoten.AutoSize = true;
            lb_hoten.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_hoten.Location = new Point(307, 111);
            lb_hoten.Name = "lb_hoten";
            lb_hoten.Size = new Size(138, 25);
            lb_hoten.TabIndex = 11;
            lb_hoten.Text = "Tên Khách Hàng";
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_email.Location = new Point(321, 173);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(54, 25);
            lb_email.TabIndex = 11;
            lb_email.Text = "Email";
            // 
            // lb_diachi
            // 
            lb_diachi.AutoSize = true;
            lb_diachi.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_diachi.Location = new Point(687, 173);
            lb_diachi.Name = "lb_diachi";
            lb_diachi.Size = new Size(68, 25);
            lb_diachi.TabIndex = 11;
            lb_diachi.Text = "Địa Chỉ";
            // 
            // lb_sodienthoai
            // 
            lb_sodienthoai.AutoSize = true;
            lb_sodienthoai.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lb_sodienthoai.Location = new Point(673, 104);
            lb_sodienthoai.Name = "lb_sodienthoai";
            lb_sodienthoai.Size = new Size(122, 25);
            lb_sodienthoai.TabIndex = 11;
            lb_sodienthoai.Text = "Số Điện Thoại";
            // 
            // btn_themkhachhang
            // 
            btn_themkhachhang.BackColor = Color.Chartreuse;
            btn_themkhachhang.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_themkhachhang.Location = new Point(351, 267);
            btn_themkhachhang.Name = "btn_themkhachhang";
            btn_themkhachhang.Size = new Size(94, 43);
            btn_themkhachhang.TabIndex = 18;
            btn_themkhachhang.Text = "Thêm ";
            btn_themkhachhang.UseVisualStyleBackColor = false;
            btn_themkhachhang.Click += btn_themkhachhang_Click;
            // 
            // btn_sua
            // 
            btn_sua.BackColor = Color.DarkTurquoise;
            btn_sua.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_sua.Location = new Point(514, 267);
            btn_sua.Name = "btn_sua";
            btn_sua.Size = new Size(94, 43);
            btn_sua.TabIndex = 18;
            btn_sua.Text = "Sửa";
            btn_sua.UseVisualStyleBackColor = false;
            btn_sua.Click += btn_sua_Click;
            // 
            // btn_xoa
            // 
            btn_xoa.BackColor = Color.Red;
            btn_xoa.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_xoa.Location = new Point(687, 267);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 43);
            btn_xoa.TabIndex = 18;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.YellowGreen;
            btn_cancel.Image = (Image)resources.GetObject("btn_cancel.Image");
            btn_cancel.Location = new Point(1019, 104);
            btn_cancel.Margin = new Padding(3, 4, 3, 4);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(37, 40);
            btn_cancel.TabIndex = 19;
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1103, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(268, 232);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // textbox_Tenkhachhang
            // 
            textbox_Tenkhachhang.Location = new Point(1103, 278);
            textbox_Tenkhachhang.Name = "textbox_Tenkhachhang";
            textbox_Tenkhachhang.Size = new Size(169, 27);
            textbox_Tenkhachhang.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1055, 281);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 22;
            label1.Text = "Tên";
            // 
            // btn_timkiem
            // 
            btn_timkiem.FlatStyle = FlatStyle.Popup;
            btn_timkiem.Image = (Image)resources.GetObject("btn_timkiem.Image");
            btn_timkiem.Location = new Point(1295, 271);
            btn_timkiem.Margin = new Padding(3, 4, 3, 4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(42, 40);
            btn_timkiem.TabIndex = 23;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // FormKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1389, 1000);
            Controls.Add(btn_timkiem);
            Controls.Add(label1);
            Controls.Add(textbox_Tenkhachhang);
            Controls.Add(pictureBox1);
            Controls.Add(btn_cancel);
            Controls.Add(btn_xoa);
            Controls.Add(btn_sua);
            Controls.Add(btn_themkhachhang);
            Controls.Add(lb_sodienthoai);
            Controls.Add(lb_diachi);
            Controls.Add(lb_email);
            Controls.Add(lb_hoten);
            Controls.Add(txt_diachi);
            Controls.Add(txt_phone);
            Controls.Add(txt_email);
            Controls.Add(txt_tenkhachhang);
            Controls.Add(lb_thongtinKhachhang);
            Controls.Add(danh_sach_khachhang);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormKhachHang";
            Load += FormKhachHang_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)danh_sach_khachhang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_linkdatsan;
        private Button button_taikhoan;
        private Button button2;
        private Button btn_formmain;
        private DataGridView danh_sach_khachhang;
        private Label lb_thongtinKhachhang;
        private TextBox txt_tenkhachhang;
        private TextBox txt_email;
        private TextBox txt_phone;
        private TextBox txt_diachi;
        private Label lb_hoten;
        private Label lb_email;
        private Label lb_diachi;
        private Label lb_sodienthoai;
        private Button btn_themkhachhang;
        private Button btn_sua;
        private Button btn_xoa;
        private Button btn_cancel;
        private PictureBox pictureBox1;
        private TextBox textbox_Tenkhachhang;
        private Label label1;
        private Button btn_timkiem;
    }
}