namespace QL_CuocDT_WF
{
    partial class UC_LoaiCuoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_LoaiCuoc));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_TGKT = new DevExpress.XtraEditors.TimeEdit();
            this.txt_TGBD = new DevExpress.XtraEditors.TimeEdit();
            this.txt_GiaCuoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Them = new DevExpress.XtraEditors.SimpleButton();
            this.grid_KH = new DevExpress.XtraGrid.GridControl();
            this.loaiCuocsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTG_BatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTG_KetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaCuoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.simsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaCuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCuocsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_TGKT);
            this.groupControl1.Controls.Add(this.txt_TGBD);
            this.groupControl1.Controls.Add(this.txt_GiaCuoc);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(653, 250);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Cước";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // txt_TGKT
            // 
            this.txt_TGKT.EditValue = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            this.txt_TGKT.Location = new System.Drawing.Point(439, 70);
            this.txt_TGKT.Name = "txt_TGKT";
            this.txt_TGKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TGKT.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.txt_TGKT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_TGKT.Properties.Mask.EditMask = "HH:mm:ss";
            this.txt_TGKT.Properties.ReadOnly = true;
            this.txt_TGKT.Properties.UseReadOnlyAppearance = false;
            this.txt_TGKT.Size = new System.Drawing.Size(195, 20);
            this.txt_TGKT.TabIndex = 17;
            // 
            // txt_TGBD
            // 
            this.txt_TGBD.EditValue = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            this.txt_TGBD.Location = new System.Drawing.Point(107, 70);
            this.txt_TGBD.Name = "txt_TGBD";
            this.txt_TGBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TGBD.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.txt_TGBD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_TGBD.Properties.EditFormat.FormatString = "HH:mm:ss";
            this.txt_TGBD.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_TGBD.Properties.Mask.EditMask = "HH:mm:ss";
            this.txt_TGBD.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt_TGBD.Properties.ReadOnly = true;
            this.txt_TGBD.Properties.UseReadOnlyAppearance = false;
            this.txt_TGBD.Size = new System.Drawing.Size(195, 20);
            this.txt_TGBD.TabIndex = 16;
            // 
            // txt_GiaCuoc
            // 
            this.txt_GiaCuoc.Location = new System.Drawing.Point(106, 146);
            this.txt_GiaCuoc.Name = "txt_GiaCuoc";
            this.txt_GiaCuoc.Size = new System.Drawing.Size(196, 20);
            this.txt_GiaCuoc.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 153);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(43, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Giá Cước";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(344, 70);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(89, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Thời Gian Kết Thúc";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Thời Gian Bắt Đầu";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.simpleButton1);
            this.groupControl2.Controls.Add(this.bt_Xoa);
            this.groupControl2.Controls.Add(this.bt_Them);
            this.groupControl2.Location = new System.Drawing.Point(662, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(235, 250);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thao Tác";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(64, 128);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(105, 38);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Sửa";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.ImageOptions.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(64, 195);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(105, 44);
            this.bt_Xoa.TabIndex = 2;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Them
            // 
            this.bt_Them.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Them.ImageOptions.Image")));
            this.bt_Them.Location = new System.Drawing.Point(64, 43);
            this.bt_Them.Name = "bt_Them";
            this.bt_Them.Size = new System.Drawing.Size(105, 44);
            this.bt_Them.TabIndex = 0;
            this.bt_Them.Text = "Thêm";
            this.bt_Them.Click += new System.EventHandler(this.bt_Them_Click);
            // 
            // grid_KH
            // 
            this.grid_KH.DataSource = this.loaiCuocsBindingSource;
            this.grid_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode3.RelationName = "Level1";
            gridLevelNode4.RelationName = "Level2";
            this.grid_KH.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3,
            gridLevelNode4});
            this.grid_KH.Location = new System.Drawing.Point(0, 288);
            this.grid_KH.MainView = this.gridView1;
            this.grid_KH.Name = "grid_KH";
            this.grid_KH.Size = new System.Drawing.Size(900, 212);
            this.grid_KH.TabIndex = 2;
            this.grid_KH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_KH.Click += new System.EventHandler(this.grid_KH_Click);
            // 
            // loaiCuocsBindingSource
            // 
            this.loaiCuocsBindingSource.DataSource = typeof(Model.EF.LoaiCuoc);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTG_BatDau,
            this.colTG_KetThuc,
            this.colGiaCuoc});
            this.gridView1.GridControl = this.grid_KH;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colTG_BatDau
            // 
            this.colTG_BatDau.Caption = "Thời gian bắt đầu";
            this.colTG_BatDau.FieldName = "TG_BatDau";
            this.colTG_BatDau.Name = "colTG_BatDau";
            this.colTG_BatDau.Visible = true;
            this.colTG_BatDau.VisibleIndex = 0;
            // 
            // colTG_KetThuc
            // 
            this.colTG_KetThuc.Caption = "Thời gian kết thúc";
            this.colTG_KetThuc.FieldName = "TG_KetThuc";
            this.colTG_KetThuc.Name = "colTG_KetThuc";
            this.colTG_KetThuc.Visible = true;
            this.colTG_KetThuc.VisibleIndex = 1;
            // 
            // colGiaCuoc
            // 
            this.colGiaCuoc.AppearanceCell.Options.UseTextOptions = true;
            this.colGiaCuoc.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colGiaCuoc.Caption = "Giá cước";
            this.colGiaCuoc.FieldName = "GiaCuoc";
            this.colGiaCuoc.Name = "colGiaCuoc";
            this.colGiaCuoc.Visible = true;
            this.colGiaCuoc.VisibleIndex = 2;
            // 
            // simsBindingSource
            // 
            this.simsBindingSource.DataSource = typeof(Model.EF.Sim);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(218, 269);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(41, 13);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tìm Kiếm";
            this.labelControl3.Click += new System.EventHandler(this.labelControl3_Click);
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(309, 262);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(296, 20);
            this.textEdit1.TabIndex = 4;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // UC_LoaiCuoc
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.grid_KH);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UC_LoaiCuoc";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaCuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loaiCuocsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Them;
        private DevExpress.XtraGrid.GridControl grid_KH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource simsBindingSource;
        private DevExpress.XtraEditors.TextEdit txt_GiaCuoc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.BindingSource loaiCuocsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colTG_BatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colTG_KetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaCuoc;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TimeEdit txt_TGKT;
        private DevExpress.XtraEditors.TimeEdit txt_TGBD;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
