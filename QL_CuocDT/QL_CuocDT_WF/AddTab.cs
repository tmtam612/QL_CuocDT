﻿using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuocDT_WF
{
    class AddTab
    {
        
            public void AddTabControl(XtraTabControl xtraTabParent, string xtraItemName, string icon, UserControl userControl)
            {
                XtraTabPage xtraTabPage = new XtraTabPage();
                xtraTabPage.Name = "Test";
                xtraTabPage.Text = xtraItemName;
                // xtraTabPage.Image = Bitmap.FromFile(@"..\..\Resource\" + icon);//khong lam icon
                userControl.Dock = DockStyle.Fill;
                xtraTabPage.Controls.Add(userControl);
                xtraTabParent.TabPages.Add(xtraTabPage);

            }
        
    }
}
