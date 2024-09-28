namespace WinFormsApp2
{
    partial class FormDoanhthu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDoanhthu));
            groupBox1 = new GroupBox();
            button_linkdatsan = new Button();
            button_taikhoan = new Button();
            button2 = new Button();
            button1 = new Button();
            label1 = new Label();
            danhsach_doanhthhu = new DataGridView();
            ngay_dat_san = new DateTimePicker();
            lb_Ngay_dat = new Label();
            lb_ten_khachhang = new Label();
            btn_timkiem = new Button();
            textBox_tẹnkhachhang = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)danhsach_doanhthhu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(button_linkdatsan);
            groupBox1.Controls.Add(button_taikhoan);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(2, 89);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(281, 911);
            groupBox1.TabIndex = 2;
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
            // button1
            // 
            button1.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Image = Properties.Resources.anen;
            button1.Location = new Point(82, 29);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(192, 61);
            button1.TabIndex = 0;
            button1.Text = "Trang Chủ";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(71, 31);
            label1.Name = "label1";
            label1.Size = new Size(633, 37);
            label1.TabIndex = 3;
            label1.Text = "MY FOOTBALL PITCH - TỔNG DOANH THU";
            // 
            // danhsach_doanhthhu
            // 
            danhsach_doanhthhu.AllowUserToAddRows = false;
            danhsach_doanhthhu.AllowUserToDeleteRows = false;
            danhsach_doanhthhu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhsach_doanhthhu.BackgroundColor = SystemColors.ButtonHighlight;
            danhsach_doanhthhu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhsach_doanhthhu.Location = new Point(283, 308);
            danhsach_doanhthhu.Margin = new Padding(3, 4, 3, 4);
            danhsach_doanhthhu.Name = "danhsach_doanhthhu";
            danhsach_doanhthhu.RowHeadersWidth = 51;
            danhsach_doanhthhu.RowTemplate.Height = 25;
            danhsach_doanhthhu.Size = new Size(1083, 692);
            danhsach_doanhthhu.TabIndex = 4;
            // 
            // ngay_dat_san
            // 
            ngay_dat_san.CustomFormat = "dd/MM/yyyy";
            ngay_dat_san.Format = DateTimePickerFormat.Custom;
            ngay_dat_san.Location = new Point(429, 173);
            ngay_dat_san.Name = "ngay_dat_san";
            ngay_dat_san.Size = new Size(194, 27);
            ngay_dat_san.TabIndex = 5;
            // 
            // lb_Ngay_dat
            // 
            lb_Ngay_dat.AutoSize = true;
            lb_Ngay_dat.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            lb_Ngay_dat.ForeColor = SystemColors.ActiveCaptionText;
            lb_Ngay_dat.Location = new Point(290, 175);
            lb_Ngay_dat.Name = "lb_Ngay_dat";
            lb_Ngay_dat.Size = new Size(133, 25);
            lb_Ngay_dat.TabIndex = 7;
            lb_Ngay_dat.Text = "Ngày Đặt Sân";
            // 
            // lb_ten_khachhang
            // 
            lb_ten_khachhang.AutoSize = true;
            lb_ten_khachhang.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_ten_khachhang.Location = new Point(623, 175);
            lb_ten_khachhang.Name = "lb_ten_khachhang";
            lb_ten_khachhang.Size = new Size(155, 25);
            lb_ten_khachhang.TabIndex = 7;
            lb_ten_khachhang.Text = "Tên Khách Hàng";
            // 
            // btn_timkiem
            // 
            btn_timkiem.FlatStyle = FlatStyle.Popup;
            btn_timkiem.Image = (Image)resources.GetObject("btn_timkiem.Image");
            btn_timkiem.Location = new Point(1000, 169);
            btn_timkiem.Margin = new Padding(3, 4, 3, 4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(41, 40);
            btn_timkiem.TabIndex = 30;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // textBox_tẹnkhachhang
            // 
            textBox_tẹnkhachhang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_tẹnkhachhang.Location = new Point(773, 169);
            textBox_tẹnkhachhang.Margin = new Padding(3, 4, 3, 4);
            textBox_tẹnkhachhang.Name = "textBox_tẹnkhachhang";
            textBox_tẹnkhachhang.Size = new Size(197, 34);
            textBox_tẹnkhachhang.TabIndex = 31;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1124, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(201, 199);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 32;
            pictureBox1.TabStop = false;
            // 
            // FormDoanhthu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1389, 1000);
            Controls.Add(pictureBox1);
            Controls.Add(textBox_tẹnkhachhang);
            Controls.Add(btn_timkiem);
            Controls.Add(lb_ten_khachhang);
            Controls.Add(lb_Ngay_dat);
            Controls.Add(ngay_dat_san);
            Controls.Add(danhsach_doanhthhu);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormDoanhthu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDoanhthu";
            Load += FormDoanhthu_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)danhsach_doanhthhu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button_linkdatsan;
        private Button button_taikhoan;
        private Button button2;
        private Button button1;
        private Label label1;
        private DataGridView danhsach_doanhthhu;
        private DateTimePicker ngay_dat_san;
        private Label lb_Ngay_dat;
        private Label lb_ten_khachhang;
        private Button btn_timkiem;
        private TextBox textBox_tẹnkhachhang;
        private PictureBox pictureBox1;
    }
}