namespace QL_CuocDT_WF
{
    partial class UC_CuocGoi
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode4 = new DevExpress.XtraGrid.GridLevelNode();
            this.grid_KH = new DevExpress.XtraGrid.GridControl();
            this.cuocGoisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaCuocGoi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMaSim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTG_BatDau = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTG_KetThuc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoPhutSD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txt_MaCuocGoi = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaSim = new DevExpress.XtraEditors.TextEdit();
            this.txt_SoSim = new DevExpress.XtraEditors.TextEdit();
            this.txt_TGBD = new DevExpress.XtraEditors.TextEdit();
            this.txt_TGKT = new DevExpress.XtraEditors.TextEdit();
            this.txt_SPSD = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuocGoisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCuocGoi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoSim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGKT.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SPSD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_KH
            // 
            this.grid_KH.DataSource = this.cuocGoisBindingSource;
            this.grid_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode3.RelationName = "Level1";
            gridLevelNode4.RelationName = "Level2";
            this.grid_KH.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode3,
            gridLevelNode4});
            this.grid_KH.Location = new System.Drawing.Point(0, 187);
            this.grid_KH.MainView = this.gridView1;
            this.grid_KH.Name = "grid_KH";
            this.grid_KH.Size = new System.Drawing.Size(900, 313);
            this.grid_KH.TabIndex = 2;
            this.grid_KH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_KH.Click += new System.EventHandler(this.grid_KH_Click);
            // 
            // cuocGoisBindingSource
            // 
            this.cuocGoisBindingSource.DataSource = typeof(Model.EF.CuocGoi);
            this.cuocGoisBindingSource.CurrentChanged += new System.EventHandler(this.cuocGoisBindingSource_CurrentChanged);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaCuocGoi,
            this.colMaSim,
            this.colTG_BatDau,
            this.colTG_KetThuc,
            this.colSoPhutSD,
            this.gridColumn1});
            this.gridView1.GridControl = this.grid_KH;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMaCuocGoi
            // 
            this.colMaCuocGoi.AppearanceCell.Options.UseTextOptions = true;
            this.colMaCuocGoi.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaCuocGoi.Caption = "Mã Cuộc Gọi";
            this.colMaCuocGoi.FieldName = "MaCuocGoi";
            this.colMaCuocGoi.Name = "colMaCuocGoi";
            this.colMaCuocGoi.Visible = true;
            this.colMaCuocGoi.VisibleIndex = 0;
            // 
            // colMaSim
            // 
            this.colMaSim.FieldName = "MaSim";
            this.colMaSim.Name = "colMaSim";
            // 
            // colTG_BatDau
            // 
            this.colTG_BatDau.Caption = "Thời Gian Bắt Đầu";
            this.colTG_BatDau.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss tt";
            this.colTG_BatDau.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTG_BatDau.FieldName = "TG_BatDau";
            this.colTG_BatDau.Name = "colTG_BatDau";
            this.colTG_BatDau.Visible = true;
            this.colTG_BatDau.VisibleIndex = 2;
            // 
            // colTG_KetThuc
            // 
            this.colTG_KetThuc.Caption = "Thời Gian Kết Thúc";
            this.colTG_KetThuc.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss tt";
            this.colTG_KetThuc.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTG_KetThuc.FieldName = "TG_KetThuc";
            this.colTG_KetThuc.Name = "colTG_KetThuc";
            this.colTG_KetThuc.Visible = true;
            this.colTG_KetThuc.VisibleIndex = 3;
            // 
            // colSoPhutSD
            // 
            this.colSoPhutSD.AppearanceCell.Options.UseTextOptions = true;
            this.colSoPhutSD.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colSoPhutSD.Caption = "Số Phút Sử Dụng";
            this.colSoPhutSD.FieldName = "SoPhutSD";
            this.colSoPhutSD.Name = "colSoPhutSD";
            this.colSoPhutSD.Visible = true;
            this.colSoPhutSD.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Số Sim";
            this.gridColumn1.FieldName = "Sim.SoSim";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(179, 31);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Cuộc Gọi";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(179, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Mã Sim";
            this.labelControl2.Click += new System.EventHandler(this.labelControl2_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(179, 123);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 13);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "Số Sim";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(530, 30);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(83, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Thời gian bắt đầu";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(530, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(85, 13);
            this.labelControl5.TabIndex = 7;
            this.labelControl5.Text = "Thời gian kết thúc";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(530, 119);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(79, 13);
            this.labelControl6.TabIndex = 8;
            this.labelControl6.Text = "Số phút sử dụng";
            // 
            // txt_MaCuocGoi
            // 
            this.txt_MaCuocGoi.Location = new System.Drawing.Point(294, 23);
            this.txt_MaCuocGoi.Name = "txt_MaCuocGoi";
            this.txt_MaCuocGoi.Properties.ReadOnly = true;
            this.txt_MaCuocGoi.Properties.UseReadOnlyAppearance = false;
            this.txt_MaCuocGoi.Size = new System.Drawing.Size(204, 20);
            this.txt_MaCuocGoi.TabIndex = 9;
            // 
            // txt_MaSim
            // 
            this.txt_MaSim.Location = new System.Drawing.Point(294, 71);
            this.txt_MaSim.Name = "txt_MaSim";
            this.txt_MaSim.Size = new System.Drawing.Size(204, 20);
            this.txt_MaSim.TabIndex = 10;
            // 
            // txt_SoSim
            // 
            this.txt_SoSim.Location = new System.Drawing.Point(294, 116);
            this.txt_SoSim.Name = "txt_SoSim";
            this.txt_SoSim.Size = new System.Drawing.Size(204, 20);
            this.txt_SoSim.TabIndex = 11;
            this.txt_SoSim.EditValueChanged += new System.EventHandler(this.textEdit3_EditValueChanged);
            // 
            // txt_TGBD
            // 
            this.txt_TGBD.Location = new System.Drawing.Point(651, 24);
            this.txt_TGBD.Name = "txt_TGBD";
            this.txt_TGBD.Size = new System.Drawing.Size(196, 20);
            this.txt_TGBD.TabIndex = 12;
            // 
            // txt_TGKT
            // 
            this.txt_TGKT.Location = new System.Drawing.Point(651, 71);
            this.txt_TGKT.Name = "txt_TGKT";
            this.txt_TGKT.Size = new System.Drawing.Size(196, 20);
            this.txt_TGKT.TabIndex = 13;
            // 
            // txt_SPSD
            // 
            this.txt_SPSD.Location = new System.Drawing.Point(651, 112);
            this.txt_SPSD.Name = "txt_SPSD";
            this.txt_SPSD.Size = new System.Drawing.Size(196, 20);
            this.txt_SPSD.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(179, 168);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(41, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "Tìm Kiếm";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(294, 160);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(315, 20);
            this.textEdit1.TabIndex = 16;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // UC_CuocGoi
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.txt_SPSD);
            this.Controls.Add(this.txt_TGKT);
            this.Controls.Add(this.txt_TGBD);
            this.Controls.Add(this.txt_SoSim);
            this.Controls.Add(this.txt_MaSim);
            this.Controls.Add(this.txt_MaCuocGoi);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.grid_KH);
            this.Name = "UC_CuocGoi";
            this.Size = new System.Drawing.Size(900, 500);
            this.Load += new System.EventHandler(this.UC_CuocGoi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuocGoisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaCuocGoi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoSim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGKT.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SPSD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl grid_KH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource cuocGoisBindingSource;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txt_MaCuocGoi;
        private DevExpress.XtraEditors.TextEdit txt_MaSim;
        private DevExpress.XtraEditors.TextEdit txt_SoSim;
        private DevExpress.XtraEditors.TextEdit txt_TGBD;
        private DevExpress.XtraEditors.TextEdit txt_TGKT;
        private DevExpress.XtraEditors.TextEdit txt_SPSD;
        private DevExpress.XtraGrid.Columns.GridColumn colMaCuocGoi;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSim;
        private DevExpress.XtraGrid.Columns.GridColumn colTG_BatDau;
        private DevExpress.XtraGrid.Columns.GridColumn colTG_KetThuc;
        private DevExpress.XtraGrid.Columns.GridColumn colSoPhutSD;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
