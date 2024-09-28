namespace WinFormsApp2
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            textBox_User = new TextBox();
            textBox_Password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button_Login = new Button();
            button_ForgotPassword = new Button();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            button_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBox_User
            // 
            textBox_User.Location = new Point(498, 145);
            textBox_User.Name = "textBox_User";
            textBox_User.Size = new Size(255, 27);
            textBox_User.TabIndex = 0;
            // 
            // textBox_Password
            // 
            textBox_Password.Location = new Point(498, 203);
            textBox_Password.Name = "textBox_Password";
            textBox_Password.PasswordChar = '*';
            textBox_Password.Size = new Size(255, 27);
            textBox_Password.TabIndex = 1;
            textBox_Password.TextChanged += textBox_Password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("UTM American Sans", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(458, 38);
            label1.Name = "label1";
            label1.Size = new Size(126, 25);
            label1.TabIndex = 2;
            label1.Text = "WelCome To ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(470, 82);
            label2.Name = "label2";
            label2.Size = new Size(236, 35);
            label2.TabIndex = 3;
            label2.Text = "Onn FootBall ";
            // 
            // button_Login
            // 
            button_Login.BackColor = Color.PaleGoldenrod;
            button_Login.Location = new Point(490, 285);
            button_Login.Name = "button_Login";
            button_Login.Size = new Size(94, 38);
            button_Login.TabIndex = 4;
            button_Login.Text = "Login";
            button_Login.UseVisualStyleBackColor = false;
            button_Login.Click += button_Login_Click;
            // 
            // button_ForgotPassword
            // 
            button_ForgotPassword.Location = new Point(599, 285);
            button_ForgotPassword.Name = "button_ForgotPassword";
            button_ForgotPassword.Size = new Size(142, 38);
            button_ForgotPassword.TabIndex = 5;
            button_ForgotPassword.Text = "ForgotPassword?";
            button_ForgotPassword.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(407, 148);
            label3.Name = "label3";
            label3.Size = new Size(85, 18);
            label3.TabIndex = 7;
            label3.Text = "userName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(407, 208);
            label4.Name = "label4";
            label4.Size = new Size(85, 18);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.DarkSeaGreen;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = Properties.Resources.anen;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(399, 467);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button_Exit
            // 
            button_Exit.BackColor = Color.Red;
            button_Exit.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button_Exit.Location = new Point(720, 2);
            button_Exit.Name = "button_Exit";
            button_Exit.Size = new Size(46, 29);
            button_Exit.TabIndex = 10;
            button_Exit.Text = "X";
            button_Exit.UseVisualStyleBackColor = false;
            button_Exit.Click += button_Exit_Click;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(765, 472);
            Controls.Add(button_Exit);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button_ForgotPassword);
            Controls.Add(button_Login);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Password);
            Controls.Add(textBox_User);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormLogin";
       
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox_User;
        private TextBox textBox_Password;
        private Label label1;
        private Label label2;
        private Button button_Login;
        private Button button_ForgotPassword;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox1;
        private Button button_Exit;
    }
}