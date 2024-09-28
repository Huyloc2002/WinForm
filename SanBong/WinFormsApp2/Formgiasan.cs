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
    public partial class Formgiasan : Form
    {
        private string connect = "server=127.0.0.1;user=root; database=quan_ly_san_bong; password=";
        public Formgiasan()
        {
            InitializeComponent();
        }

        private void Formgiasan_Load(object sender, EventArgs e)
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
                string query = "SELECT  TenSan, DiaChi, GiaThue FROM sanbong;";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                LoadData();
                dataGridView_giasan.DataSource = dataTable; // Hiển thị dữ liệu lên DataGridView
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
                    string query = "SELECT  TenSan, DiaChi, GiaThue FROM sanbong";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView_giasan.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
        }


      /*  // Update dữ liệu từ bên FormMain
        private FormMain _formMain;

        public Formgiasan(FormMain formMain)
        {
            InitializeComponent();
            _formMain = formMain;
            _formMain.DataUpdated += OnDataUpdated; // Subscribe to event
        }

        private void OnDataUpdated()
        {
            LoadData(); // Refresh data
        }*/


        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string giasan = txt_giasan.Text.Trim();

            if (!string.IsNullOrEmpty(giasan))
            {
                SearchTebSanInfo(giasan);
            }
            else
            {
                MessageBox.Show("làm ơn nhập đúng tên.");
            }
        }

        private void SearchTebSanInfo(string giasan)
        {
            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                string query = "SELECT * FROM sanbong WHERE GiaThue LIKE  @GiaThue";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@GiaThue", "%" + giasan + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        connection.Open();
                        adapter.Fill(dataTable);
                        dataGridView_giasan.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btn_refersh_Click(object sender, EventArgs e)
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT  TenSan, DiaChi, GiaThue FROM sanbong";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView_giasan.DataSource = dt;
                        MessageBox.Show("loading data  thành công: ");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("loading data không thành công: " + ex.Message);
                }
            }
        }
    }
}
