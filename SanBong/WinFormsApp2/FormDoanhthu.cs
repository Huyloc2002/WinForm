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
    public partial class FormDoanhthu : Form
    {
        private string connect = "server=127.0.0.1;user=root; database=quan_ly_san_bong; password=";
        public FormDoanhthu()
        {
            InitializeComponent();
            ngay_dat_san.ValueChanged += ngay_dat_san_ValueChanged;
        }

        private void ngay_dat_san_ValueChanged(object? sender, EventArgs e)
        {
            string hoTen = textBox_tẹnkhachhang.Text.Trim();
            string ngay_dat = ngay_dat_san.Value.ToString("yyyy-MM-dd").Trim();

            SearchByHoTen(hoTen, ngay_dat);
        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT d.doanhthu_id, d.phieu_id,k.ho_ten,k.email, k.so_dien_thoai, p.ngay_dat,d.ngay_doanhthu,d.tong_doanhthu FROM doanhthu d JOIN phieu_dat_san p ON d.phieu_id = p.phieu_id JOIN khach_hang k ON d.khach_hang_id = k.khach_hang_id;";

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        danhsach_doanhthhu.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }
        private void FormDoanhthu_Load(object sender, EventArgs e)
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
                string query = "SELECT d.doanhthu_id, d.phieu_id,k.ho_ten,k.email, k.so_dien_thoai, p.ngay_dat,d.ngay_doanhthu,d.tong_doanhthu FROM doanhthu d JOIN phieu_dat_san p ON d.phieu_id = p.phieu_id JOIN khach_hang k ON d.khach_hang_id = k.khach_hang_id;";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                LoadData();
                danhsach_doanhthhu.DataSource = dataTable; // Hiển thị dữ liệu lên DataGridView

                danhsach_doanhthhu.Columns["doanhthu_id"].HeaderText = "Mã";
                danhsach_doanhthhu.Columns["phieu_id"].HeaderText = "Mã phiếu ";
                danhsach_doanhthhu.Columns["ho_ten"].HeaderText = "Tên khách Hàng";
                danhsach_doanhthhu.Columns["Tong_doanhthu"].HeaderText = "Tổng doanh thu ";
                danhsach_doanhthhu.Columns["ngay_doanhthu"].HeaderText = "Ngày doanh thu ";

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

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string hoTen = textBox_tẹnkhachhang.Text.Trim();
            string ngay_dat = ngay_dat_san.Value.ToString("yyyy-MM-dd").Trim();

            // Check if both fields are not empty
            if (!string.IsNullOrEmpty(hoTen) && !string.IsNullOrEmpty(ngay_dat))
            {
                SearchByHoTen(hoTen, ngay_dat);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ tên của khách hàng và ngày đặt.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchByHoTen(string hoTen, string ngay_dat)
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                // Define the query with parameters
                string query = @"SELECT d.doanhthu_id, d.phieu_id, k.ho_ten, k.email, k.so_dien_thoai, 
                                p.ngay_dat, d.ngay_doanhthu, d.tong_doanhthu 
                         FROM doanhthu d 
                         JOIN phieu_dat_san p ON d.phieu_id = p.phieu_id 
                         JOIN khach_hang k ON d.khach_hang_id = k.khach_hang_id  
                         WHERE k.ho_ten LIKE @hoTen 
                         AND p.ngay_dat = @ngay_dat;";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Add parameters for the query
                    cmd.Parameters.AddWithValue("@hoTen", "%" + hoTen + "%");
                    cmd.Parameters.AddWithValue("@ngay_dat", ngay_dat);

                    // Create DataAdapter and DataTable
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        // Open the connection, fill the DataTable, and set the DataSource
                        conn.Open();
                        adapter.Fill(dataTable);
                        danhsach_doanhthhu.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        // Show an error message if an exception occurs
                        MessageBox.Show("Lỗi: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
