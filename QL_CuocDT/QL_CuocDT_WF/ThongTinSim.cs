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
    public partial class ThongTinSim : DevExpress.XtraEditors.XtraForm
    {
        ThemHDDK formout;
        SuaHDDK formout2;
        public ThongTinSim(ThemHDDK themHDDK,SuaHDDK suaHDDK)
        {
            InitializeComponent();
            if (suaHDDK == null)
            {
                formout = themHDDK;
                SimDao s = new SimDao();
                var result = s.Load();
                simsBindingSource.DataSource = result;
            }
            if (themHDDK == null)
            {
                formout2 = suaHDDK;
                SimDao s = new SimDao();
                var result = s.Load();
                simsBindingSource.DataSource = result;
            }
            
           

            
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            try
            {
                if (formout2 == null)
                {
                    formout.MaSim = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSim").ToString();
                    formout.SoSim = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoSim").ToString();
                    formout.popup2();
                    this.Close();
                }
                if (formout == null)
                {
                    formout2.MaSim = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MaSim").ToString();
                    formout2.SoSim = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "SoSim").ToString();
                    formout2.popup2();
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã Có lỗi xảy ra");
            }
            
        }
    }
}