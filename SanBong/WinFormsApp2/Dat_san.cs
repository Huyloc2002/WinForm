using iTextSharp.text.pdf;
using iTextSharp.text;
using Microsoft.IdentityModel.Tokens;
using Microsoft.SqlServer.Management.Smo;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace WinFormsApp2
{
    public partial class Dat_san : Form
    {
        private string connect = "server=127.0.0.1;user=root; database=quan_ly_san_bong; password=";
        public Dat_san()
        {
            InitializeComponent();
            LoadInvoiceData();


        }




        private void btn_datsan_Click(object sender, EventArgs e)
        {

            string khachhangId = ten_khach_hang.SelectedValue.ToString();
            string sanBongId = ten_san_bong.SelectedValue.ToString();

            string ngay_dat = ngay_dat_san.Value.ToString("yyyy-MM-dd");
            string gio_batdau = gio_bat_dau.Value.ToString("HH:mm:ss");
            string gio_ketthuc = gio_ket_thuc.Value.ToString("HH:mm:ss");
            string tongtien = tong_tien.Text;


            using (MySqlConnection connection = new MySqlConnection(connect))
            {
                connection.Open();
                string query = "INSERT INTO phieu_dat_san (khach_hang_id, id, ngay_dat, gio_bat_dau, gio_ket_thuc, tong_tien) " +
                               "VALUES (@khachHangId, @sanBongId, @ngay_dat, @gio_batdau, @gio_ketthuc, @tongtien)";
                using (MySqlCommand cmd = new MySqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@khachhangId", khachhangId);
                    cmd.Parameters.AddWithValue("@sanBongId", sanBongId);
                    cmd.Parameters.AddWithValue("@ngay_dat", ngay_dat);
                    cmd.Parameters.AddWithValue("@gio_batdau", gio_batdau);
                    cmd.Parameters.AddWithValue("@gio_ketthuc", gio_ketthuc);
                    cmd.Parameters.AddWithValue("@tongtien", tongtien);

                    int row = cmd.ExecuteNonQuery();
                    if (row > 0)
                    {
                        MessageBox.Show("Đã thêm Thông tin thành công!");
                        LoadData();

                    }
                    else
                    {
                        MessageBox.Show("khong thêm Thông tin thành công!");
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
                    string query = "SELECT  pds.phieu_id,kh.ho_ten AS ten_khach_hang, sb.TenSan AS ten_san_bong,pds.ngay_dat, pds.gio_bat_dau, pds.gio_ket_thuc,pds.tong_tien FROM  phieu_dat_san pds  INNER JOIN khach_hang kh ON pds.khach_hang_id = kh.khach_hang_id  INNER JOIN sanbong sb ON pds.id = sb.id;";
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        danhsacch_datsan.DataSource = dt;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading data: " + ex.Message);
                }
            }
            // Load khách hàng vào ComboBox
            string queryKhachHang = "SELECT khach_hang_id, ho_ten FROM khach_hang";
            // Load sân bóng vào ComboBox
            string querySanBong = "SELECT id, TenSan FROM sanbong";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(queryKhachHang, connection);
                    DataTable dtKhachHang = new DataTable();
                    adapter.Fill(dtKhachHang);

                    ten_khach_hang.DataSource = dtKhachHang;
                    ten_khach_hang.DisplayMember = "ho_ten";
                    ten_khach_hang.ValueMember = "khach_hang_id";

                    adapter.SelectCommand.CommandText = querySanBong;
                    DataTable dtSanBong = new DataTable();
                    adapter.Fill(dtSanBong);
                    ten_san_bong.DataSource = dtSanBong;
                    ten_san_bong.DisplayMember = "TenSan";
                    ten_san_bong.ValueMember = "id";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }


        }

        private void btn_trangchu_Click(object sender, EventArgs e)
        {
            FormMain frmMain = new FormMain();
            frmMain.Show();
            this.Hide();
        }
        private void UpdateLabelColors(string tensanbong)
        {


            label_san1.ForeColor = Color.Black;

            label_san2.ForeColor = Color.Black;
            label_san3.ForeColor = Color.Black;
            label_san4.ForeColor = Color.Black;
            label_san5.ForeColor = Color.Black;
            label_san6.ForeColor = Color.Black;
            switch (tensanbong.ToLower())
            {
                case "san 1":
                    label_san1.ForeColor = Color.Red;
                    break;
                case "san 2":
                    label_san2.ForeColor = Color.Red;
                    break;
                case "san 3":
                    label_san3.ForeColor = Color.Red;
                    break;
                case "san 4":
                    label_san4.ForeColor = Color.Red;
                    break;
                case "san 5":
                    label_san5.ForeColor = Color.Red;
                    break;
                case "san 6":
                    label_san6.ForeColor = Color.Red;
                    break;
                default:
                    /*  label_san7.ForeColor = Color.Black; // Màu đen mặc định
                      label_san8.ForeColor = Color.Black;
                      label_san9.ForeColor = Color.Black;
                      label_san10.ForeColor = Color.Black;
                      label_san11.ForeColor = Color.Black;*/
                    break;
            }

        }
        private void ten_san_bong_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tensanbong = ten_san_bong.Text.Trim();
            UpdateLabelColors(tensanbong);


        }



        private void btn_Trasan_Click(object sender, EventArgs e)
        {
            if (danhsacch_datsan.Rows.Count > 0)
            {
                int selectrowIndex = danhsacch_datsan.SelectedRows[0].Index;
                int phieu_id = Convert.ToInt32(danhsacch_datsan.SelectedRows[0].Cells["phieu_id"].Value);
                if (MessageBox.Show("bạn có chắc muốn Trả không?", "xác nhận Trả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {



                    using (MySqlConnection conn = new MySqlConnection(connect))
                    {
                        try
                        {
                            conn.Open();
                            string query = "DELETE FROM phieu_dat_san WHERE phieu_id = @PhieuId";
                            MySqlCommand cmd = new MySqlCommand(query, conn);
                            cmd.Parameters.AddWithValue("@PhieuId", phieu_id);

                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Đã Trả Sân thành công!");
                                LoadData();
                            }
                            else
                            {
                                MessageBox.Show("khong Trả sân thành công!");
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

        private void danhsacch_datsan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (danhsacch_datsan.Rows[e.RowIndex].Cells[e.RowIndex].Value != null)
            {
                int id;
                id = int.Parse(danhsacch_datsan.Rows[e.RowIndex].Cells[0].Value.ToString());
                ten_khach_hang.Text = danhsacch_datsan.Rows[e.RowIndex].Cells[1].Value.ToString();
                ten_san_bong.Text = danhsacch_datsan.Rows[e.RowIndex].Cells[2].Value.ToString();

                ngay_dat_san.Text = danhsacch_datsan.Rows[e.RowIndex].Cells[3].Value.ToString();
                gio_bat_dau.Text = danhsacch_datsan.Rows[e.RowIndex].Cells[4].Value.ToString();
                gio_ket_thuc.Text = danhsacch_datsan.Rows[e.RowIndex].Cells[5].Value.ToString();
                tong_tien.Text = danhsacch_datsan.Rows[e.RowIndex].Cells[6].Value.ToString();


            }






            /* var row = danhsacch_datsan.CurrentRow;
             if (row != null)
             {
                 //lấy dữ liệu
                 var phieu_id = row.Cells[0].Value.ToString();
                 var KhachhangId = row.Cells[1].Value.ToString();
                 var id = row.Cells[2].Value;
                 var ngay_dat = (DateTime)row.Cells[3].Value;
                 var gio_batdau = row.Cells[4].Value;
                 var gio_ketthuc = row.Cells[5].Value;
                 var tongtien = row.Cells[6].Value;


                 MessageBox.Show(phieu_id + KhachhangId + id + ngay_dat + gio_batdau + gio_ketthuc + tongtien.ToString());
             }*/
        }

        private void btn_suasan_Click(object sender, EventArgs e)
        {
            int selectrowIndex = danhsacch_datsan.SelectedRows[0].Index;
            int phieu_id = Convert.ToInt32(danhsacch_datsan.SelectedRows[0].Cells["phieu_id"].Value);

            string khachhangId = ten_khach_hang.SelectedValue.ToString();
            string sanBongId = ten_san_bong.SelectedValue.ToString();

            string ngay_dat = ngay_dat_san.Value.ToString("yyyy-MM-dd");
            string gio_batdau = gio_bat_dau.Value.ToString("HH:mm:ss");
            string gio_ketthuc = gio_ket_thuc.Value.ToString("HH:mm:ss");
            string tongtien = tong_tien.Text;

            if (MessageBox.Show("bạn có chắc muốn sửa không?", "xác nhận sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                using (MySqlConnection connection = new MySqlConnection(connect))
                {
                    try
                    {
                        connection.Open();
                        string query = "UPDATE phieu_dat_san SET khach_hang_id = @khachhangId, id = @sanBongId, ngay_dat = @ngay_dat, gio_bat_dau = @gio_batdau, gio_ket_thuc = @gio_ketthuc, tong_tien = @tongtien WHERE phieu_id = @phieu_id";
                        using (MySqlCommand cmd = new MySqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("@khachhangId", khachhangId);
                            cmd.Parameters.AddWithValue("@sanBongId", sanBongId);
                            cmd.Parameters.AddWithValue("@ngay_dat", ngay_dat);
                            cmd.Parameters.AddWithValue("@gio_batdau", gio_batdau);
                            cmd.Parameters.AddWithValue("@gio_ketthuc", gio_ketthuc);
                            cmd.Parameters.AddWithValue("@tongtien", tongtien);
                            cmd.Parameters.AddWithValue("@phieu_id", phieu_id);


                            int row = cmd.ExecuteNonQuery();
                            if (row > 0)
                            {
                                MessageBox.Show("Đã Sửa Sân thành công!");
                                LoadData();

                            }
                            else
                            {
                                MessageBox.Show("khong Sửa Sân thành công!");
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






        private void btn_Cancel_Click_1(object sender, EventArgs e)
        {

            ten_khach_hang.SelectedIndex = 0;
            ten_san_bong.SelectedIndex = 0;
            ngay_dat_san.Value = DateTime.Now;
            gio_bat_dau.Value = DateTime.Now;
            gio_ket_thuc.Value = DateTime.Now;
            tong_tien.Text = string.Empty;
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string hoTen = textBox_tẹnkhachhang.Text.Trim();
            if (!string.IsNullOrEmpty(hoTen))
            {
                SearchByHoTen(hoTen);
            }
            else
            {
                MessageBox.Show("Vui lòng nhập họ tên của khách hàng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void SearchByHoTen(string hoTen)
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {
                string query = @"
                SELECT kh.khach_hang_id, kh.ho_ten, kh.email, kh.so_dien_thoai, kh.dia_chi,
                       pd.phieu_id, pd.ngay_dat, pd.gio_bat_dau, pd.gio_ket_thuc, pd.tong_tien
                FROM khach_hang kh
                LEFT JOIN phieu_dat_san pd ON kh.khach_hang_id = pd.khach_hang_id
                WHERE kh.ho_ten LIKE @hoTen";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@hoTen", "%" + hoTen + "%");
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();

                    try
                    {
                        conn.Open();
                        adapter.Fill(dataTable);
                        danhsacch_datsan.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi" + ex.Message);
                    }
                }

            }
        }

     

        private void Dat_san_Load(object sender, EventArgs e)
        {
            MySqlConnection mySqlConnection = new MySqlConnection(connect);
            try
            {
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("SHOW TABLES;", mySqlConnection);
                MySqlDataReader reader = mySqlCommand.ExecuteReader();
                /*MessageBox.Show("connect success");*/
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
                string query = "SELECT  pds.phieu_id,kh.ho_ten AS ten_khach_hang, sb.TenSan AS ten_san_bong,pds.ngay_dat, pds.gio_bat_dau, pds.gio_ket_thuc,pds.tong_tien  FROM  phieu_dat_san pds  INNER JOIN khach_hang kh ON pds.khach_hang_id = kh.khach_hang_id  INNER JOIN sanbong sb ON pds.id = sb.id;";
                MySqlCommand command = new MySqlCommand(query, mySqlConnection);

                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                LoadData();
                danhsacch_datsan.DataSource = dataTable; // Hiển thị dữ liệu lên DataGridView

                danhsacch_datsan.Columns["phieu_id"].HeaderText = "Mã phiếu";
                danhsacch_datsan.Columns["ten_khach_hang"].HeaderText = "Tên khách hàng";
                danhsacch_datsan.Columns["ten_san_bong"].HeaderText = "Tên sân bóng";
                danhsacch_datsan.Columns["ngay_dat"].HeaderText = "Ngày đặt";
                danhsacch_datsan.Columns["gio_bat_dau"].HeaderText = "Giờ bắt đầu";
                danhsacch_datsan.Columns["gio_ket_thuc"].HeaderText = "Giờ kết thúc";
                danhsacch_datsan.Columns["tong_tien"].HeaderText = "Tổng tiền";

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

        private void btn_pdf_Click(object sender, EventArgs e)
        {

            ExportToPdf();
        }
        private void LoadInvoiceData()
        {
            using (MySqlConnection conn = new MySqlConnection(connect))
            {

                conn.Open();
                string query = "SELECT  pds.phieu_id AS Ma_phieu,kh.ho_ten AS ten_khach_hang, sb.TenSan AS ten_san_bong,pds.ngay_dat, pds.gio_bat_dau, pds.gio_ket_thuc,pds.tong_tien  FROM  phieu_dat_san pds  INNER JOIN khach_hang kh ON pds.khach_hang_id = kh.khach_hang_id  INNER JOIN sanbong sb ON pds.id = sb.id;";
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                danhsacch_datsan.DataSource = dataTable;
            }
        }

        private void ExportToPdf()
        {


            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.Title = "Save an Invoice File";
            saveFileDialog.ShowDialog();

            if (saveFileDialog.FileName != "")
            {
                using (FileStream stream = new FileStream(saveFileDialog.FileName, FileMode.Create))
                {
                    Document document = new Document(PageSize.A3);
                    PdfWriter.GetInstance(document, stream);
                    document.Open();




                    PdfPTable pdfTable = new PdfPTable(danhsacch_datsan.Columns.Count);


                    // Add table headers
                    foreach (DataGridViewColumn column in danhsacch_datsan.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont("Arial Unicode MS", 12, BaseColor.WHITE)));
                        cell.BackgroundColor = BaseColor.GRAY;
                        pdfTable.AddCell(cell);
                    }

                    // Add table rows
                    foreach (DataGridViewRow row in danhsacch_datsan.Rows)
                    {
                        if (row.IsNewRow) continue;
                        /* foreach (DataGridViewCell cell in row.Cells)
                         {
                             pdfTable.AddCell(cell.Value?.ToString() ?? string.Empty);
                         }*/
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            string cellValue = cell.Value?.ToString() ?? string.Empty;

                            // Format date if the cell contains a date
                            if (cell.OwningColumn.Name.Contains("Date"))
                            {
                                if (DateTime.TryParse(cellValue, out DateTime dateValue))
                                {
                                    cellValue = dateValue.ToString("dd/MM/yyyy"); // Example format: 10/09/2024
                                }
                            }

                            pdfTable.AddCell(new Phrase(cellValue, FontFactory.GetFont("Arial Unicode MS", 10)));
                        }

                    }

                    document.Add(pdfTable);
                    document.Close();
                }

                MessageBox.Show("PDF exported successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
