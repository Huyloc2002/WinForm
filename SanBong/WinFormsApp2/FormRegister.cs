using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;
namespace WinFormsApp2
{
    public partial class FormRegister : Form
    {
        private static string connect = "server=127.0.0.1;user=root; database=quan_ly_san_bong; password=";
        public FormRegister()
        {
            InitializeComponent();
        }


        public static bool RegisterUser(string ho_ten, string email,string phone, string mat_khau)
        {
            using (var connection = new MySqlConnection(connect))
            {
                connection.Open();
                string query = "INSERT INTO quan_ly (ho_ten,email,so_dien_thoai, mat_khau) VALUES (@ho_ten,@email,@so_dien_thoai, @mat_khau)";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ho_ten", ho_ten);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@so_dien_thoai", phone);
                    command.Parameters.AddWithValue("@mat_khau", BCrypt.Net.BCrypt.HashPassword(mat_khau));
                    return command.ExecuteNonQuery() > 0;
                }
            }
        }
        public static bool AuthenticateUser(string ho_ten, string mat_khau)
        {
            using (var connection = new MySqlConnection(connect))
            {
                connection.Open();
                string query = "SELECT mat_khau FROM quan_ly WHERE ho_ten = @ho_ten";
                using (var command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ho_ten", ho_ten);
                    var hashedPassword = command.ExecuteScalar() as string;

                    return hashedPassword != null && BCrypt.Net.BCrypt.Verify(mat_khau, hashedPassword);
                }
            }
        }
        private void button_Register_Click(object sender, EventArgs e)
        {
            string ho_ten = textBox_User.Text;
            string email = textBox_email.Text; 
            string phone = textBox_phone.Text;
            string mat_khau = textBox_Password.Text;

            if (FormRegister.RegisterUser(ho_ten, email, phone, mat_khau))
            {
                MessageBox.Show("Đăng kí Thành Công !");
                var formlogin = new FormLogin();
                formlogin.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng kí Thất Bại.");
            }
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
