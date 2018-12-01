namespace QL_CuocDT_WF
{
    partial class UC_Sim
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Sim));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_SoSim = new DevExpress.XtraEditors.TextEdit();
            this.txt_MaSim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.bt_Xoa = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Sua = new DevExpress.XtraEditors.SimpleButton();
            this.bt_Them = new DevExpress.XtraEditors.SimpleButton();
            this.grid_KH = new DevExpress.XtraGrid.GridControl();
            this.simsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoSim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoSim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_SoSim);
            this.groupControl1.Controls.Add(this.txt_MaSim);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(653, 242);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Thông Tin Sim";
            // 
            // txt_SoSim
            // 
            this.txt_SoSim.Location = new System.Drawing.Point(304, 131);
            this.txt_SoSim.Name = "txt_SoSim";
            this.txt_SoSim.Size = new System.Drawing.Size(196, 20);
            this.txt_SoSim.TabIndex = 11;
            // 
            // txt_MaSim
            // 
            this.txt_MaSim.Location = new System.Drawing.Point(304, 67);
            this.txt_MaSim.Name = "txt_MaSim";
            this.txt_MaSim.Properties.ReadOnly = true;
            this.txt_MaSim.Properties.UseReadOnlyAppearance = false;
            this.txt_MaSim.Size = new System.Drawing.Size(196, 20);
            this.txt_MaSim.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(206, 134);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(31, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "Số Sim";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(206, 70);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(33, 13);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Mã Sim";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.bt_Xoa);
            this.groupControl2.Controls.Add(this.bt_Sua);
            this.groupControl2.Controls.Add(this.bt_Them);
            this.groupControl2.Location = new System.Drawing.Point(662, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(235, 242);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Thao Tác";
            // 
            // bt_Xoa
            // 
            this.bt_Xoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Xoa.ImageOptions.Image")));
            this.bt_Xoa.Location = new System.Drawing.Point(64, 188);
            this.bt_Xoa.Name = "bt_Xoa";
            this.bt_Xoa.Size = new System.Drawing.Size(105, 44);
            this.bt_Xoa.TabIndex = 2;
            this.bt_Xoa.Text = "Xóa";
            this.bt_Xoa.Click += new System.EventHandler(this.bt_Xoa_Click);
            // 
            // bt_Sua
            // 
            this.bt_Sua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("bt_Sua.ImageOptions.Image")));
            this.bt_Sua.Location = new System.Drawing.Point(64, 107);
            this.bt_Sua.Name = "bt_Sua";
            this.bt_Sua.Size = new System.Drawing.Size(105, 44);
            this.bt_Sua.TabIndex = 1;
            this.bt_Sua.Text = "Sửa";
            this.bt_Sua.Click += new System.EventHandler(this.bt_Sua_Click);
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
            this.grid_KH.DataSource = this.simsBindingSource;
            this.grid_KH.Dock = System.Windows.Forms.DockStyle.Bottom;
            gridLevelNode1.RelationName = "Level1";
            gridLevelNode2.RelationName = "Level2";
            this.grid_KH.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.grid_KH.Location = new System.Drawing.Point(0, 288);
            this.grid_KH.MainView = this.gridView1;
            this.grid_KH.Name = "grid_KH";
            this.grid_KH.Size = new System.Drawing.Size(900, 212);
            this.grid_KH.TabIndex = 2;
            this.grid_KH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.grid_KH.Click += new System.EventHandler(this.grid_KH_Click);
            // 
            // simsBindingSource
            // 
            this.simsBindingSource.DataSource = typeof(Model.EF.Sim);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaSim,
            this.colSoSim});
            this.gridView1.GridControl = this.grid_KH;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            // 
            // colMaSim
            // 
            this.colMaSim.AppearanceCell.Options.UseTextOptions = true;
            this.colMaSim.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.colMaSim.Caption = "Mã Sim";
            this.colMaSim.FieldName = "MaSim";
            this.colMaSim.Name = "colMaSim";
            this.colMaSim.OptionsColumn.ReadOnly = true;
            this.colMaSim.Visible = true;
            this.colMaSim.VisibleIndex = 0;
            this.colMaSim.Width = 169;
            // 
            // colSoSim
            // 
            this.colSoSim.Caption = "Số Sim";
            this.colSoSim.FieldName = "SoSim";
            this.colSoSim.Name = "colSoSim";
            this.colSoSim.OptionsColumn.ReadOnly = true;
            this.colSoSim.Visible = true;
            this.colSoSim.VisibleIndex = 1;
            this.colSoSim.Width = 713;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tìm kiếm";
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(283, 260);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(325, 20);
            this.textEdit1.TabIndex = 4;
            this.textEdit1.TextChanged += new System.EventHandler(this.textEdit1_TextChanged);
            // 
            // UC_Sim
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_KH);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "UC_Sim";
            this.Size = new System.Drawing.Size(900, 500);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_SoSim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_MaSim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_KH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_SoSim;
        private DevExpress.XtraEditors.TextEdit txt_MaSim;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton bt_Xoa;
        private DevExpress.XtraEditors.SimpleButton bt_Sua;
        private DevExpress.XtraEditors.SimpleButton bt_Them;
        private DevExpress.XtraGrid.GridControl grid_KH;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource simsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSim;
        private DevExpress.XtraGrid.Columns.GridColumn colSoSim;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
    }
}
