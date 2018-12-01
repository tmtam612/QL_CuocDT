namespace QL_CuocDT_WF
{
    partial class ThemKhachHang
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
            this.txt_TenKH = new DevExpress.XtraEditors.TextEdit();
            this.txt_CMND = new DevExpress.XtraEditors.TextEdit();
            this.txt_NgheNghiep = new DevExpress.XtraEditors.TextEdit();
            this.txt_DiaChi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgheNghiep.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TenKH
            // 
            this.txt_TenKH.Location = new System.Drawing.Point(339, 57);
            this.txt_TenKH.Name = "txt_TenKH";
            this.txt_TenKH.Size = new System.Drawing.Size(153, 20);
            this.txt_TenKH.TabIndex = 0;
            // 
            // txt_CMND
            // 
            this.txt_CMND.Location = new System.Drawing.Point(339, 106);
            this.txt_CMND.Name = "txt_CMND";
            this.txt_CMND.Size = new System.Drawing.Size(153, 20);
            this.txt_CMND.TabIndex = 1;
            // 
            // txt_NgheNghiep
            // 
            this.txt_NgheNghiep.Location = new System.Drawing.Point(339, 162);
            this.txt_NgheNghiep.Name = "txt_NgheNghiep";
            this.txt_NgheNghiep.Size = new System.Drawing.Size(153, 20);
            this.txt_NgheNghiep.TabIndex = 2;
            // 
            // txt_DiaChi
            // 
            this.txt_DiaChi.Location = new System.Drawing.Point(339, 216);
            this.txt_DiaChi.Name = "txt_DiaChi";
            this.txt_DiaChi.Size = new System.Drawing.Size(153, 20);
            this.txt_DiaChi.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(166, 60);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(78, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Tên Khách Hàng";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(166, 113);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(29, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "CMND";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(166, 169);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Nghề Nghiệp";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(166, 219);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Địa Chỉ";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(166, 288);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(377, 288);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ThemKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 422);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txt_DiaChi);
            this.Controls.Add(this.txt_NgheNghiep);
            this.Controls.Add(this.txt_CMND);
            this.Controls.Add(this.txt_TenKH);
            this.Name = "ThemKhachHang";
            this.Text = "Thêm Thông Tin Khách Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.txt_TenKH.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_CMND.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_NgheNghiep.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_DiaChi.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txt_TenKH;
        private DevExpress.XtraEditors.TextEdit txt_CMND;
        private DevExpress.XtraEditors.TextEdit txt_NgheNghiep;
        private DevExpress.XtraEditors.TextEdit txt_DiaChi;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}