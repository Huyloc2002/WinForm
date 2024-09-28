namespace WinFormsApp2
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            button_Exit = new Button();
            pictureBox1 = new PictureBox();
            label_password = new Label();
            label_username = new Label();
            button_ForgotPassword = new Button();
            button_Register = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox_Password = new TextBox();
            textBox_User = new TextBox();
            label3 = new Label();
            textBox_email = new TextBox();
            textBox_phone = new TextBox();
            lb_email = new Label();
            lb_phone = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.Red;
            button_Exit.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Exit.Location = new Point(755, -1);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(46, 29);
            button_Exit.TabIndex = 20;
            button_Exit.Text = "X";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkKhaki;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.anen;
            pictureBox1.Location = new Point(-3, -1);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 484);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_password.Location = new Point(402, 322);
            label_password.Name = "label_password";
            label_password.Size = new Size(85, 18);
            label_password.TabIndex = 18;
            label_password.Text = "Password";
            // 
            // label_username
            // 
            label_username.AutoSize = true;
            label_username.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_username.Location = new Point(402, 161);
            label_username.Name = "label_username";
            label_username.Size = new Size(85, 18);
            label_username.TabIndex = 17;
            label_username.Text = "userName";
            // 
            // button_ForgotPassword
            // 
            button_ForgotPassword.Location = new Point(606, 416);
            button_ForgotPassword.Name = "button_ForgotPassword";
            button_ForgotPassword.Size = new Size(142, 38);
            button_ForgotPassword.TabIndex = 16;
            button_ForgotPassword.Text = "ForgotPassword?";
            button_ForgotPassword.UseVisualStyleBackColor = true;
            // 
            // button_Register
            // 
            button_Register.BackColor = Color.PaleGoldenrod;
            button_Register.Location = new Point(484, 416);
            button_Register.Name = "button_Register";
            button_Register.Size = new Size(94, 38);
            button_Register.TabIndex = 15;
            button_Register.Text = "Register";
            button_Register.UseVisualStyleBackColor = false;
            button_Register.Click += button_Register_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(464, 97);
            label2.Name = "label2";
            label2.Size = new Size(236, 35);
            label2.TabIndex = 14;
            label2.Text = "Onn FootBall ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM American Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(452, 57);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 13;
            label1.Text = "WelCome To ";
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(493, 319);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(255, 27);
            textBox_Password.TabIndex = 12;
            // 
            // textBox_User
            // 
            textBox_User.Location = new Point(493, 156);
            textBox_User.Name = "textBox_User";
            textBox_User.Size = new Size(255, 27);
            textBox_User.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(511, 22);
            label3.Name = "label3";
            label3.Size = new Size(154, 35);
            label3.TabIndex = 21;
            label3.Text = "REGISTER";
            // 
            // textBox_email
            // 
            textBox_email.Location = new Point(493, 204);
            textBox_email.Name = "textBox_email";
            textBox_email.Size = new Size(255, 27);
            textBox_email.TabIndex = 12;
            // 
            // textBox_phone
            // 
            textBox_phone.Location = new Point(493, 261);
            textBox_phone.Name = "textBox_phone";
            textBox_phone.Size = new Size(255, 27);
            textBox_phone.TabIndex = 12;
            // 
            // lb_email
            // 
            lb_email.AutoSize = true;
            lb_email.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_email.Location = new Point(412, 204);
            lb_email.Name = "lb_email";
            lb_email.Size = new Size(52, 18);
            lb_email.TabIndex = 17;
            lb_email.Text = "EMAIL";
            // 
            // lb_phone
            // 
            lb_phone.AutoSize = true;
            lb_phone.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lb_phone.Location = new Point(411, 261);
            lb_phone.Name = "lb_phone";
            lb_phone.Size = new Size(58, 18);
            lb_phone.TabIndex = 17;
            lb_phone.Text = "PHONE";
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 484);
            Controls.Add(label3);
            Controls.Add(button_Exit);
            Controls.Add(pictureBox1);
            Controls.Add(label_password);
            Controls.Add(lb_phone);
            Controls.Add(lb_email);
            Controls.Add(label_username);
            Controls.Add(button_ForgotPassword);
            Controls.Add(button_Register);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_phone);
            Controls.Add(textBox_email);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_User);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            Load += FormRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Exit;
        private PictureBox pictureBox1;
        private Label label_password;
        private Label label_username;
        private Button button_ForgotPassword;
        private Button button_Register;
        private Label label2;
        private Label label1;
        private TextBox textBox_Password;
        private TextBox textBox_User;
        private Label label3;
        private TextBox textBox_email;
        private TextBox textBox_phone;
        private Label lb_email;
        private Label lb_phone;
    }
}