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
    public partial class UC_HDTT : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_HDTT()
        {
            InitializeComponent();
            HoaDonThanhToanDao hd = new HoaDonThanhToanDao();
            hoaDonThanhToansBindingSource.DataSource = hd.load();
            if (txt_TT.Text == "") bt_Sua.Enabled = false;
            
        }

        private void grid_KH_Click(object sender, EventArgs e)
        {
            HoaDonThanhToanDao hd = new HoaDonThanhToanDao();
            txt_MaHD.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaHD").ToString();
            txt_SoSim.Text =hd.timsosim(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSim").ToString());
            txt_TenKH.Text = hd.timtenkh(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString());
            txt_TGTHD.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TG_TaoHoaDon").ToString();
            txt_CTB.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "CuocThueBao").ToString();
            txt_TT.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ThanhTien").ToString();
            if (gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "ThanhToan").Equals(false))
            {
                txt_trangthai.Text = "Chưa Thanh Toán";
            }
            else
            {
                txt_trangthai.Text = "Đã Thanh Toán";
            }
            bt_Sua.Enabled = true;
        }

        private void khachHangsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void khachHangsBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            HoaDonThanhToanDao hd = new HoaDonThanhToanDao();
            var lst=hd.themhd();
            foreach(var item in lst)
            {
                hd.them(item);
            }
            this.refresh();
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_TT.Text == "Đã Thanh Toán") MessageBox.Show("Hóa đơn đã thanh toán từ trước");
                else if(txt_TT.Text=="Chưa Thanh Toán")
                {
                    HoaDonThanhToanDao hd = new HoaDonThanhToanDao();
                    hd.thanhtoan(txt_MaHD.Text);
                    MessageBox.Show("Thanh Toán Thành Công");
                }
                this.refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Chọn hóa đơn cần thanh toán");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            HoaDonThanhToanDao hd = new HoaDonThanhToanDao();
            hoaDonThanhToansBindingSource.DataSource = hd.load();
        }
        public void refresh()
        {
            HoaDonThanhToanDao hd = new HoaDonThanhToanDao();
            hoaDonThanhToansBindingSource.DataSource = hd.load();
        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự muốn xóa?","Xóa Khách Hàng",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                HoaDonThanhToanDao hd = new HoaDonThanhToanDao();
                hd.xoa(txt_MaHD.Text);
                MessageBox.Show("xóa thành công");
                this.refresh();
            }
            
        }

        private void labelControl4_Click(object sender, EventArgs e)
        {

        }

        private void groupControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }
    }
}
