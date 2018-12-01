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
    public partial class SuaHDDK : DevExpress.XtraEditors.XtraForm
    {
        public string MaKH;
        public string TenKH;
        public string MaSim;
        public string SoSim;
        public SuaHDDK(string a,string b,string c,string d,string e,string f, string g)
        {
            DateTime x = Convert.ToDateTime(f);
            InitializeComponent();
            txt_MaKH.Text = b;
            txt_TenKH.Text = c;
            txt_MaHD.Text = a;
            txt_MaSim.Text = d;
            txt_SoSim.Text = e;
            txt_TGDK.Value = x;
            txt_ChiPhi.Text = g;

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
                    hd.sua(txt_MaHD.Text,txt_MaKH.Text,txt_MaSim.Text,txt_TGDK.Text,txt_ChiPhi.Text);
                    MessageBox.Show("Sửa Thành Công!");
                }
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
            ThongTinKhachHang f = new ThongTinKhachHang(null,this);
            f.Show();
        }

        private void khachHangsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bt_searchSim_Click(object sender, EventArgs e)
        {
            ThongTinSim f = new ThongTinSim(null,this);
            f.Show();
        }

        private void txt_TGDK_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}