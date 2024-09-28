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
using static WinFormsApp2.Sanbong;

namespace WinFormsApp2
{
    public partial class FormKhachHang : Form
    {
        private string connect = "server=127.0.0.1;user=root; database=quan_ly_san_bong; password=";
        public FormKhachHang()
        {
            InitializeComponent();
        }

        private void FormKhachHang_Load(object sender, EventArgs e)
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
                string query = "SELECT khach_hang_id , ho_ten , email ,so_dien_thoai ,dia_chi  FROM khach_hang;";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                LoadData();
                danh_sach_khachhang.DataSource = dataTable; // Hiển thị dữ liệu lên DataGridView


                danh_sach_khachhang.Columns["khach_hang_id"].HeaderText = "Mã Khách Hàng";
                danh_sach_khachhang.Columns["ho_ten"].HeaderText = "Họ Tên";
                danh_sach_khachhang.Columns["email"].HeaderText = "Email";
                danh_sach_khachhang.Columns["So_dien_thoai"].HeaderText = "Số điện thoại";
                danh_sach_khachhang.Columns["dia_chi"].HeaderText = "Địa Chỉ";

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
                    string query = "SELECT khach_hang_id , ho_ten , email ,so_dien_thoai ,dia_chi  FROM khach_hang";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        danh_sach_khachhang.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }

        private void btn_themkhachhang_Click(object sender, EventArgs e)
        {
            string tenkhachhang = txt_tenkhachhang.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            string diachi = txt_diachi.Text;

            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();
                string query = "INSERT INTO khach_hang(ho_ten,email,so_dien_thoai,dia_chi) VALUES (@ho_ten,@email,@so_dien_thoai,@dia_chi)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ho_ten", tenkhachhang);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@so_dien_thoai", phone);
                    cmd.Parameters.AddWithValue("@dia_chi", diachi);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Đã thêm Thông tin thành công!");
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("khong thêmThông tin thành công!");
                    }

                }
            }


        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            int selectrowIndex = danh_sach_khachhang.SelectedRows[0].Index;
            int id = Convert.ToInt32(danh_sach_khachhang.SelectedRows[0].Cells["khach_hang_id"].Value);
            string hoten = txt_tenkhachhang.Text;
            string email = txt_email.Text;
            string phone = txt_phone.Text;
            string diachi = txt_diachi.Text;

            if (MessageBox.Show("bạn có chắc muốn sửa không?", "xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE khach_hang SET ho_ten = @hoten, email = @email, so_dien_thoai = @sodienthoai, dia_chi = @dia_chi WHERE khach_hang_id = @khachhangId";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@khachhangId", id);
                            cmd.Parameters.AddWithValue("@hoten", hoten);
                            cmd.Parameters.AddWithValue("@email", email);
                            cmd.Parameters.AddWithValue("@sodienthoai", phone);
                            cmd.Parameters.AddWithValue("@dia_chi", diachi);

                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Đã Sửa khách hàng thành công!");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("khong Sửa khách hàng  thành công!");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi:" + ex.Message);
                    }
                }
            }
        }

        private void danh_sach_khachhang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (danh_sach_khachhang.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                int id;
                id = int.Parse(danh_sach_khachhang.Rows[e.RowIndex].Cells[0].Value.ToString());
                txt_tenkhachhang.Text = danh_sach_khachhang.Rows[e.RowIndex].Cells[1].Value.ToString();
                txt_email.Text = danh_sach_khachhang.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_phone.Text = danh_sach_khachhang.Rows[e.RowIndex].Cells[3].Value.ToString();
                txt_diachi.Text = danh_sach_khachhang.Rows[e.RowIndex].Cells[4].Value.ToString();


            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            txt_tenkhachhang.Text = string.Empty;
            txt_email.Text = string.Empty;
            txt_phone.Text = string.Empty;
            txt_diachi.Text = string.Empty;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {

            string Tenkhachhang = textbox_Tenkhachhang.Text.Trim();

            if (!string.IsNullOrEmpty(Tenkhachhang))
            {
                SearchTebSanInfo(Tenkhachhang);
            }
            else
            {
                MessageBox.Show("làm ơn nhập đúng tên.");
            }
        }

        private void SearchTebSanInfo(string Tenkhachhang)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                string query = "SELECT khach_hang_id , ho_ten , email ,so_dien_thoai ,dia_chi  FROM khach_hang WHERE ho_ten LIKE  @ho_ten";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ho_ten", "%" + Tenkhachhang + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        danh_sach_khachhang.DataSource = dataTable;
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
