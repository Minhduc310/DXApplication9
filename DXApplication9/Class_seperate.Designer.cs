namespace DXApplication9
{
    partial class Class_seperate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Class_seperate));
            this.groupPanelLopCu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbKhoiLopCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNamHocCu = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.lvLopCu = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenCu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnChuyen = new DevComponents.DotNetBar.ButtonX();
            this.btnXoa = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.groupPanelLopMoi = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.cmbLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.cmbKhoiLopMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbNamHocMoi = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lvLopMoi = new DevComponents.DotNetBar.Controls.ListViewEx();
            this.colMaHSMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHoTenMoi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupPanelLopCu.SuspendLayout();
            this.groupPanelLopMoi.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanelLopCu
            // 
            this.groupPanelLopCu.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLopCu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLopCu.Controls.Add(this.cmbLopCu);
            this.groupPanelLopCu.Controls.Add(this.cmbKhoiLopCu);
            this.groupPanelLopCu.Controls.Add(this.cmbNamHocCu);
            this.groupPanelLopCu.Controls.Add(this.labelX3);
            this.groupPanelLopCu.Controls.Add(this.labelX2);
            this.groupPanelLopCu.Controls.Add(this.labelX1);
            this.groupPanelLopCu.Location = new System.Drawing.Point(8, 8);
            this.groupPanelLopCu.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanelLopCu.Name = "groupPanelLopCu";
            this.groupPanelLopCu.Size = new System.Drawing.Size(480, 148);
            // 
            // 
            // 
            this.groupPanelLopCu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLopCu.Style.BackColorGradientAngle = 90;
            this.groupPanelLopCu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLopCu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderBottomWidth = 1;
            this.groupPanelLopCu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLopCu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderLeftWidth = 1;
            this.groupPanelLopCu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderRightWidth = 1;
            this.groupPanelLopCu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopCu.Style.BorderTopWidth = 1;
            this.groupPanelLopCu.Style.CornerDiameter = 4;
            this.groupPanelLopCu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLopCu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLopCu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLopCu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelLopCu.TabIndex = 2;
            this.groupPanelLopCu.Text = "Thông tin lớp cũ";
            // 
            // cmbLopCu
            // 
            this.cmbLopCu.DisplayMember = "Text";
            this.cmbLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopCu.FormattingEnabled = true;
            this.cmbLopCu.ItemHeight = 14;
            this.cmbLopCu.Location = new System.Drawing.Point(160, 86);
            this.cmbLopCu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLopCu.Name = "cmbLopCu";
            this.cmbLopCu.Size = new System.Drawing.Size(160, 20);
            this.cmbLopCu.TabIndex = 3;
            // 
            // cmbKhoiLopCu
            // 
            this.cmbKhoiLopCu.DisplayMember = "Text";
            this.cmbKhoiLopCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLopCu.FormattingEnabled = true;
            this.cmbKhoiLopCu.ItemHeight = 14;
            this.cmbKhoiLopCu.Location = new System.Drawing.Point(160, 49);
            this.cmbKhoiLopCu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoiLopCu.Name = "cmbKhoiLopCu";
            this.cmbKhoiLopCu.Size = new System.Drawing.Size(160, 20);
            this.cmbKhoiLopCu.TabIndex = 2;
            // 
            // cmbNamHocCu
            // 
            this.cmbNamHocCu.DisplayMember = "Text";
            this.cmbNamHocCu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocCu.FormattingEnabled = true;
            this.cmbNamHocCu.ItemHeight = 14;
            this.cmbNamHocCu.Location = new System.Drawing.Point(160, 12);
            this.cmbNamHocCu.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNamHocCu.Name = "cmbNamHocCu";
            this.cmbNamHocCu.Size = new System.Drawing.Size(160, 20);
            this.cmbNamHocCu.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            this.labelX3.Location = new System.Drawing.Point(67, 86);
            this.labelX3.Margin = new System.Windows.Forms.Padding(4);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(76, 23);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Lớp:";
            // 
            // labelX2
            // 
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            this.labelX2.Location = new System.Drawing.Point(67, 49);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(76, 28);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Khối lớp:";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            this.labelX1.Location = new System.Drawing.Point(67, 12);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(76, 25);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Năm học:";
            // 
            // lvLopCu
            // 
            // 
            // 
            // 
            this.lvLopCu.Border.Class = "ListViewBorder";
            this.lvLopCu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSCu,
            this.colHoTenCu});
            this.lvLopCu.FullRowSelect = true;
            this.lvLopCu.Location = new System.Drawing.Point(8, 164);
            this.lvLopCu.Margin = new System.Windows.Forms.Padding(4);
            this.lvLopCu.Name = "lvLopCu";
            this.lvLopCu.Size = new System.Drawing.Size(480, 243);
            this.lvLopCu.TabIndex = 3;
            this.lvLopCu.UseCompatibleStateImageBehavior = false;
            this.lvLopCu.View = System.Windows.Forms.View.Details;
            // 
            // colMaHSCu
            // 
            this.colMaHSCu.Text = "Mã học sinh";
            this.colMaHSCu.Width = 90;
            // 
            // colHoTenCu
            // 
            this.colHoTenCu.Text = "Họ và tên";
            this.colHoTenCu.Width = 267;
            // 
            // btnChuyen
            // 
            this.btnChuyen.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnChuyen.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnChuyen.Image = ((System.Drawing.Image)(resources.GetObject("btnChuyen.Image")));
            this.btnChuyen.Location = new System.Drawing.Point(496, 164);
            this.btnChuyen.Margin = new System.Windows.Forms.Padding(4);
            this.btnChuyen.Name = "btnChuyen";
            this.btnChuyen.Size = new System.Drawing.Size(73, 68);
            this.btnChuyen.TabIndex = 4;
            this.btnChuyen.Tooltip = "Chuyển lớp";
            // 
            // btnXoa
            // 
            this.btnXoa.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXoa.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(496, 254);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 68);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Tooltip = "Xóa học sinh khỏi lớp mới";
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.Image")));
            this.btnLuu.Location = new System.Drawing.Point(496, 339);
            this.btnLuu.Margin = new System.Windows.Forms.Padding(4);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 68);
            this.btnLuu.TabIndex = 6;
            this.btnLuu.Tooltip = "Lưu bảng phân lớp";
            // 
            // groupPanelLopMoi
            // 
            this.groupPanelLopMoi.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelLopMoi.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelLopMoi.Controls.Add(this.cmbLopMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX5);
            this.groupPanelLopMoi.Controls.Add(this.cmbKhoiLopMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX4);
            this.groupPanelLopMoi.Controls.Add(this.cmbNamHocMoi);
            this.groupPanelLopMoi.Controls.Add(this.labelX6);
            this.groupPanelLopMoi.Location = new System.Drawing.Point(577, 13);
            this.groupPanelLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.groupPanelLopMoi.Name = "groupPanelLopMoi";
            this.groupPanelLopMoi.Size = new System.Drawing.Size(481, 148);
            // 
            // 
            // 
            this.groupPanelLopMoi.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelLopMoi.Style.BackColorGradientAngle = 90;
            this.groupPanelLopMoi.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelLopMoi.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderBottomWidth = 1;
            this.groupPanelLopMoi.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelLopMoi.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderLeftWidth = 1;
            this.groupPanelLopMoi.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderRightWidth = 1;
            this.groupPanelLopMoi.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelLopMoi.Style.BorderTopWidth = 1;
            this.groupPanelLopMoi.Style.CornerDiameter = 4;
            this.groupPanelLopMoi.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelLopMoi.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelLopMoi.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelLopMoi.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelLopMoi.TabIndex = 7;
            this.groupPanelLopMoi.Text = "Thông tin lớp mới";
            // 
            // cmbLopMoi
            // 
            this.cmbLopMoi.DisplayMember = "Text";
            this.cmbLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLopMoi.FormattingEnabled = true;
            this.cmbLopMoi.ItemHeight = 14;
            this.cmbLopMoi.Location = new System.Drawing.Point(160, 86);
            this.cmbLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLopMoi.Name = "cmbLopMoi";
            this.cmbLopMoi.Size = new System.Drawing.Size(160, 20);
            this.cmbLopMoi.TabIndex = 3;
            // 
            // labelX5
            // 
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            this.labelX5.Location = new System.Drawing.Point(67, 49);
            this.labelX5.Margin = new System.Windows.Forms.Padding(4);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(76, 28);
            this.labelX5.TabIndex = 0;
            this.labelX5.Text = "Khối lớp:";
            // 
            // cmbKhoiLopMoi
            // 
            this.cmbKhoiLopMoi.DisplayMember = "Text";
            this.cmbKhoiLopMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbKhoiLopMoi.FormattingEnabled = true;
            this.cmbKhoiLopMoi.ItemHeight = 14;
            this.cmbKhoiLopMoi.Location = new System.Drawing.Point(160, 49);
            this.cmbKhoiLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbKhoiLopMoi.Name = "cmbKhoiLopMoi";
            this.cmbKhoiLopMoi.Size = new System.Drawing.Size(160, 20);
            this.cmbKhoiLopMoi.TabIndex = 2;
            // 
            // labelX4
            // 
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            this.labelX4.Location = new System.Drawing.Point(67, 12);
            this.labelX4.Margin = new System.Windows.Forms.Padding(4);
            this.labelX4.Name = "labelX4";
            this.labelX4.Size = new System.Drawing.Size(76, 25);
            this.labelX4.TabIndex = 0;
            this.labelX4.Text = "Năm học:";
            // 
            // cmbNamHocMoi
            // 
            this.cmbNamHocMoi.DisplayMember = "Text";
            this.cmbNamHocMoi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHocMoi.FormattingEnabled = true;
            this.cmbNamHocMoi.ItemHeight = 14;
            this.cmbNamHocMoi.Location = new System.Drawing.Point(160, 12);
            this.cmbNamHocMoi.Margin = new System.Windows.Forms.Padding(4);
            this.cmbNamHocMoi.Name = "cmbNamHocMoi";
            this.cmbNamHocMoi.Size = new System.Drawing.Size(160, 20);
            this.cmbNamHocMoi.TabIndex = 1;
            // 
            // labelX6
            // 
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            this.labelX6.Location = new System.Drawing.Point(67, 86);
            this.labelX6.Margin = new System.Windows.Forms.Padding(4);
            this.labelX6.Name = "labelX6";
            this.labelX6.Size = new System.Drawing.Size(76, 23);
            this.labelX6.TabIndex = 0;
            this.labelX6.Text = "Lớp:";
            // 
            // lvLopMoi
            // 
            // 
            // 
            // 
            this.lvLopMoi.Border.Class = "ListViewBorder";
            this.lvLopMoi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaHSMoi,
            this.colHoTenMoi});
            this.lvLopMoi.FullRowSelect = true;
            this.lvLopMoi.Location = new System.Drawing.Point(577, 169);
            this.lvLopMoi.Margin = new System.Windows.Forms.Padding(4);
            this.lvLopMoi.Name = "lvLopMoi";
            this.lvLopMoi.Size = new System.Drawing.Size(481, 238);
            this.lvLopMoi.TabIndex = 8;
            this.lvLopMoi.UseCompatibleStateImageBehavior = false;
            this.lvLopMoi.View = System.Windows.Forms.View.Details;
            // 
            // colMaHSMoi
            // 
            this.colMaHSMoi.Text = "Mã học sinh";
            this.colMaHSMoi.Width = 90;
            // 
            // colHoTenMoi
            // 
            this.colHoTenMoi.Text = "Họ và tên";
            this.colHoTenMoi.Width = 267;
            // 
            // Class_seperate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1086, 421);
            this.Controls.Add(this.lvLopMoi);
            this.Controls.Add(this.groupPanelLopMoi);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChuyen);
            this.Controls.Add(this.lvLopCu);
            this.Controls.Add(this.groupPanelLopCu);
            this.Name = "Class_seperate";
            this.Text = "PHÂN LỚP HỌC SINH";
            this.groupPanelLopCu.ResumeLayout(false);
            this.groupPanelLopMoi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLopCu;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocCu;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ListViewEx lvLopCu;
        private System.Windows.Forms.ColumnHeader colMaHSCu;
        private System.Windows.Forms.ColumnHeader colHoTenCu;
        private DevComponents.DotNetBar.ButtonX btnChuyen;
        private DevComponents.DotNetBar.ButtonX btnXoa;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelLopMoi;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLopMoi;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbKhoiLopMoi;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHocMoi;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.ListViewEx lvLopMoi;
        private System.Windows.Forms.ColumnHeader colMaHSMoi;
        private System.Windows.Forms.ColumnHeader colHoTenMoi;
    }
}