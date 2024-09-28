using Mysqlx.Cursor;
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
    public partial class Dasdboash : Form
    {
        public Dasdboash()
        {
            InitializeComponent();
        }


        private void Dasdboash_Load(object sender, EventArgs e)
        {

        }
        private bool CheckExistForm(string formName)
        {
            foreach (var form in this.MdiChildren)
            {
                if (form.Name == formName) return true;
            }
            return false;
        }

        private void Menutrangchu_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FormMain"))
            {
                FormMain formMain = new FormMain();
                formMain.MdiParent = this;
                formMain.Name = "FormMain"; // Đặt tên để kiểm tra trong CheckExistForm.
                formMain.Show();
            }
            else
            {
                // Nếu formMain đã mở, chọn form đó để đưa nó lên trên.
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FormMain")
                    {
                        form.BringToFront();
                        break;
                    }
                }
            }

        }

        private void MenuDatsan_Click(object sender, EventArgs e)
        {

            if (!CheckExistForm("Dat_san"))
            {
                Dat_san formDat_san = new Dat_san();
                formDat_san.MdiParent = this;
                formDat_san.Name = "Dat_san";
                formDat_san.Show();

            }
            else
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "Dat_san")
                    {
                        form.BringToFront();
                        break;
                    }
                }
            }


        }

        private void Menutaikhoan_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("FromThongtin_Tk"))
            {
                FromThongtin_Tk formtk = new FromThongtin_Tk();
                formtk.MdiParent = this;
                formtk.Name = "FromThongtin_Tk";
                formtk.Show();
            }
            else
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FromThongtin_Tk")
                    {
                        form.BringToFront();
                        break;
                    }
                }
            }



        }

        private void giasan_Click(object sender, EventArgs e)
        {

            if (!CheckExistForm("Formgiasan"))
            {
                Formgiasan formgiasan = new Formgiasan();
                formgiasan.MdiParent = this;
                formgiasan.Name = "Formgiasan";
                formgiasan.Show();

            }
            else
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "Formgiasan")
                    {
                        form.BringToFront();
                        break;
                    }
                }
            }


        }

        private void menuKháchHàng_Click(object sender, EventArgs e)
        {
            if(!CheckExistForm("FormKhachHang"))
            {
                FormKhachHang formKhachHang = new FormKhachHang();
                formKhachHang.MdiParent = this;
                formKhachHang.Name = "FormKhachHang";
                formKhachHang.Show();
            }    
            else
            {
                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FormKhachHang")
                    {
                        form.BringToFront();
                        break;
                    }
                }
            }    
     
        }

        private void DoanhThu_Click(object sender, EventArgs e)
        {

            if(!CheckExistForm ( "FormDoanhthu"))
            {
                FormDoanhthu formDoanhthu = new FormDoanhthu();
                formDoanhthu.MdiParent = this;
                formDoanhthu.Name = "FormDoanhthu";
                formDoanhthu.Show();
            }

            else
            {

                foreach (Form form in this.MdiChildren)
                {
                    if (form.Name == "FormDoanhthu")
                    {
                        form.BringToFront();
                        break;
                    }
                }
            }
        }



        /* private void openForm(Form form)
         {
             form.Show();
             this.Hide();
         }*/
    }
}
