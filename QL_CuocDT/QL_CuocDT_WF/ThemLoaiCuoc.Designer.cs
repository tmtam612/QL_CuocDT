namespace QL_CuocDT_WF
{
    partial class ThemLoaiCuoc
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txt_GiaCuoc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txt_TGBD = new DevExpress.XtraEditors.TimeEdit();
            this.txt_TGKT = new DevExpress.XtraEditors.TimeEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaCuoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGBD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGKT.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(78, 54);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(86, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Thời Gian Bắt Đầu";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(484, 50);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "Thêm";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(484, 110);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 9;
            this.simpleButton2.Text = "Thoát";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.txt_TGKT);
            this.groupControl1.Controls.Add(this.txt_TGBD);
            this.groupControl1.Controls.Add(this.txt_GiaCuoc);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(22, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(408, 197);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Thông Tin Cước";
            // 
            // txt_GiaCuoc
            // 
            this.txt_GiaCuoc.Location = new System.Drawing.Point(202, 148);
            this.txt_GiaCuoc.Name = "txt_GiaCuoc";
            this.txt_GiaCuoc.Size = new System.Drawing.Size(153, 20);
            this.txt_GiaCuoc.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(78, 148);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(43, 13);
            this.labelControl3.TabIndex = 6;
            this.labelControl3.Text = "Giá Cước";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(78, 98);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 13);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Thời Gian Kết Thúc";
            // 
            // txt_TGBD
            // 
            this.txt_TGBD.EditValue = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            this.txt_TGBD.Location = new System.Drawing.Point(202, 54);
            this.txt_TGBD.Name = "txt_TGBD";
            this.txt_TGBD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TGBD.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.txt_TGBD.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_TGBD.Properties.Mask.EditMask = "HH:mm:ss";
            this.txt_TGBD.Size = new System.Drawing.Size(153, 20);
            this.txt_TGBD.TabIndex = 10;
            // 
            // txt_TGKT
            // 
            this.txt_TGKT.EditValue = new System.DateTime(2018, 11, 28, 0, 0, 0, 0);
            this.txt_TGKT.Location = new System.Drawing.Point(202, 95);
            this.txt_TGKT.Name = "txt_TGKT";
            this.txt_TGKT.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txt_TGKT.Properties.DisplayFormat.FormatString = "HH:mm:ss";
            this.txt_TGKT.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txt_TGKT.Properties.Mask.EditMask = "HH:mm:ss";
            this.txt_TGKT.Size = new System.Drawing.Size(153, 20);
            this.txt_TGKT.TabIndex = 11;
            this.txt_TGKT.EditValueChanged += new System.EventHandler(this.timeEdit2_EditValueChanged);
            // 
            // ThemLoaiCuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 221);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
            this.Name = "ThemLoaiCuoc";
            this.Text = "Thêm Loại Cước";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txt_GiaCuoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGBD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_TGKT.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit txt_GiaCuoc;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TimeEdit txt_TGKT;
        private DevExpress.XtraEditors.TimeEdit txt_TGBD;
    }
}