using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraTab;
using System.IO;
using Model.Dao;
using Microsoft.WindowsAPICodePack.Dialogs;
namespace QL_CuocDT_WF
{
    public partial class IndexForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public IndexForm()
        {
            InitializeComponent();
        }
        private void AddTabControl(UserControl userControl, string itemTabName, string icon)
        {
            bool isExist = false;
            foreach (XtraTabPage tabItem in Tab.TabPages)
            {
                if (tabItem.Text == itemTabName)
                {
                    isExist = true;
                    Tab.SelectedTabPage = tabItem;
                }
            }
            if (isExist == false)
            {
                AddTab addTab = new AddTab();
                addTab.AddTabControl(Tab, itemTabName, icon, userControl);
            }
        }
        private void KH_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_KH form = new UC_KH();
            AddTabControl(form, "Quản Lý Khách Hàng", "");
        }

        private void tabNavigationPage2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tab_Click(object sender, EventArgs e)
        {

        }

        private void Tab_CloseButtonClick(object sender, EventArgs e)
        {
            Tab.TabPages.RemoveAt(Tab.SelectedTabPageIndex);
            Tab.SelectedTabPageIndex = Tab.TabPages.Count - 1;
        }

        private void Tab_ControlAdded(object sender, ControlEventArgs e)
        {
            Tab.SelectedTabPageIndex = Tab.TabPages.Count - 1;
        }

        private void Sim_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_Sim f = new UC_Sim();
            AddTabControl(f, "Quản Lý Sim", "");
        }

        private void GiaCuoc_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_LoaiCuoc f = new UC_LoaiCuoc();
            AddTabControl(f, "Quản Lý Cước", "");
        }

        private void LSGoi_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_CuocGoi f = new UC_CuocGoi();
            AddTabControl(f, "Danh Sách Cuộc Gọi", "");
        }

        private void HDDK_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_HDDK f = new UC_HDDK();
            AddTabControl(f, "Danh Sách Hóa Đơn Đăng Ký", "");
        }

        private void HDTT_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            UC_HDTT f = new UC_HDTT();
            AddTabControl(f, "Danh Sách Hóa Đơn Thanh Toán", "");
        }

        private void Random_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            try
            {
                CommonOpenFileDialog dialog = new CommonOpenFileDialog();
                dialog.IsFolderPicker = true;
                if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
                {
                    string fileName = dialog.FileName;
                    XuLyFile xl = new XuLyFile();
                    xl.taofile(fileName);
                    MessageBox.Show("Tạo File Thành Công");
                }              
            }
                
            catch(Exception ex)
            {
                MessageBox.Show("Đã Có Lỗi xảy ra");
            }
        }

        private void Import_Button_ItemClick(object sender, ItemClickEventArgs e)
        {
            var FD = new System.Windows.Forms.OpenFileDialog();
            if (FD.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileToOpen = FD.FileName;
                if (MessageBox.Show("Bạn có Chắc Muốn Thêm Dữ liệu Vào Không", "Thêm Dữ Liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    XuLyFile xl = new XuLyFile();
                    var result=xl.insertDB(fileToOpen);
                    if (result == 1)
                    {
                        MessageBox.Show("Thêm Thành Công");
                    }
                    else if (result == -1)
                    {
                        MessageBox.Show("File không đúng định dạng");
                    }
                    else
                    {
                        MessageBox.Show("File Đã Được Thêm Rồi");
                    }
                }
                
            }
            
        }
    }
}