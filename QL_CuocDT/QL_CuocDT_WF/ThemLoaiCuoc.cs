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
    public partial class ThemLoaiCuoc : DevExpress.XtraEditors.XtraForm
    {
        public UC_LoaiCuoc uc;
        public ThemLoaiCuoc(UC_LoaiCuoc uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean kiemtra(string giacuoc)
        {
            float output;
            return float.TryParse(giacuoc, out output);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           try
            {
                if(txt_GiaCuoc.Text=="")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin!");
                }
                else
                {
                    if (kiemtra(txt_GiaCuoc.Text) == true)
                    {
                        LoaiCuocDao lc = new LoaiCuocDao();
                        lc.ThemLoaiCuoc(txt_TGBD.Text, txt_TGKT.Text, txt_GiaCuoc.Text);
                        MessageBox.Show("Thêm Thành Công!");
                    }
                    else MessageBox.Show("Giá Cước Phải là số");
                }
                uc.refresh();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Đã có lỗi xảy ra!");
            }
        }

        private void txt_TGBD_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void timeSpanEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void timeEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}