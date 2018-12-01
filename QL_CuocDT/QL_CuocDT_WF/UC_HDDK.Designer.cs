namespace QL_CuocDT_WF
{
    partial class UC_HDDK
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_HDDK));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_MaSim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaKH = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TGDK = new DevExpress.XtraEditors.DateEdit();
            this.txt_ChiPhi = new DevExpress.XtraEditors.TextEdit();
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoSim = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaHD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Them = new DevExpress.XtraEditors.SimpleButton();
            this.grid_KH = new DevExpress.XtraGrid.GridControl();
            this.hoaDonDKsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaHD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTG_DangKy = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colChiPhi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKhachHang = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGDK.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGDK.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ChiPhi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoSim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaHD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDKsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_MaSim);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.txt_MaKH);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.txt_TGDK);
            this.groupControl1.Controls.Add(this.txt_ChiPhi);
            this.groupControl1.Controls.Add(this.txt_TenKH);
            this.groupControl1.Controls.Add(this.txt_SoSim);
            this.groupControl1.Controls.Add(this.txt_MaHD);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(653, 257);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Hóa Đơn";
            // 
            // txt_MaSim
            // 
            this.txt_MaSim.Location = new System.Drawing.Point(132, 112);
            this.txt_MaSim.Name = "txt_MaSim";
            this.txt_MaSim.Properties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaSim_Properties_KeyDown);
            this.txt_MaSim.Size = new System.Drawing.Size(166, 20);
            this.txt_MaSim.TabIndex = 17;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(21, 115);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(33, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "Mã Sim";
            // 
            // txt_MaKH
            // 
            this.txt_MaKH.Location = new System.Drawing.Point(433, 170);
            this.txt_MaKH.Name = "txt_MaKH";
            this.txt_MaKH.Properties.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_MaKH_Properties_KeyDown);
            this.txt_MaKH.Size = new System.Drawing.Size(196, 20);
            this.txt_MaKH.TabIndex = 15;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(340, 173);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(74, 13);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "Mã Khách Hàng";
            // 
            // txt_TGDK
            // 
            this.txt_TGDK.EditValue = null;
            this.txt_TGDK.Location = new System.Drawing.Point(435, 47);
            this.txt_TGDK.Name = "txt_TGDK";
            this.txt_TGDK.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TGDK.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TGDK.Properties.Mask.EditMask = "dd/MM/yyyy HH:mm:ss";
            this.txt_TGDK.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_TGDK.Size = new System.Drawing.Size(194, 20);
            this.txt_TGDK.TabIndex = 13;
            // 
            // txt_ChiPhi
            // 
            this.txt_ChiPhi.Location = new System.Drawing.Point(433, 112);
            this.txt_ChiPhi.Name = "txt_ChiPhi";
            this.txt_ChiPhi.Size = new System.Drawing.Size(196, 20);
            this.txt_ChiPhi.TabIndex = 12;
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(435, 217);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(196, 20);
            this.txt_TenKH.TabIndex = 10;
            // 
            // txt_SoSim
            // 
            this.txt_SoSim.Location = new System.Drawing.Point(132, 166);
            this.txt_SoSim.Name = "txt_SoSim";
            this.txt_SoSim.Size = new System.Drawing.Size(166, 20);
            this.txt_SoSim.TabIndex = 9;
            // 
            // txt_MaHD
            // 
            this.txt_MaHD.Location = new System.Drawing.Point(132, 44);
            this.txt_MaHD.Name = "txt_MaHD";
            this.txt_MaHD.Properties.ReadOnly = true;
            this.txt_MaHD.Properties.UseReadOnlyAppearance = false;
            this.txt_MaHD.Size = new System.Drawing.Size(166, 20);
            this.txt_MaHD.TabIndex = 8;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(340, 115);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Chi Phí";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(340, 44);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Thời Gian Đăng Ký";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(340, 224);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(78, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Tên Khách Hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(21, 173);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(31, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Số Sim";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(21, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Hóa Đơn";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.bt_Xoa);
            this.groupControl2.Controls.Add(this.bt_Sua);
            this.groupControl2.Controls.Add(this.bt_Them);
            this.groupControl2.Location = new System.Drawing.Point(662, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(235, 257);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thao Tác";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.ImageOptions.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(64, 197);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(105, 44);
            this.bt_Xoa.TabIndex = 2;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.ImageOptions.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(64, 115);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(105, 44);
            this.bt_Sua.TabIndex = 1;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Them.ImageOptions.Image")));
            this.bt_Them.Location = new System.Drawing.Point(64, 29);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(105, 44);
            this.bt_Them.TabIndex = 0;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // grid_KH
            // 
            this.grid_KH.DataSource = this.hoaDonDKsBindingSource;
            this.grid_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.RelationName = "Level1";
            this.grid_KH.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grid_KH.Location = new System.Drawing.Point(0, 288);
            this.grid_KH.MainView = this.gridView1;
            this.grid_KH.Name = "grid_KH";
            this.grid_KH.Size = new System.Drawing.Size(900, 212);
            this.grid_KH.TabIndex = 2;
            this.grid_KH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_KH.Click += new System.EventHandler(this.grid_KH_Click);
            // 
            // hoaDonDKsBindingSource
            // 
            this.hoaDonDKsBindingSource.DataSource = typeof(Model.EF.HoaDonDK);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaHD,
            this.colMaSim,
            this.colTG_DangKy,
            this.colChiPhi,
            this.colMaKH,
            this.colKhachHang,
            this.colSim});
            this.gridView1.GridControl = this.grid_KH;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMaHD
            // 
            this.colMaHD.AppearanceCell.Options.UseTextOptions = true;
            this.colMaHD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaHD.Caption = "Mã Hóa Đơn";
            this.colMaHD.FieldName = "MaHD";
            this.colMaHD.Name = "colMaHD";
            this.colMaHD.OptionsColumn.ReadOnly = true;
            this.colMaHD.Visible = true;
            this.colMaHD.VisibleIndex = 0;
            // 
            // colMaSim
            // 
            this.colMaSim.FieldName = "MaSim";
            this.colMaSim.Name = "colMaSim";
            // 
            // colTG_DangKy
            // 
            this.colTG_DangKy.Caption = "Thời gian đăng ký";
            this.colTG_DangKy.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss tt";
            this.colTG_DangKy.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTG_DangKy.FieldName = "TG_DangKy";
            this.colTG_DangKy.Name = "colTG_DangKy";
            this.colTG_DangKy.OptionsColumn.ReadOnly = true;
            this.colTG_DangKy.Visible = true;
            this.colTG_DangKy.VisibleIndex = 3;
            // 
            // colChiPhi
            // 
            this.colChiPhi.AppearanceCell.Options.UseTextOptions = true;
            this.colChiPhi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colChiPhi.Caption = "Chi Phí";
            this.colChiPhi.FieldName = "ChiPhi";
            this.colChiPhi.Name = "colChiPhi";
            this.colChiPhi.OptionsColumn.ReadOnly = true;
            this.colChiPhi.Visible = true;
            this.colChiPhi.VisibleIndex = 4;
            // 
            // colMaKH
            // 
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            // 
            // colKhachHang
            // 
            this.colKhachHang.Caption = "Tên Khách Hàng";
            this.colKhachHang.FieldName = "KhachHang.TenKH";
            this.colKhachHang.Name = "colKhachHang";
            this.colKhachHang.OptionsColumn.ReadOnly = true;
            this.colKhachHang.Visible = true;
            this.colKhachHang.VisibleIndex = 2;
            // 
            // colSim
            // 
            this.colSim.Caption = "Sim";
            this.colSim.FieldName = "Sim.SoSim";
            this.colSim.Name = "colSim";
            this.colSim.OptionsColumn.ReadOnly = true;
            this.colSim.Visible = true;
            this.colSim.VisibleIndex = 1;
            // 
            // khachHangsBindingSource
            // 
            this.khachHangsBindingSource.DataSource = typeof(Model.EF.KhachHang);
            this.khachHangsBindingSource.CurrentChanged += new System.EventHandler(this.khachHangsBindingSource_CurrentChanged_1);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(193, 266);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(41, 13);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "Tìm Kiếm";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(293, 263);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(315, 20);
            this.textEdit1.TabIndex = 17;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // UC_HDDK
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.grid_KH);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UC_HDDK";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGDK.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGDK.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_ChiPhi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoSim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaHD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonDKsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private DevExpress.XtraEditors.TextEdit txt_SoSim;
        private DevExpress.XtraEditors.TextEdit txt_MaHD;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private DevExpress.XtraEditors.SimpleButton bt_Them;
        private DevExpress.XtraGrid.GridControl grid_KH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource khachHangsBindingSource;
        private DevExpress.XtraEditors.TextEdit txt_ChiPhi;
        private System.Windows.Forms.BindingSource hoaDonDKsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaHD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSim;
        private DevExpress.XtraGrid.Columns.GridColumn colTG_DangKy;
        private DevExpress.XtraGrid.Columns.GridColumn colChiPhi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colKhachHang;
        private DevExpress.XtraGrid.Columns.GridColumn colSim;
        private DevExpress.XtraEditors.DateEdit txt_TGDK;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
        private DevExpress.XtraEditors.TextEdit txt_MaSim;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txt_MaKH;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
