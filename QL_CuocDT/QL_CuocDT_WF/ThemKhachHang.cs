using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model.Dao;

namespace QL_CuocDT_WF
{
    public partial class ThemKhachHang : DevExpress.XtraEditors.XtraForm
    {
        public UC_KH uc;
        public ThemKhachHang(UC_KH uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           try
            {
                if(txt_TenKH.Text==""||txt_CMND.Text==""||txt_NgheNghiep.Text==""||txt_DiaChi.Text=="")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin!");
                }
                else
                {
                    KhachHangDao kh = new KhachHangDao();
                    kh.themkhachhang(txt_TenKH.Text, txt_CMND.Text, txt_NgheNghiep.Text, txt_DiaChi.Text);
                    MessageBox.Show("Thêm Thành Công!");
                }
                uc.refresh();

            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }
    }
}