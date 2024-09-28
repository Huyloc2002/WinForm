namespace WinFormsApp2
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            label1 = new Label();
            groupBox1 = new GroupBox();
            button_linkdatsan = new Button();
            button_taikhoan = new Button();
            button2 = new Button();
            button1 = new Button();
            imageList1 = new ImageList(components);
            groupBox2 = new GroupBox();
            btn_cancel = new Button();
            comboBox_TrangThai = new ComboBox();
            textBox_Giathue = new TextBox();
            textBox_Diachi = new TextBox();
            textBox_tensan = new TextBox();
            button_datsan = new Button();
            button_xemgiadatsan = new Button();
            label6 = new Label();
            label_giathue = new Label();
            label_trangthai = new Label();
            label_Tensan = new Label();
            dateTimePicker1 = new DateTimePicker();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            dataGridView_danhsachsanbong = new DataGridView();
            button_sua = new Button();
            button_xoa = new Button();
            button_Exit = new Button();
            pictureBox2 = new PictureBox();
            pictureBox5 = new PictureBox();
            txt_tensan = new TextBox();
            label2 = new Label();
            btn_timkiem = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_danhsachsanbong).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(71, 25);
            label1.Name = "label1";
            label1.Size = new Size(785, 37);
            label1.TabIndex = 0;
            label1.Text = "MY FOOTBALL PITCH - SÂN BÓNG FELIX                          ";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(button_linkdatsan);
            groupBox1.Controls.Add(button_taikhoan);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(-2, 83);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(281, 915);
            groupBox1.TabIndex = 1;
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
            button_linkdatsan.Click += button_linkdatsan_Click;
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
            button_taikhoan.Click += button_taikhoan_Click;
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
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btn_cancel);
            groupBox2.Controls.Add(comboBox_TrangThai);
            groupBox2.Controls.Add(textBox_Giathue);
            groupBox2.Controls.Add(textBox_Diachi);
            groupBox2.Controls.Add(textBox_tensan);
            groupBox2.Controls.Add(button_datsan);
            groupBox2.Controls.Add(button_xemgiadatsan);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label_giathue);
            groupBox2.Controls.Add(label_trangthai);
            groupBox2.Controls.Add(label_Tensan);
            groupBox2.Location = new Point(657, 83);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(685, 485);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = Color.YellowGreen;
            btn_cancel.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_cancel.Image = (Image)resources.GetObject("btn_cancel.Image");
            btn_cancel.Location = new Point(406, 13);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(40, 40);
            btn_cancel.TabIndex = 17;
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // comboBox_TrangThai
            // 
            comboBox_TrangThai.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox_TrangThai.FormattingEnabled = true;
            comboBox_TrangThai.Location = new Point(206, 239);
            comboBox_TrangThai.Margin = new Padding(3, 4, 3, 4);
            comboBox_TrangThai.Name = "comboBox_TrangThai";
            comboBox_TrangThai.Size = new Size(173, 28);
            comboBox_TrangThai.TabIndex = 16;
            // 
            // textBox_Giathue
            // 
            textBox_Giathue.Location = new Point(206, 188);
            textBox_Giathue.Margin = new Padding(3, 4, 3, 4);
            textBox_Giathue.Name = "textBox_Giathue";
            textBox_Giathue.Size = new Size(165, 27);
            textBox_Giathue.TabIndex = 15;
            // 
            // textBox_Diachi
            // 
            textBox_Diachi.Location = new Point(206, 133);
            textBox_Diachi.Margin = new Padding(3, 4, 3, 4);
            textBox_Diachi.Name = "textBox_Diachi";
            textBox_Diachi.Size = new Size(165, 27);
            textBox_Diachi.TabIndex = 14;
            // 
            // textBox_tensan
            // 
            textBox_tensan.Location = new Point(206, 79);
            textBox_tensan.Margin = new Padding(3, 4, 3, 4);
            textBox_tensan.Name = "textBox_tensan";
            textBox_tensan.Size = new Size(165, 27);
            textBox_tensan.TabIndex = 13;
            // 
            // button_datsan
            // 
            button_datsan.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_datsan.ForeColor = SystemColors.ButtonHighlight;
            button_datsan.Image = Properties.Resources.anen2;
            button_datsan.Location = new Point(87, 387);
            button_datsan.Margin = new Padding(3, 4, 3, 4);
            button_datsan.Name = "button_datsan";
            button_datsan.Size = new Size(414, 61);
            button_datsan.TabIndex = 11;
            button_datsan.Text = "THÊM SÂN";
            button_datsan.UseVisualStyleBackColor = true;
            button_datsan.Click += button_datsan_Click;
            // 
            // button_xemgiadatsan
            // 
            button_xemgiadatsan.BackColor = SystemColors.ActiveCaption;
            button_xemgiadatsan.Font = new Font("Segoe UI Emoji", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button_xemgiadatsan.ForeColor = SystemColors.ButtonHighlight;
            button_xemgiadatsan.Location = new Point(459, 75);
            button_xemgiadatsan.Margin = new Padding(3, 4, 3, 4);
            button_xemgiadatsan.Name = "button_xemgiadatsan";
            button_xemgiadatsan.Size = new Size(122, 192);
            button_xemgiadatsan.TabIndex = 10;
            button_xemgiadatsan.Text = "Xem giá Sân bị đặt";
            button_xemgiadatsan.UseVisualStyleBackColor = false;
            button_xemgiadatsan.Click += button_xemgiadatsan_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ActiveCaptionText;
            label6.Location = new Point(87, 131);
            label6.Name = "label6";
            label6.Size = new Size(71, 25);
            label6.TabIndex = 5;
            label6.Text = "Địa chỉ";
            // 
            // label_giathue
            // 
            label_giathue.AutoSize = true;
            label_giathue.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_giathue.ForeColor = SystemColors.ActiveCaptionText;
            label_giathue.Location = new Point(87, 185);
            label_giathue.Name = "label_giathue";
            label_giathue.Size = new Size(93, 25);
            label_giathue.TabIndex = 4;
            label_giathue.Text = "Giá Thuế";
            // 
            // label_trangthai
            // 
            label_trangthai.AutoSize = true;
            label_trangthai.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_trangthai.ForeColor = SystemColors.ActiveCaptionText;
            label_trangthai.Location = new Point(87, 239);
            label_trangthai.Name = "label_trangthai";
            label_trangthai.Size = new Size(108, 25);
            label_trangthai.TabIndex = 3;
            label_trangthai.Text = "Trạng Thái";
            // 
            // label_Tensan
            // 
            label_Tensan.AutoSize = true;
            label_Tensan.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label_Tensan.ForeColor = SystemColors.ActiveCaptionText;
            label_Tensan.Location = new Point(87, 80);
            label_Tensan.Name = "label_Tensan";
            label_Tensan.Size = new Size(88, 25);
            label_Tensan.TabIndex = 0;
            label_Tensan.Text = "Tên Sân";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(0, 0);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FloralWhite;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.anen;
            pictureBox1.Location = new Point(299, 96);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 436);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
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
            pictureBox3.Location = new Point(394, 583);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(85, 140);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 7;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaptionText;
            pictureBox4.BackgroundImage = Properties.Resources.anen;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.InitialImage = Properties.Resources.anen;
            pictureBox4.Location = new Point(286, 583);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(87, 140);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 8;
            pictureBox4.TabStop = false;
            // 
            // dataGridView_danhsachsanbong
            // 
            dataGridView_danhsachsanbong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_danhsachsanbong.BackgroundColor = SystemColors.ControlLight;
            dataGridView_danhsachsanbong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_danhsachsanbong.Location = new Point(587, 621);
            dataGridView_danhsachsanbong.Name = "dataGridView_danhsachsanbong";
            dataGridView_danhsachsanbong.ReadOnly = true;
            dataGridView_danhsachsanbong.RowHeadersWidth = 51;
            dataGridView_danhsachsanbong.RowTemplate.Height = 29;
            dataGridView_danhsachsanbong.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_danhsachsanbong.Size = new Size(790, 377);
            dataGridView_danhsachsanbong.TabIndex = 10;
            dataGridView_danhsachsanbong.CellContentClick += dataGridView_danhsachsanbong_CellContentClick;
            // 
            // button_sua
            // 
            button_sua.BackColor = Color.Cyan;
            button_sua.Font = new Font("Elephant", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button_sua.Image = (Image)resources.GetObject("button_sua.Image");
            button_sua.ImageAlign = ContentAlignment.TopCenter;
            button_sua.Location = new Point(491, 639);
            button_sua.Name = "button_sua";
            button_sua.Size = new Size(94, 85);
            button_sua.TabIndex = 12;
            button_sua.Text = "update";
            button_sua.TextAlign = ContentAlignment.BottomCenter;
            button_sua.UseVisualStyleBackColor = false;
            button_sua.Click += button_sua_Click;
            // 
            // button_xoa
            // 
            button_xoa.BackColor = Color.Goldenrod;
            button_xoa.Font = new Font("Elephant", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button_xoa.Image = (Image)resources.GetObject("button_xoa.Image");
            button_xoa.ImageAlign = ContentAlignment.TopCenter;
            button_xoa.Location = new Point(491, 755);
            button_xoa.Name = "button_xoa";
            button_xoa.Size = new Size(94, 91);
            button_xoa.TabIndex = 13;
            button_xoa.Text = "delede";
            button_xoa.TextAlign = ContentAlignment.BottomCenter;
            button_xoa.UseVisualStyleBackColor = false;
            button_xoa.Click += button_xoa_Click;
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.Red;
            button_Exit.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Exit.Location = new Point(1296, 0);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(46, 29);
            button_Exit.TabIndex = 14;
            button_Exit.Text = "X";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaptionText;
            pictureBox2.BackgroundImage = Properties.Resources.anen;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.InitialImage = Properties.Resources.anen;
            pictureBox2.Location = new Point(286, 755);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(87, 140);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 15;
            pictureBox2.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ActiveCaptionText;
            pictureBox5.BackgroundImage = Properties.Resources.anen;
            pictureBox5.BorderStyle = BorderStyle.Fixed3D;
            pictureBox5.Cursor = Cursors.Hand;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.InitialImage = Properties.Resources.anen;
            pictureBox5.Location = new Point(394, 755);
            pictureBox5.Margin = new Padding(3, 4, 3, 4);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(87, 140);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 16;
            pictureBox5.TabStop = false;
            // 
            // txt_tensan
            // 
            txt_tensan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_tensan.Location = new Point(1131, 576);
            txt_tensan.Margin = new Padding(3, 4, 3, 4);
            txt_tensan.Name = "txt_tensan";
            txt_tensan.Size = new Size(162, 34);
            txt_tensan.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(1038, 581);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 18;
            label2.Text = "Tìm Kiếm";
            // 
            // btn_timkiem
            // 
            btn_timkiem.FlatStyle = FlatStyle.Popup;
            btn_timkiem.Image = (Image)resources.GetObject("btn_timkiem.Image");
            btn_timkiem.Location = new Point(1301, 575);
            btn_timkiem.Margin = new Padding(3, 4, 3, 4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(42, 40);
            btn_timkiem.TabIndex = 19;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1389, 1000);
            Controls.Add(btn_timkiem);
            Controls.Add(label2);
            Controls.Add(txt_tensan);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox2);
            Controls.Add(button_Exit);
            Controls.Add(button_xoa);
            Controls.Add(button_sua);
            Controls.Add(dataGridView_danhsachsanbong);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(dateTimePicker1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "San bong mini";
            Load += FormMain_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView_danhsachsanbong).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Button button1;
        private Button button_linkdatsan;
        private Button button_taikhoan;
        private Button button2;
        private ImageList imageList1;
        private GroupBox groupBox2;
        private Button button_xemgiadatsan;
        private ComboBox comboBox4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label6;
        private Label label_giathue;
        private Label label_trangthai;
        private Label label3;
        private Label label_Tensan;
        private Button button_datsan;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private DataGridView dataGridView_danhsachsanbong;
        private Button button_sua;
        private Button button_xoa;
        private TextBox textBox_Diachi;
        private TextBox textBox_tensan;
        private TextBox textBox_Giathue;
        private ComboBox comboBox_TrangThai;
        private Button button_Exit;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Button btn_cancel;
        private TextBox txt_tensan;
        private Label label2;
        private Button btn_timkiem;
    }
}