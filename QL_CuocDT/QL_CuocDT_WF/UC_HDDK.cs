using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Model.Dao;
using Model.EF;
using System.Data.Entity;
namespace QL_CuocDT_WF
{
    public partial class UC_HDDK : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_HDDK()
        {
            InitializeComponent();
            HoaDonDangKyDao hd = new HoaDonDangKyDao();
            var result = hd.load();
            hoaDonDKsBindingSource.DataSource = result;
        }

        private void grid_KH_Click(object sender, EventArgs e)
        {
            HoaDonDangKyDao hd = new HoaDonDangKyDao();
            txt_MaHD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString();
            txt_SoSim.Text =hd.timsosim(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSim").ToString());
            txt_TenKH.Text = hd.timtenkh(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString());
            txt_TGDK.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TG_DangKy").ToString();
            txt_ChiPhi.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ChiPhi").ToString();
            txt_MaSim.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSim").ToString();
            txt_MaKH.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
        }

        private void khachHangsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void khachHangsBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            ThemHDDK f = new ThemHDDK(this);
            f.Show();
            this.refresh();
        }
        Boolean kiemtra(string sdt)
        {

            float output;
            return float.TryParse(sdt, out output);
        }
        public void refresh()
        {
            HoaDonDangKyDao hd = new HoaDonDangKyDao();
            hoaDonDKsBindingSource.DataSource = hd.load();
        }
        private void bt_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txt_MaHD.Text==""||txt_SoSim.Text==""||txt_TenKH.Text==""||txt_TGDK.Text==""||txt_ChiPhi.Text=="")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin");
                }
                else
                {
                    if (kiemtra(txt_MaSim.Text) == true && kiemtra(txt_MaKH.Text) == true)
                    {
                        HoaDonDangKyDao hd = new HoaDonDangKyDao();
                        hd.sua(txt_MaHD.Text, txt_MaKH.Text, txt_MaSim.Text, txt_TGDK.Text, txt_ChiPhi.Text);
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                    {
                        MessageBox.Show("Nhập đúng kiểu dữ liệu");
                    }
                }
                this.refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HoaDonDangKyDao hd = new HoaDonDangKyDao();
            var result = hd.load();
            hoaDonDKsBindingSource.DataSource = result;
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn xóa?","Xóa Khách Hàng",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                HoaDonDangKyDao hd = new HoaDonDangKyDao();
                hd.xoa(txt_MaHD.Text);
                MessageBox.Show("Xóa thành công");
                this.refresh();
            }
            
        }

        private void txt_MaSim_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                SimDao s = new SimDao();
                var temp = s.sdt(txt_MaSim.Text);
                if (temp == null)
                {
                    MessageBox.Show("Mã Sim Không Tồn Tại");
                    txt_MaSim.Text = "";
                    txt_SoSim.Text = "";
                }
                else
                {
                    txt_SoSim.Text = temp.SoSim;
                }
            }
        }

        private void txt_MaKH_Properties_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                KhachHangDao kh = new KhachHangDao();
                var temp = kh.tenKH(txt_MaKH.Text);
                if(temp==null)
                {
                    MessageBox.Show("Mã Khách Hàng không tồn tại");
                    txt_MaKH.Text = "";
                    txt_TenKH.Text = "";
                }
                else
                {
                    txt_TenKH.Text = temp.TenKH;
                }
            }
        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }
    }
}
