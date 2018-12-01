namespace QL_CuocDT_WF
{
    partial class ThongTinKhachHang
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.khachHangsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colMaKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenKH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCMND = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgheNghiep = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiaChi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.khachHangsBindingSource;
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
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMaKH,
            this.colTenKH,
            this.colCMND,
            this.colNgheNghiep,
            this.colDiaChi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // khachHangsBindingSource
            // 
            this.khachHangsBindingSource.DataSource = typeof(Model.EF.KhachHang);
            // 
            // colMaKH
            // 
            this.colMaKH.Caption = "Mã Khách Hàng";
            this.colMaKH.FieldName = "MaKH";
            this.colMaKH.Name = "colMaKH";
            this.colMaKH.OptionsColumn.ReadOnly = true;
            this.colMaKH.Visible = true;
            this.colMaKH.VisibleIndex = 0;
            // 
            // colTenKH
            // 
            this.colTenKH.Caption = "Tên Khách Hàng";
            this.colTenKH.FieldName = "TenKH";
            this.colTenKH.Name = "colTenKH";
            this.colTenKH.OptionsColumn.ReadOnly = true;
            this.colTenKH.Visible = true;
            this.colTenKH.VisibleIndex = 1;
            // 
            // colCMND
            // 
            this.colCMND.FieldName = "CMND";
            this.colCMND.Name = "colCMND";
            this.colCMND.OptionsColumn.ReadOnly = true;
            this.colCMND.Visible = true;
            this.colCMND.VisibleIndex = 2;
            // 
            // colNgheNghiep
            // 
            this.colNgheNghiep.Caption = "Nghề Nghiệp";
            this.colNgheNghiep.FieldName = "NgheNghiep";
            this.colNgheNghiep.Name = "colNgheNghiep";
            this.colNgheNghiep.OptionsColumn.ReadOnly = true;
            this.colNgheNghiep.Visible = true;
            this.colNgheNghiep.VisibleIndex = 3;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Caption = "Địa Chỉ";
            this.colDiaChi.FieldName = "DiaChi";
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.OptionsColumn.ReadOnly = true;
            this.colDiaChi.Visible = true;
            this.colDiaChi.VisibleIndex = 4;
            // 
            // ThongTinKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 460);
            this.Controls.Add(this.gridControl1);
            this.Name = "ThongTinKhachHang";
            this.Text = "Danh Sách Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource khachHangsBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colMaKH;
        private DevExpress.XtraGrid.Columns.GridColumn colTenKH;
        private DevExpress.XtraGrid.Columns.GridColumn colCMND;
        private DevExpress.XtraGrid.Columns.GridColumn colNgheNghiep;
        private DevExpress.XtraGrid.Columns.GridColumn colDiaChi;
    }
}