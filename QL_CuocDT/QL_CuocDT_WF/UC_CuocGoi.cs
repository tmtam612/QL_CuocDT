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
    public partial class UC_CuocGoi : DevExpress.XtraEditors.XtraUserControl
    {
        public UC_CuocGoi()
        {
            InitializeComponent();
            CuocGoiDao cs = new CuocGoiDao();
            var result = cs.Load();
            cuocGoisBindingSource.DataSource = result;
        }

        private void grid_KH_Click(object sender, EventArgs e)
        {
            HoaDonDangKyDao hdk = new HoaDonDangKyDao();
            txt_MaCuocGoi.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaCuocGoi").ToString();
            txt_MaSim.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSim").ToString();
            txt_SoSim.Text = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "Sim.SoSim").ToString();
            txt_TGBD.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TG_BatDau").ToString();
            txt_TGKT.Text= gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TG_KetThuc").ToString();
            txt_SPSD.Text=gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoPhutSD").ToString();
        }

        private void khachHangsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void khachHangsBindingSource_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            
            
        }

        private void cuocGoisBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit3_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void UC_CuocGoi_Load(object sender, EventArgs e)
        {

        }

        private void textEdit1_TextChanged(object sender, EventArgs e)
        {
            gridView1.FindFilterText = textEdit1.Text;
        }
    }
}
