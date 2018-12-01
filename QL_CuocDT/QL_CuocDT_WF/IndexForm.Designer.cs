namespace QL_CuocDT_WF
{
    partial class IndexForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IndexForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.KH_Button = new DevExpress.XtraBars.BarButtonItem();
            this.Sim_Button = new DevExpress.XtraBars.BarButtonItem();
            this.GiaCuoc_Button = new DevExpress.XtraBars.BarButtonItem();
            this.LSGoi_Button = new DevExpress.XtraBars.BarButtonItem();
            this.HDDK_Button = new DevExpress.XtraBars.BarButtonItem();
            this.HDTT_Button = new DevExpress.XtraBars.BarButtonItem();
            this.Random_Button = new DevExpress.XtraBars.BarButtonItem();
            this.Import_Button = new DevExpress.XtraBars.BarButtonItem();
            this.QL_Page = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.Tab = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).BeginInit();
            this.Tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ColorScheme = DevExpress.XtraBars.Ribbon.RibbonControlColorScheme.Green;
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.KH_Button,
            this.Sim_Button,
            this.GiaCuoc_Button,
            this.LSGoi_Button,
            this.HDDK_Button,
            this.HDTT_Button,
            this.Random_Button,
            this.Import_Button});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.QL_Page,
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(905, 143);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // KH_Button
            // 
            this.KH_Button.Caption = "Khách Hàng";
            this.KH_Button.Id = 1;
            this.KH_Button.ImageOptions.DisabledSvgImageSize = new System.Drawing.Size(100, 100);
            this.KH_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("KH_Button.ImageOptions.Image")));
            this.KH_Button.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("KH_Button.ImageOptions.LargeImage")));
            this.KH_Button.LargeWidth = 100;
            this.KH_Button.Name = "KH_Button";
            this.KH_Button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.KH_Button_ItemClick);
            // 
            // Sim_Button
            // 
            this.Sim_Button.Caption = "Sim";
            this.Sim_Button.Id = 3;
            this.Sim_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Sim_Button.ImageOptions.Image")));
            this.Sim_Button.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Sim_Button.ImageOptions.LargeImage")));
            this.Sim_Button.LargeWidth = 100;
            this.Sim_Button.Name = "Sim_Button";
            this.Sim_Button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Sim_Button_ItemClick);
            // 
            // GiaCuoc_Button
            // 
            this.GiaCuoc_Button.Caption = "Giá Cước";
            this.GiaCuoc_Button.Id = 4;
            this.GiaCuoc_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GiaCuoc_Button.ImageOptions.Image")));
            this.GiaCuoc_Button.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("GiaCuoc_Button.ImageOptions.LargeImage")));
            this.GiaCuoc_Button.LargeWidth = 100;
            this.GiaCuoc_Button.Name = "GiaCuoc_Button";
            this.GiaCuoc_Button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.GiaCuoc_Button_ItemClick);
            // 
            // LSGoi_Button
            // 
            this.LSGoi_Button.Caption = "Lịch sử gọi";
            this.LSGoi_Button.Id = 5;
            this.LSGoi_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("LSGoi_Button.ImageOptions.Image")));
            this.LSGoi_Button.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("LSGoi_Button.ImageOptions.LargeImage")));
            this.LSGoi_Button.LargeWidth = 100;
            this.LSGoi_Button.Name = "LSGoi_Button";
            this.LSGoi_Button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.LSGoi_Button_ItemClick);
            // 
            // HDDK_Button
            // 
            this.HDDK_Button.Caption = "Hóa Đơn Đăng Ký";
            this.HDDK_Button.Id = 6;
            this.HDDK_Button.ImageOptions.DisabledSvgImageSize = new System.Drawing.Size(100, 100);
            this.HDDK_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HDDK_Button.ImageOptions.Image")));
            this.HDDK_Button.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HDDK_Button.ImageOptions.LargeImage")));
            this.HDDK_Button.LargeWidth = 100;
            this.HDDK_Button.MergeOrder = 120;
            this.HDDK_Button.Name = "HDDK_Button";
            this.HDDK_Button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HDDK_Button_ItemClick);
            // 
            // HDTT_Button
            // 
            this.HDTT_Button.Caption = "Hóa Đơn Thanh Toán";
            this.HDTT_Button.Id = 7;
            this.HDTT_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("HDTT_Button.ImageOptions.Image")));
            this.HDTT_Button.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("HDTT_Button.ImageOptions.LargeImage")));
            this.HDTT_Button.LargeWidth = 100;
            this.HDTT_Button.Name = "HDTT_Button";
            this.HDTT_Button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.HDTT_Button_ItemClick);
            // 
            // Random_Button
            // 
            this.Random_Button.Caption = "Random File Log";
            this.Random_Button.Id = 8;
            this.Random_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Random_Button.ImageOptions.Image")));
            this.Random_Button.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Random_Button.ImageOptions.LargeImage")));
            this.Random_Button.LargeWidth = 100;
            this.Random_Button.Name = "Random_Button";
            this.Random_Button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Random_Button_ItemClick);
            // 
            // Import_Button
            // 
            this.Import_Button.Caption = "Import File Log";
            this.Import_Button.Id = 9;
            this.Import_Button.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Import_Button.ImageOptions.Image")));
            this.Import_Button.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("Import_Button.ImageOptions.LargeImage")));
            this.Import_Button.LargeWidth = 100;
            this.Import_Button.Name = "Import_Button";
            this.Import_Button.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Import_Button_ItemClick);
            // 
            // QL_Page
            // 
            this.QL_Page.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.QL_Page.Name = "QL_Page";
            this.QL_Page.Text = "Quản Lý";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.KH_Button, true);
            this.ribbonPageGroup1.ItemLinks.Add(this.Sim_Button);
            this.ribbonPageGroup1.ItemLinks.Add(this.GiaCuoc_Button);
            this.ribbonPageGroup1.ItemLinks.Add(this.LSGoi_Button);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Nghiệp Vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.HDDK_Button);
            this.ribbonPageGroup2.ItemLinks.Add(this.HDTT_Button);
            this.ribbonPageGroup2.ItemLinks.Add(this.Random_Button);
            this.ribbonPageGroup2.ItemLinks.Add(this.Import_Button);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(905, 31);
            // 
            // Tab
            // 
            this.Tab.AccessibleDescription = "";
            this.Tab.ClosePageButtonShowMode = DevExpress.XtraTab.ClosePageButtonShowMode.InActiveTabPageHeader;
            this.Tab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Tab.Location = new System.Drawing.Point(0, 143);
            this.Tab.Name = "Tab";
            this.Tab.SelectedTabPage = this.xtraTabPage1;
            this.Tab.Size = new System.Drawing.Size(905, 525);
            this.Tab.TabIndex = 2;
            this.Tab.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            this.Tab.CloseButtonClick += new System.EventHandler(this.Tab_CloseButtonClick);
            this.Tab.Click += new System.EventHandler(this.Tab_Click);
            this.Tab.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.Tab_ControlAdded);
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Appearance.PageClient.BackColor = System.Drawing.Color.Silver;
            this.xtraTabPage1.Appearance.PageClient.Options.UseBackColor = true;
            this.xtraTabPage1.AutoScroll = true;
            this.xtraTabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(899, 497);
            this.xtraTabPage1.Text = "Xin Chào";
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(905, 699);
            this.Controls.Add(this.Tab);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "IndexForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Trang Chủ";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Tab)).EndInit();
            this.Tab.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem KH_Button;
        private DevExpress.XtraBars.Ribbon.RibbonPage QL_Page;
        private DevExpress.XtraBars.BarButtonItem Sim_Button;
        private DevExpress.XtraBars.BarButtonItem GiaCuoc_Button;
        private DevExpress.XtraBars.BarButtonItem LSGoi_Button;
        private DevExpress.XtraBars.BarButtonItem HDDK_Button;
        private DevExpress.XtraBars.BarButtonItem HDTT_Button;
        private DevExpress.XtraBars.BarButtonItem Random_Button;
        private DevExpress.XtraBars.BarButtonItem Import_Button;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraTab.XtraTabControl Tab;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
    }
}