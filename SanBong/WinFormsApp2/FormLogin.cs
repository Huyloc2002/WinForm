using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void textBox_Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_cauthumini_Click(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            /* string user = textBox_User.Text;
             string password = textBox_Password.Text;
             if (user == "admin" && password == "admin")
             {
                 MessageBox.Show("Login Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 var formmain = new FormMain();
                 formmain.Show();
                 this.Hide();
             }
             else
             {
                 MessageBox.Show("Login không Thành Công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }*/
            string ho_ten = textBox_User.Text;
            string mat_khau = textBox_Password.Text;

            if (FormRegister.AuthenticateUser(ho_ten, mat_khau))
            {
                MessageBox.Show("Login Thành công!");
                // Chuyển đến form chính của ứng dụng
                var formdasboash = new Dasdboash();
                formdasboash.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("KHÔNG ĐÚNG MẬT KHẨU.");
            }
        }

 
    }
}
