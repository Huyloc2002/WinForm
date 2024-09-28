using Microsoft.Data.SqlClient;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static WinFormsApp2.Sanbong;

namespace WinFormsApp2
{
    public partial class FormMain : Form
    {

        private string connect = "server=127.0.0.1;user=root; database=quan_ly_san_bong; password=";
        public FormMain()
        {
            InitializeComponent();

           
        }


        private void FormMain_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connect);
            comboBox_TrangThai.Items.Add("có sẵn");
            comboBox_TrangThai.Items.Add("thuê");
            comboBox_TrangThai.Items.Add("đang bảo trì");
            LoadData();


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
                string query = "SELECT * FROM sanbong;";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                LoadData();
                dataGridView_danhsachsanbong.DataSource = dataTable; // Hiển thị dữ liệu lên DataGridView


                dataGridView_danhsachsanbong.Columns["id"].HeaderText = "Mã Sân bóng";
                dataGridView_danhsachsanbong.Columns["TenSan"].HeaderText = "Tên Sân bóng";
                dataGridView_danhsachsanbong.Columns["DiaChi"].HeaderText = "Địa chỉ ";
                dataGridView_danhsachsanbong.Columns["GiaThue"].HeaderText = "Giá Sân bóng";
                dataGridView_danhsachsanbong.Columns["TrangThai"].HeaderText = " Tình Trạng";
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

        private void button_them_Click(object sender, EventArgs e)
        {
            /*string connect = "server=127.0.0.1;user=root; database=quanlysanbong; password=";
            string query = "INSERT INTO sanbong(TenSan,DiaChi,GiaThue,TrangThai) VALUES (@TenSan,@DiaChi,@GiaThue,@TrangThai)";

            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                MySqlCommand mySqlCommand = new MySqlCommand(query, connection);

                mySqlCommand.Parameters.AddWithValue("@GiaThue", );
            }*/



        }

        private void dataGridView_danhsachsanbong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView_danhsachsanbong.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                int id;
                id = int.Parse(dataGridView_danhsachsanbong.Rows[e.RowIndex].Cells[0].Value.ToString());
                textBox_tensan.Text = dataGridView_danhsachsanbong.Rows[e.RowIndex].Cells[1].Value.ToString();
                textBox_Diachi.Text = dataGridView_danhsachsanbong.Rows[e.RowIndex].Cells[2].Value.ToString();
                textBox_Giathue.Text = dataGridView_danhsachsanbong.Rows[e.RowIndex].Cells[3].Value.ToString();
                comboBox_TrangThai.Text = dataGridView_danhsachsanbong.Rows[e.RowIndex].Cells[4].Value.ToString();


            }


            var row = dataGridView_danhsachsanbong.CurrentRow;
            if (row != null)
            {
                //lấy dữ liệu
                var id = row.Cells[0].Value.ToString();
                var TenSan = row.Cells[1].Value.ToString();
                var DiaChi = row.Cells[2].Value;
                var GiaThue = row.Cells[3].Value;
                var trangthai = row.Cells[4].Value;
                MessageBox.Show(id + TenSan + DiaChi + GiaThue + trangthai.ToString());
            }

        }

 /*       public event Action DataUpdated;*/

        private void button_sua_Click(object sender, EventArgs e)
        {
            int selectrowIndex = dataGridView_danhsachsanbong.SelectedRows[0].Index;
            int id = Convert.ToInt32(dataGridView_danhsachsanbong.SelectedRows[0].Cells["id"].Value);
            string tensan = textBox_tensan.Text;
            string diachi = textBox_Diachi.Text;
            decimal giathue;
            if (!decimal.TryParse(textBox_Giathue.Text, out giathue))
            {
                MessageBox.Show("làm ơn nhập vào giá thuế.");
                return;
            }
            string trangthai = comboBox_TrangThai.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tensan) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(trangthai))
            {
                MessageBox.Show("Vui lòng điền vào tất cả các trường.");
                return;
            }
            if (MessageBox.Show("bạn có chắc muốn sửa không?", "xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection conn = new MySqlConnection(connect))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE sanbong SET TenSan = @TenSan, DiaChi = @DiaChi, GiaThue = @GiaThue, TrangThai = @TrangThai WHERE id = @Id";
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Id", id);
                            cmd.Parameters.AddWithValue("@TenSan", tensan);
                            cmd.Parameters.AddWithValue("@DiaChi", diachi);
                            cmd.Parameters.AddWithValue("@GiaThue", giathue);
                            cmd.Parameters.AddWithValue("@TrangThai", trangthai);
                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Đã Sửa thuộc tính thành công!");
                                LoadData();
                           /*     DataUpdated?.Invoke();*/
                            }
                            else
                            {
                                MessageBox.Show("khong Sửa thuộc tính thành công!");
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



        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView_danhsachsanbong.Rows.Count > 0)
            {
                int selectrowIndex = dataGridView_danhsachsanbong.SelectedRows[0].Index;
                int id = Convert.ToInt32(dataGridView_danhsachsanbong.SelectedRows[0].Cells["id"].Value);
                if (MessageBox.Show("bạn có chắc muốn xóa không?", "xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    using (MySqlConnection conn = new MySqlConnection(connect))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM sanbong WHERE id = @Id";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@Id", id);

                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Đã xóa thuộc tính thành công!");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("khong xóa thuộc tính thành công!");
                            }
                            cmd.ExecuteNonQuery();
                            conn.Close();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi:" + ex.Message);
                        }
                    }
                }
            }

        }

        private void LoadData()
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT id, TenSan, DiaChi, GiaThue, TrangThai FROM sanbong";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView_danhsachsanbong.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }

        private void button_datsan_Click(object sender, EventArgs e)
        {
            string tensan = textBox_tensan.Text;
            string diachi = textBox_Diachi.Text;
            decimal giathue;

            string trangthai = comboBox_TrangThai.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(tensan) || string.IsNullOrEmpty(diachi) || string.IsNullOrEmpty(trangthai))
            {
                MessageBox.Show("Vui lòng điền vào tất cả các trường.");
                return;
            }
            if (!decimal.TryParse(textBox_Giathue.Text, out giathue))
            {
                MessageBox.Show("làm ơn nhập vào giá thuế.");
                return;
            }


            if (trangthai == "thuê" || trangthai == "đang bảo trì")
            {
                MessageBox.Show("sân hiện tại đang bị thuê hoặc đang bảo trì.");
                return;
            }
            AddSanBong(tensan, diachi, giathue, trangthai);

        }
        private void AddSanBong(string tenSan, string diaChi, decimal giaThue, string trangThai)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                string query = "INSERT INTO sanbong (TenSan, DiaChi, GiaThue, TrangThai) VALUES (@TenSan, @DiaChi, @GiaThue, @TrangThai)";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@TenSan", tenSan);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@GiaThue", giaThue);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Sân bóng đã được thêm thành công.");
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                    }
                }
            }
        }
        private void button_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_taikhoan_Click(object sender, EventArgs e)
        {
            /*  FromThongtin_Tk fromThongtin_Tk = new FromThongtin_Tk();
              fromThongtin_Tk.Show();
              this.Hide();*/
        }



        private void button_linkdatsan_Click(object sender, EventArgs e)
        {
            /*Dat_san dat_San = new Dat_san();
            dat_San.Show();
            this.Hide();*/
        }

        private void button_xemgiadatsan_Click(object sender, EventArgs e)
        {
            /*Formgiasan formgiasan = new Formgiasan();
            formgiasan.Show();
            this.Hide();*/
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            textBox_tensan.Text = string.Empty;
            textBox_Diachi.Text = string.Empty;
            textBox_Giathue.Text = string.Empty;
            comboBox_TrangThai.SelectedIndex = 0;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string TenSan = txt_tensan.Text.Trim();

            if (!string.IsNullOrEmpty(TenSan))
            {
                SearchTebSanInfo(TenSan);
            }
            else
            {
                MessageBox.Show("làm ơn nhập đúng tên.");
            }
        }

        private void SearchTebSanInfo(string tenSan)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                string query = "SELECT * FROM sanbong WHERE TenSan LIKE  @TenSan";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@tenSan", "%" + tenSan + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        dataGridView_danhsachsanbong.DataSource = dataTable;
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