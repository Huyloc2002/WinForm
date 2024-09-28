namespace WinFormsApp2
{
    partial class Dat_san
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dat_san));
            danhsacch_datsan = new DataGridView();
            groupBox1 = new GroupBox();
            button_linkdatsan = new Button();
            button_taikhoan = new Button();
            button2 = new Button();
            btn_trangchu = new Button();
            label1 = new Label();
            Thong_tin = new GroupBox();
            btn_Cancel = new Button();
            gio_ket_thuc = new DateTimePicker();
            gio_bat_dau = new DateTimePicker();
            btn_Trasan = new Button();
            btn_suasan = new Button();
            btn_datsan = new Button();
            lb_tong_tien = new Label();
            lb_gio_ket_thuc = new Label();
            lb_gio_bat_dau = new Label();
            lb_ngay_dat_san = new Label();
            lb_ten_khach_hang = new Label();
            lb_ten_san_bong = new Label();
            tong_tien = new TextBox();
            ngay_dat_san = new DateTimePicker();
            ten_khach_hang = new ComboBox();
            ten_san_bong = new ComboBox();
            pictureBox4 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            label_san1 = new Label();
            label_san2 = new Label();
            pictureBox6 = new PictureBox();
            label_san6 = new Label();
            label_san5 = new Label();
            label_san4 = new Label();
            label_san3 = new Label();
            textBox_tẹnkhachhang = new TextBox();
            lb_timkiem = new Label();
            btn_timkiem = new Button();
            btn_pdf = new Button();
            ((System.ComponentModel.ISupportInitialize)danhsacch_datsan).BeginInit();
            groupBox1.SuspendLayout();
            Thong_tin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // danhsacch_datsan
            // 
            danhsacch_datsan.AllowUserToAddRows = false;
            danhsacch_datsan.AllowUserToDeleteRows = false;
            danhsacch_datsan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            danhsacch_datsan.BackgroundColor = SystemColors.Control;
            danhsacch_datsan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            danhsacch_datsan.Location = new Point(289, 556);
            danhsacch_datsan.Name = "danhsacch_datsan";
            danhsacch_datsan.ReadOnly = true;
            danhsacch_datsan.RowHeadersWidth = 51;
            danhsacch_datsan.RowTemplate.Height = 29;
            danhsacch_datsan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            danhsacch_datsan.Size = new Size(1026, 441);
            danhsacch_datsan.TabIndex = 0;
            danhsacch_datsan.CellContentClick += danhsacch_datsan_CellContentClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(button_linkdatsan);
            groupBox1.Controls.Add(button_taikhoan);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btn_trangchu);
            groupBox1.Location = new Point(2, 77);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(281, 920);
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
            // btn_trangchu
            // 
            btn_trangchu.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_trangchu.ForeColor = SystemColors.ButtonHighlight;
            btn_trangchu.Image = Properties.Resources.anen;
            btn_trangchu.Location = new Point(82, 29);
            btn_trangchu.Margin = new Padding(3, 4, 3, 4);
            btn_trangchu.Name = "btn_trangchu";
            btn_trangchu.Size = new Size(192, 61);
            btn_trangchu.TabIndex = 0;
            btn_trangchu.Text = "Trang Chủ";
            btn_trangchu.UseVisualStyleBackColor = true;
            btn_trangchu.Click += btn_trangchu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(68, 20);
            label1.Name = "label1";
            label1.Size = new Size(785, 37);
            label1.TabIndex = 3;
            label1.Text = "MY FOOTBALL PITCH - SÂN BÓNG FELIX                          ";
            // 
            // Thong_tin
            // 
            Thong_tin.Controls.Add(btn_Cancel);
            Thong_tin.Controls.Add(gio_ket_thuc);
            Thong_tin.Controls.Add(gio_bat_dau);
            Thong_tin.Controls.Add(btn_Trasan);
            Thong_tin.Controls.Add(btn_suasan);
            Thong_tin.Controls.Add(btn_datsan);
            Thong_tin.Controls.Add(lb_tong_tien);
            Thong_tin.Controls.Add(lb_gio_ket_thuc);
            Thong_tin.Controls.Add(lb_gio_bat_dau);
            Thong_tin.Controls.Add(lb_ngay_dat_san);
            Thong_tin.Controls.Add(lb_ten_khach_hang);
            Thong_tin.Controls.Add(lb_ten_san_bong);
            Thong_tin.Controls.Add(tong_tien);
            Thong_tin.Controls.Add(ngay_dat_san);
            Thong_tin.Controls.Add(ten_khach_hang);
            Thong_tin.Controls.Add(ten_san_bong);
            Thong_tin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Thong_tin.Location = new Point(289, 77);
            Thong_tin.Name = "Thong_tin";
            Thong_tin.Size = new Size(528, 445);
            Thong_tin.TabIndex = 4;
            Thong_tin.TabStop = false;
            Thong_tin.Text = "Thông Tin";
            // 
            // btn_Cancel
            // 
            btn_Cancel.BackColor = Color.YellowGreen;
            btn_Cancel.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Cancel.Image = (Image)resources.GetObject("btn_Cancel.Image");
            btn_Cancel.Location = new Point(487, 13);
            btn_Cancel.Name = "btn_Cancel";
            btn_Cancel.Size = new Size(40, 40);
            btn_Cancel.TabIndex = 22;
            btn_Cancel.UseVisualStyleBackColor = false;
            btn_Cancel.Click += btn_Cancel_Click_1;
            // 
            // gio_ket_thuc
            // 
            gio_ket_thuc.CustomFormat = "dd/MM/yyyy";
            gio_ket_thuc.Format = DateTimePickerFormat.Time;
            gio_ket_thuc.Location = new Point(214, 251);
            gio_ket_thuc.Name = "gio_ket_thuc";
            gio_ket_thuc.ShowUpDown = true;
            gio_ket_thuc.Size = new Size(194, 34);
            gio_ket_thuc.TabIndex = 21;
            // 
            // gio_bat_dau
            // 
            gio_bat_dau.CustomFormat = "dd/MM/yyyy";
            gio_bat_dau.Format = DateTimePickerFormat.Time;
            gio_bat_dau.Location = new Point(214, 203);
            gio_bat_dau.Name = "gio_bat_dau";
            gio_bat_dau.ShowUpDown = true;
            gio_bat_dau.Size = new Size(194, 34);
            gio_bat_dau.TabIndex = 20;
            // 
            // btn_Trasan
            // 
            btn_Trasan.BackColor = Color.OrangeRed;
            btn_Trasan.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_Trasan.Image = (Image)resources.GetObject("btn_Trasan.Image");
            btn_Trasan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_Trasan.Location = new Point(389, 385);
            btn_Trasan.Name = "btn_Trasan";
            btn_Trasan.Size = new Size(133, 55);
            btn_Trasan.TabIndex = 19;
            btn_Trasan.Text = "Trả Sân";
            btn_Trasan.TextAlign = ContentAlignment.MiddleRight;
            btn_Trasan.UseVisualStyleBackColor = false;
            btn_Trasan.Click += btn_Trasan_Click;
            // 
            // btn_suasan
            // 
            btn_suasan.BackColor = Color.DeepSkyBlue;
            btn_suasan.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_suasan.Image = (Image)resources.GetObject("btn_suasan.Image");
            btn_suasan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_suasan.Location = new Point(214, 385);
            btn_suasan.Name = "btn_suasan";
            btn_suasan.Size = new Size(139, 55);
            btn_suasan.TabIndex = 18;
            btn_suasan.Text = "Sửa Sân";
            btn_suasan.TextAlign = ContentAlignment.MiddleRight;
            btn_suasan.UseVisualStyleBackColor = false;
            btn_suasan.Click += btn_suasan_Click;
            // 
            // btn_datsan
            // 
            btn_datsan.BackColor = Color.Chartreuse;
            btn_datsan.FlatStyle = FlatStyle.Popup;
            btn_datsan.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btn_datsan.Image = (Image)resources.GetObject("btn_datsan.Image");
            btn_datsan.ImageAlign = ContentAlignment.MiddleLeft;
            btn_datsan.Location = new Point(39, 385);
            btn_datsan.Name = "btn_datsan";
            btn_datsan.Size = new Size(135, 53);
            btn_datsan.TabIndex = 17;
            btn_datsan.Text = "Đặt Sân";
            btn_datsan.TextAlign = ContentAlignment.MiddleRight;
            btn_datsan.UseVisualStyleBackColor = false;
            btn_datsan.Click += btn_datsan_Click;
            // 
            // lb_tong_tien
            // 
            lb_tong_tien.AutoSize = true;
            lb_tong_tien.Location = new Point(47, 316);
            lb_tong_tien.Name = "lb_tong_tien";
            lb_tong_tien.Size = new Size(98, 28);
            lb_tong_tien.TabIndex = 15;
            lb_tong_tien.Text = "Tổng Tiền";
            // 
            // lb_gio_ket_thuc
            // 
            lb_gio_ket_thuc.AutoSize = true;
            lb_gio_ket_thuc.Location = new Point(45, 255);
            lb_gio_ket_thuc.Name = "lb_gio_ket_thuc";
            lb_gio_ket_thuc.Size = new Size(121, 28);
            lb_gio_ket_thuc.TabIndex = 14;
            lb_gio_ket_thuc.Text = "Giờ kết Thúc";
            // 
            // lb_gio_bat_dau
            // 
            lb_gio_bat_dau.AutoSize = true;
            lb_gio_bat_dau.Location = new Point(47, 208);
            lb_gio_bat_dau.Name = "lb_gio_bat_dau";
            lb_gio_bat_dau.Size = new Size(116, 28);
            lb_gio_bat_dau.TabIndex = 13;
            lb_gio_bat_dau.Text = "Giờ Bắt Đầu";
            // 
            // lb_ngay_dat_san
            // 
            lb_ngay_dat_san.AutoSize = true;
            lb_ngay_dat_san.Location = new Point(45, 156);
            lb_ngay_dat_san.Name = "lb_ngay_dat_san";
            lb_ngay_dat_san.Size = new Size(127, 28);
            lb_ngay_dat_san.TabIndex = 12;
            lb_ngay_dat_san.Text = "Ngày đặt sân";
            // 
            // lb_ten_khach_hang
            // 
            lb_ten_khach_hang.AutoSize = true;
            lb_ten_khach_hang.Location = new Point(45, 97);
            lb_ten_khach_hang.Name = "lb_ten_khach_hang";
            lb_ten_khach_hang.Size = new Size(151, 28);
            lb_ten_khach_hang.TabIndex = 11;
            lb_ten_khach_hang.Text = "Tên Khách Hàng";
            // 
            // lb_ten_san_bong
            // 
            lb_ten_san_bong.AutoSize = true;
            lb_ten_san_bong.Location = new Point(45, 37);
            lb_ten_san_bong.Name = "lb_ten_san_bong";
            lb_ten_san_bong.Size = new Size(129, 28);
            lb_ten_san_bong.TabIndex = 10;
            lb_ten_san_bong.Text = "Tên Sân Bóng";
            // 
            // tong_tien
            // 
            tong_tien.Location = new Point(214, 309);
            tong_tien.Name = "tong_tien";
            tong_tien.Size = new Size(150, 34);
            tong_tien.TabIndex = 8;
            // 
            // ngay_dat_san
            // 
            ngay_dat_san.CustomFormat = "dd/MM/yyyy";
            ngay_dat_san.Format = DateTimePickerFormat.Custom;
            ngay_dat_san.Location = new Point(214, 156);
            ngay_dat_san.Name = "ngay_dat_san";
            ngay_dat_san.Size = new Size(194, 34);
            ngay_dat_san.TabIndex = 2;
            // 
            // ten_khach_hang
            // 
            ten_khach_hang.DropDownStyle = ComboBoxStyle.DropDownList;
            ten_khach_hang.FormattingEnabled = true;
            ten_khach_hang.Items.AddRange(new object[] { "Nguyen Van Mậu", "Đỗ Độc Lạ" });
            ten_khach_hang.Location = new Point(214, 93);
            ten_khach_hang.Name = "ten_khach_hang";
            ten_khach_hang.Size = new Size(194, 36);
            ten_khach_hang.TabIndex = 1;
            // 
            // ten_san_bong
            // 
            ten_san_bong.DropDownStyle = ComboBoxStyle.DropDownList;
            ten_san_bong.FormattingEnabled = true;
            ten_san_bong.Items.AddRange(new object[] { "sân 7", "sân 11" });
            ten_san_bong.Location = new Point(214, 40);
            ten_san_bong.Name = "ten_san_bong";
            ten_san_bong.Size = new Size(194, 36);
            ten_san_bong.TabIndex = 0;
            ten_san_bong.SelectedIndexChanged += ten_san_bong_SelectedIndexChanged;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaptionText;
            pictureBox4.BackgroundImage = Properties.Resources.anen;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = Properties.Resources.anen;
            pictureBox4.Location = new Point(838, 97);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(129, 179);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 9;
            pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaptionText;
            pictureBox1.BackgroundImage = Properties.Resources.anen;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.anen;
            pictureBox1.Location = new Point(1009, 97);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(129, 179);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ActiveCaptionText;
            pictureBox3.BackgroundImage = Properties.Resources.anen;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = Properties.Resources.anen;
            pictureBox3.Location = new Point(838, 320);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(129, 179);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaptionText;
            pictureBox5.BackgroundImage = Properties.Resources.anen;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = Properties.Resources.anen;
            pictureBox5.Location = new Point(1009, 320);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(129, 179);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.BackgroundImage = Properties.Resources.anen;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = Properties.Resources.anen;
            pictureBox2.Location = new Point(1190, 97);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 179);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 19;
            pictureBox2.TabStop = false;
            // 
            // label_san1
            // 
            label_san1.AutoSize = true;
            label_san1.BackColor = Color.Ivory;
            label_san1.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_san1.ForeColor = SystemColors.ActiveCaptionText;
            label_san1.Location = new Point(874, 156);
            label_san1.Name = "label_san1";
            label_san1.Size = new Size(59, 24);
            label_san1.TabIndex = 20;
            label_san1.Text = "Sân 1";
            // 
            // label_san2
            // 
            label_san2.AutoSize = true;
            label_san2.BackColor = Color.Ivory;
            label_san2.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_san2.Location = new Point(1045, 157);
            label_san2.Name = "label_san2";
            label_san2.Size = new Size(63, 24);
            label_san2.TabIndex = 21;
            label_san2.Text = "Sân 2";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ActiveCaptionText;
            pictureBox6.BackgroundImage = Properties.Resources.anen;
            pictureBox6.BorderStyle = BorderStyle.Fixed3D;
            pictureBox6.Cursor = Cursors.Hand;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.InitialImage = Properties.Resources.anen;
            pictureBox6.Location = new Point(1190, 320);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(129, 179);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 22;
            pictureBox6.TabStop = false;
            // 
            // label_san6
            // 
            label_san6.AutoSize = true;
            label_san6.BackColor = Color.Ivory;
            label_san6.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_san6.Location = new Point(1225, 377);
            label_san6.Name = "label_san6";
            label_san6.Size = new Size(63, 24);
            label_san6.TabIndex = 23;
            label_san6.Text = "Sân 6";
            // 
            // label_san5
            // 
            label_san5.AutoSize = true;
            label_san5.BackColor = Color.Ivory;
            label_san5.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_san5.Location = new Point(1042, 379);
            label_san5.Name = "label_san5";
            label_san5.Size = new Size(62, 24);
            label_san5.TabIndex = 24;
            label_san5.Text = "Sân 5";
            // 
            // label_san4
            // 
            label_san4.AutoSize = true;
            label_san4.BackColor = Color.Ivory;
            label_san4.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_san4.Location = new Point(872, 379);
            label_san4.Name = "label_san4";
            label_san4.Size = new Size(63, 24);
            label_san4.TabIndex = 25;
            label_san4.Text = "Sân 4";
            // 
            // label_san3
            // 
            label_san3.AutoSize = true;
            label_san3.BackColor = Color.Ivory;
            label_san3.Font = new Font("Elephant", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label_san3.Location = new Point(1224, 157);
            label_san3.Name = "label_san3";
            label_san3.Size = new Size(63, 24);
            label_san3.TabIndex = 26;
            label_san3.Text = "Sân 3";
            // 
            // textBox_tẹnkhachhang
            // 
            textBox_tẹnkhachhang.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_tẹnkhachhang.Location = new Point(939, 35);
            textBox_tẹnkhachhang.Margin = new Padding(3, 4, 3, 4);
            textBox_tẹnkhachhang.Name = "textBox_tẹnkhachhang";
            textBox_tẹnkhachhang.Size = new Size(159, 34);
            textBox_tẹnkhachhang.TabIndex = 27;
            // 
            // lb_timkiem
            // 
            lb_timkiem.AutoSize = true;
            lb_timkiem.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_timkiem.ForeColor = SystemColors.ControlLightLight;
            lb_timkiem.Location = new Point(838, 40);
            lb_timkiem.Name = "lb_timkiem";
            lb_timkiem.Size = new Size(94, 25);
            lb_timkiem.TabIndex = 28;
            lb_timkiem.Text = "Tìm Kiếm";
            // 
            // btn_timkiem
            // 
            btn_timkiem.FlatStyle = FlatStyle.Popup;
            btn_timkiem.Image = (Image)resources.GetObject("btn_timkiem.Image");
            btn_timkiem.Location = new Point(1110, 33);
            btn_timkiem.Margin = new Padding(3, 4, 3, 4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(41, 40);
            btn_timkiem.TabIndex = 29;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // btn_pdf
            // 
            btn_pdf.BackColor = Color.GreenYellow;
            btn_pdf.Location = new Point(289, 528);
            btn_pdf.Name = "btn_pdf";
            btn_pdf.Size = new Size(94, 29);
            btn_pdf.TabIndex = 30;
            btn_pdf.Text = "Xuất PDF";
            btn_pdf.UseVisualStyleBackColor = false;
            btn_pdf.Click += btn_pdf_Click;
            // 
            // Dat_san
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1389, 1000);
            Controls.Add(btn_pdf);
            Controls.Add(btn_timkiem);
            Controls.Add(lb_timkiem);
            Controls.Add(textBox_tẹnkhachhang);
            Controls.Add(label_san3);
            Controls.Add(label_san4);
            Controls.Add(label_san5);
            Controls.Add(label_san6);
            Controls.Add(pictureBox6);
            Controls.Add(label_san2);
            Controls.Add(label_san1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox4);
            Controls.Add(Thong_tin);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Controls.Add(danhsacch_datsan);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Dat_san";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dat_san";
            Load += Dat_san_Load;
            ((System.ComponentModel.ISupportInitialize)danhsacch_datsan).EndInit();
            groupBox1.ResumeLayout(false);
            Thong_tin.ResumeLayout(false);
            Thong_tin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView danhsacch_datsan;
        private GroupBox groupBox1;
        private Button button_linkdatsan;
        private Button button_taikhoan;
        private Button button2;
        private Button btn_trangchu;
        private Label label1;
        private GroupBox Thong_tin;
        private DateTimePicker ngay_dat_san;
        private ComboBox ten_khach_hang;
        private ComboBox ten_san_bong;
        private TextBox tong_tien;
        private Label lb_tong_tien;
        private Label lb_gio_ket_thuc;
        private Label lb_gio_bat_dau;
        private Label lb_ngay_dat_san;
        private Label lb_ten_khach_hang;
        private Label lb_ten_san_bong;
        private Button btn_Trasan;
        private Button btn_suasan;
        private Button btn_datsan;
        private DateTimePicker gio_ket_thuc;
        private DateTimePicker gio_bat_dau;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private Label label_san7;
        private Label label_san9;
        private Label label_san1;
        private Label label_san2;
        private PictureBox pictureBox6;
        private Label label_san6;
        private Label label_san5;
        private Label label_san4;
        private Label label_san3;
        private Button btn_Cancel;
        private TextBox textBox_tẹnkhachhang;
        private Label lb_timkiem;
        private Button btn_timkiem;
        private Button btn_pdf;
    }
}