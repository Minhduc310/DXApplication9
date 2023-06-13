namespace DXApplication9
{
    partial class Thay_đổi_quy_định
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
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.btnDongY = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuyBo = new DevExpress.XtraEditors.SimpleButton();
            this.txtTuoiCanDuoi = new DevComponents.Editors.IntegerInput();
            this.txtTuoiCanTren = new DevComponents.Editors.IntegerInput();
            this.txtSiSoCanDuoi = new DevComponents.Editors.IntegerInput();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtSiSoCanTren = new DevComponents.Editors.IntegerInput();
            this.txtDiemDat = new DevComponents.Editors.IntegerInput();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoiCanDuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoiCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoCanDuoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoCanTren)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemDat)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(28, 41);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(169, 21);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "QUY ĐỊNH ĐỘ TUỔI";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(28, 321);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(180, 21);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "QUY ĐỊNH ĐIỂM ĐẠT";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(28, 180);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(142, 21);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "QUY ĐỊNH SỈ SỐ";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(46, 79);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(75, 16);
            this.labelControl4.TabIndex = 3;
            this.labelControl4.Text = "Tuổi tối thiểu";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(60, 130);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(61, 16);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Tuổi tối đa";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(57, 272);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 16);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Sĩ số tối đa";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(43, 372);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(81, 16);
            this.labelControl7.TabIndex = 6;
            this.labelControl7.Text = "Điểm đạt môn";
            // 
            // btnDongY
            // 
            this.btnDongY.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDongY.Location = new System.Drawing.Point(153, 428);
            this.btnDongY.Margin = new System.Windows.Forms.Padding(4);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(88, 28);
            this.btnDongY.TabIndex = 6;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnHuyBo
            // 
            this.btnHuyBo.Location = new System.Drawing.Point(277, 428);
            this.btnHuyBo.Margin = new System.Windows.Forms.Padding(4);
            this.btnHuyBo.Name = "btnHuyBo";
            this.btnHuyBo.Size = new System.Drawing.Size(88, 28);
            this.btnHuyBo.TabIndex = 7;
            this.btnHuyBo.Text = "Huỷ bỏ";
            this.btnHuyBo.Click += new System.EventHandler(this.btnHuyBo_Click);
            // 
            // txtTuoiCanDuoi
            // 
            this.txtTuoiCanDuoi.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtTuoiCanDuoi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTuoiCanDuoi.Location = new System.Drawing.Point(153, 79);
            this.txtTuoiCanDuoi.Name = "txtTuoiCanDuoi";
            this.txtTuoiCanDuoi.ShowUpDown = true;
            this.txtTuoiCanDuoi.Size = new System.Drawing.Size(212, 23);
            this.txtTuoiCanDuoi.TabIndex = 1;
            // 
            // txtTuoiCanTren
            // 
            this.txtTuoiCanTren.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtTuoiCanTren.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtTuoiCanTren.Location = new System.Drawing.Point(153, 123);
            this.txtTuoiCanTren.Name = "txtTuoiCanTren";
            this.txtTuoiCanTren.ShowUpDown = true;
            this.txtTuoiCanTren.Size = new System.Drawing.Size(212, 23);
            this.txtTuoiCanTren.TabIndex = 2;
            // 
            // txtSiSoCanDuoi
            // 
            this.txtSiSoCanDuoi.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtSiSoCanDuoi.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSiSoCanDuoi.Location = new System.Drawing.Point(153, 225);
            this.txtSiSoCanDuoi.Name = "txtSiSoCanDuoi";
            this.txtSiSoCanDuoi.ShowUpDown = true;
            this.txtSiSoCanDuoi.Size = new System.Drawing.Size(212, 23);
            this.txtSiSoCanDuoi.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(43, 232);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(78, 16);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "Sĩ số tối thiểu";
            // 
            // txtSiSoCanTren
            // 
            this.txtSiSoCanTren.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtSiSoCanTren.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtSiSoCanTren.Location = new System.Drawing.Point(153, 272);
            this.txtSiSoCanTren.Name = "txtSiSoCanTren";
            this.txtSiSoCanTren.ShowUpDown = true;
            this.txtSiSoCanTren.Size = new System.Drawing.Size(212, 23);
            this.txtSiSoCanTren.TabIndex = 4;
            // 
            // txtDiemDat
            // 
            this.txtDiemDat.BackColor = System.Drawing.SystemColors.Control;
            // 
            // 
            // 
            this.txtDiemDat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.txtDiemDat.Location = new System.Drawing.Point(153, 365);
            this.txtDiemDat.Name = "txtDiemDat";
            this.txtDiemDat.ShowUpDown = true;
            this.txtDiemDat.Size = new System.Drawing.Size(212, 23);
            this.txtDiemDat.TabIndex = 5;
            // 
            // Thay_đổi_quy_định
            // 
            this.Appearance.BackColor = System.Drawing.Color.LightBlue;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 472);
            this.Controls.Add(this.txtDiemDat);
            this.Controls.Add(this.txtSiSoCanTren);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtSiSoCanDuoi);
            this.Controls.Add(this.txtTuoiCanTren);
            this.Controls.Add(this.txtTuoiCanDuoi);
            this.Controls.Add(this.btnHuyBo);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Thay_đổi_quy_định";
            this.Text = "Thay đổi quy định";
            this.Load += new System.EventHandler(this.Thay_đổi_quy_định_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoiCanDuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTuoiCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoCanDuoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSiSoCanTren)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDiemDat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton btnDongY;
        private DevExpress.XtraEditors.SimpleButton btnHuyBo;
        private DevComponents.Editors.IntegerInput txtTuoiCanDuoi;
        private DevComponents.Editors.IntegerInput txtTuoiCanTren;
        private DevComponents.Editors.IntegerInput txtSiSoCanDuoi;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevComponents.Editors.IntegerInput txtSiSoCanTren;
        private DevComponents.Editors.IntegerInput txtDiemDat;
    }
}