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
using System.Data.Entity;
using Model.Dao;
namespace QL_CuocDT_WF
{
    public partial class ThongTinKhachHang : DevExpress.XtraEditors.XtraForm
    {
        ThemHDDK formout;
        SuaHDDK formout2;
        public ThongTinKhachHang(ThemHDDK themHDDK,SuaHDDK suaHDDK)
        {
            InitializeComponent();
            if (suaHDDK == null)
            {
                formout = themHDDK;
                KhachHangDao kh = new KhachHangDao();
                var result = kh.load();
                khachHangsBindingSource.DataSource = result;
            }
            if(themHDDK==null)
            {
                formout2 = suaHDDK;
                KhachHangDao kh = new KhachHangDao();
                var result = kh.load();
                khachHangsBindingSource.DataSource = result;
            }
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            if (formout2 == null)
            {
                formout.MaKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
                formout.TenKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKH").ToString();
                formout.popup();
                this.Close();
            }
            if(formout==null)
            {
                formout2.MaKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaKH").ToString();
                formout2.TenKH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TenKH").ToString();
                formout2.popup();
                this.Close();
            }
        }
    }
}