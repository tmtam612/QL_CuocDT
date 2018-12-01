namespace QL_CuocDT_WF
{
    partial class ThongTinSim
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.simsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colMaSim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoSim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.khachHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.simsBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(803, 460);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControl1.Click += new System.EventHandler(this.gridControl1_Click);
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
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colMaSim
            // 
            this.colMaSim.Caption = "Mã Sim";
            this.colMaSim.FieldName = "MaSim";
            this.colMaSim.Name = "colMaSim";
            this.colMaSim.OptionsColumn.ReadOnly = true;
            this.colMaSim.Visible = true;
            this.colMaSim.VisibleIndex = 0;
            // 
            // colSoSim
            // 
            this.colSoSim.Caption = "Số Sim";
            this.colSoSim.FieldName = "SoSim";
            this.colSoSim.Name = "colSoSim";
            this.colSoSim.OptionsColumn.ReadOnly = true;
            this.colSoSim.Visible = true;
            this.colSoSim.VisibleIndex = 1;
            // 
            // khachHangsBindingSource
            // 
            this.khachHangsBindingSource.DataSource = typeof(Model.EF.KhachHang);
            // 
            // ThongTinSim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 460);
            this.Controls.Add(this.gridControl1);
            this.Name = "ThongTinSim";
            this.Text = "Danh Sách Sim";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource khachHangsBindingSource;
        private System.Windows.Forms.BindingSource simsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaSim;
        private DevExpress.XtraGrid.Columns.GridColumn colSoSim;
    }
}