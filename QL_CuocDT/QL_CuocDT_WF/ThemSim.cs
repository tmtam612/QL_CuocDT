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
    public partial class ThemSim : DevExpress.XtraEditors.XtraForm
    {
        public UC_Sim uc;
        public ThemSim(UC_Sim uc)
        {
            InitializeComponent();
            this.uc = uc;
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        Boolean kiemtrasdt(string sdt)
        {
            
            float output;
            return float.TryParse(sdt, out output);
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
           try
            {
                if(txt_SoSim.Text=="")
                {
                    MessageBox.Show("Nhập đầy đủ thông tin!");
                }
                else
                {
                    if (kiemtrasdt(txt_SoSim.Text) != false)
                    {
                        SimDao s = new SimDao();
                        s.ThemSim(txt_SoSim.Text);
                        MessageBox.Show("Thêm Thành Công!");
                    }
                    else MessageBox.Show("Số Sim Phải Là Số");
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