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
using System.Data.Entity;

namespace QL_CuocDT_WF
{
    public partial class ThemHDDK : DevExpress.XtraEditors.XtraForm
    {
        public string MaKH;
        public string TenKH;
        public string MaSim;
        public string SoSim;
        public UC_HDDK uc;
        public ThemHDDK(UC_HDDK uc)
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
                if(txt_TenKH.Text==""||txt_SoSim.Text==""||txt_ChiPhi.Text==""||txt_MaSim.Text==""||txt_MaKH.Text=="")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin!");
                }
                else
                {
                    HoaDonDangKyDao hd = new HoaDonDangKyDao();
                    hd.Them(txt_MaKH.Text, txt_MaSim.Text, txt_TGDK.Text, txt_ChiPhi.Text);
                    MessageBox.Show("Thêm Thành Công!");
                }
                uc.refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }

        internal void popup2()
        {
            txt_MaSim.Text = MaSim;
            txt_SoSim.Text = SoSim;
        }

        internal void popup()
        {
            txt_MaKH.Text = MaKH;
            txt_TenKH.Text = TenKH;
        }

        private void txt_TenKH_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txt_TGDK_Load(object sender, EventArgs e)
        {

        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void bt_searchKH_Click(object sender, EventArgs e)
        {
            ThongTinKhachHang f = new ThongTinKhachHang(this,null);
            f.Show();
        }

        private void khachHangsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bt_searchSim_Click(object sender, EventArgs e)
        {
            ThongTinSim f = new ThongTinSim(this,null);
            f.Show();
        }

        private void txt_TGDK_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}