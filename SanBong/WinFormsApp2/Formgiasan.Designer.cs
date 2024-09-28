namespace WinFormsApp2
{
    partial class Formgiasan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formgiasan));
            dataGridView_giasan = new DataGridView();
            label_giasan = new Label();
            groupBox1 = new GroupBox();
            button_linkdatsan = new Button();
            button_taikhoan = new Button();
            button2 = new Button();
            button1 = new Button();
            btn_timkiem = new Button();
            label2 = new Label();
            txt_giasan = new TextBox();
            btn_refersh = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_giasan).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView_giasan
            // 
            dataGridView_giasan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView_giasan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_giasan.Location = new Point(301, 194);
            dataGridView_giasan.Margin = new Padding(3, 4, 3, 4);
            dataGridView_giasan.Name = "dataGridView_giasan";
            dataGridView_giasan.ReadOnly = true;
            dataGridView_giasan.RowHeadersWidth = 51;
            dataGridView_giasan.RowTemplate.Height = 25;
            dataGridView_giasan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_giasan.Size = new Size(941, 595);
            dataGridView_giasan.TabIndex = 0;
            // 
            // label_giasan
            // 
            label_giasan.AutoSize = true;
            label_giasan.Font = new Font("Showcard Gothic", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label_giasan.Location = new Point(77, 21);
            label_giasan.Name = "label_giasan";
            label_giasan.Size = new Size(476, 37);
            label_giasan.TabIndex = 1;
            label_giasan.Text = "MY FOOTBALL PITCH - GIÁ SÂN";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(button_linkdatsan);
            groupBox1.Controls.Add(button_taikhoan);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(1, 79);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(290, 1137);
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
            // btn_timkiem
            // 
            btn_timkiem.FlatStyle = FlatStyle.Popup;
            btn_timkiem.Image = (Image)resources.GetObject("btn_timkiem.Image");
            btn_timkiem.Location = new Point(561, 134);
            btn_timkiem.Margin = new Padding(3, 4, 3, 4);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(42, 40);
            btn_timkiem.TabIndex = 22;
            btn_timkiem.UseVisualStyleBackColor = true;
            btn_timkiem.Click += btn_timkiem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(298, 140);
            label2.Name = "label2";
            label2.Size = new Size(94, 25);
            label2.TabIndex = 21;
            label2.Text = "Tìm Kiếm";
            // 
            // txt_giasan
            // 
            txt_giasan.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txt_giasan.Location = new Point(391, 135);
            txt_giasan.Margin = new Padding(3, 4, 3, 4);
            txt_giasan.Name = "txt_giasan";
            txt_giasan.Size = new Size(162, 34);
            txt_giasan.TabIndex = 20;
            // 
            // btn_refersh
            // 
            btn_refersh.BackColor = Color.YellowGreen;
            btn_refersh.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btn_refersh.Image = (Image)resources.GetObject("btn_refersh.Image");
            btn_refersh.Location = new Point(816, 134);
            btn_refersh.Name = "btn_refersh";
            btn_refersh.Size = new Size(40, 40);
            btn_refersh.TabIndex = 23;
            btn_refersh.UseVisualStyleBackColor = false;
            btn_refersh.Click += btn_refersh_Click;
            // 
            // Formgiasan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(1389, 1000);
            Controls.Add(btn_refersh);
            Controls.Add(btn_timkiem);
            Controls.Add(label2);
            Controls.Add(txt_giasan);
            Controls.Add(groupBox1);
            Controls.Add(label_giasan);
            Controls.Add(dataGridView_giasan);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Formgiasan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Formgiasan";
            Load += Formgiasan_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_giasan).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView_giasan;
        private Label label_giasan;
        private GroupBox groupBox1;
        private Button button_linkdatsan;
        private Button button_taikhoan;
        private Button button2;
        private Button button1;
        private Button btn_timkiem;
        private Label label2;
        private TextBox txt_giasan;
        private Button btn_refersh;
    }
}