using iTextSharp.text.pdf;
using iTextSharp.text;
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
    public partial class FormPDF : Form
    {
        private string connect = "server=127.0.0.1;user=root; database=quan_ly_san_bong; password=";

        public FormPDF()
        {
            InitializeComponent();
            LoadInvoiceData();
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
                dgv_PDF.DataSource = dataTable;
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

                
                   

            PdfPTable pdfTable = new PdfPTable(dgv_PDF.Columns.Count);
                   

            // Add table headers
            foreach (DataGridViewColumn column in dgv_PDF.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, FontFactory.GetFont("Arial Unicode MS", 12, BaseColor.WHITE)));
                cell.BackgroundColor = BaseColor.GRAY;
                pdfTable.AddCell(cell);
            }

            // Add table rows
            foreach (DataGridViewRow row in dgv_PDF.Rows)
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
