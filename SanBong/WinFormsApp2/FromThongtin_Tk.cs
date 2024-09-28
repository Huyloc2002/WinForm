using MySql.Data.MySqlClient;
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
    public partial class FromThongtin_Tk : Form
    {
        private string connect = "server=127.0.0.1;user=root; database=quan_ly_san_bong; password=";
        public FromThongtin_Tk()
        {
            InitializeComponent();

           
        }

        private void FromThongtin_Tk_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connect);

            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SHOW TABLES;", mySqlConnection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                /* MessageBox.Show("connect success");*/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }

            // hien thi danh sach
            try
            {
                mySqlConnection.Open();
                string query = "SELECT * FROM quan_ly;";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                LoadData();
                thongtintk.DataSource = dataTable; // Hiển thị dữ liệu lên DataGridView

                thongtintk.Columns["quan_ly_id"].HeaderText = "Mã";
                thongtintk.Columns["ho_ten"].HeaderText = "Tên Tài Khoản";
                thongtintk.Columns["email"].HeaderText = "Email";
                thongtintk.Columns["so_dien_thoai"].HeaderText = "số điện thoại";
                thongtintk.Columns["mat_khau"].HeaderText = "Mật khẩu";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mySqlConnection.Close();
            }
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT quan_ly_id , ho_ten , email ,so_dien_thoai ,mat_khau  FROM quan_ly";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        thongtintk.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }

        private void btn_formmain_Click(object sender, EventArgs e)
        {
            FormMain form = new FormMain();
            form.Show();
            this.Hide();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string username = textbox_username.Text.Trim();

            if (!string.IsNullOrEmpty(username))
            {
                SearchUserInfo(username);
            }
            else
            {
                MessageBox.Show("làm ơn nhập đúng tên.");
            }
        }

        private void SearchUserInfo(string username)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                string query = "SELECT * FROM quan_ly WHERE ho_ten LIKE  @HoTen";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@HoTen", "%" + username + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        thongtintk.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }



     

       
    }
}
