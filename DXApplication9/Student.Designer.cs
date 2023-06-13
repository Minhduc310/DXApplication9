namespace DXApplication9
{
    partial class Student
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.txtGioiTinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.navPaneRight = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.naviPanelNhapDuLieu = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnLuuVaoDS = new DevComponents.DotNetBar.ButtonX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDiaChi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTenHocSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtMaHocSinh = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.groupPanelGioiTinh = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.ckbGTinhNu = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.ckbGTinhNam = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblTenHocSinh = new System.Windows.Forms.Label();
            this.lblMaHocSinh = new System.Windows.Forms.Label();
            this.navPanelTimKiem = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.btnTimKiem = new DevComponents.DotNetBar.ButtonX();
            this.chkTimTheoTen = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.chkTimTheoMa = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.txtTimKiem = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblNhapThongTinTimKiem = new System.Windows.Forms.Label();
            this.dgvHocSinh = new System.Windows.Forms.DataGridView();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGioitinh = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorHocSinh = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorRefreshItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navPaneRight)).BeginInit();
            this.navPaneRight.SuspendLayout();
            this.naviPanelNhapDuLieu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh)).BeginInit();
            this.groupPanelGioiTinh.SuspendLayout();
            this.navPanelTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).BeginInit();
            this.bindingNavigatorHocSinh.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.txtGioiTinh);
            this.groupBoxDanhSach.Controls.Add(this.navPaneRight);
            this.groupBoxDanhSach.Controls.Add(this.dgvHocSinh);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorHocSinh);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxDanhSach.Size = new System.Drawing.Size(1255, 584);
            this.groupBoxDanhSach.TabIndex = 0;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách học sinh";
            // 
            // txtGioiTinh
            // 
            // 
            // 
            // 
            this.txtGioiTinh.Border.Class = "TextBoxBorder";
            this.txtGioiTinh.Location = new System.Drawing.Point(1084, 19);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.Size = new System.Drawing.Size(100, 22);
            this.txtGioiTinh.TabIndex = 6;
            // 
            // navPaneRight
            // 
            this.navPaneRight.Controls.Add(this.naviPanelNhapDuLieu);
            this.navPaneRight.Controls.Add(this.navPanelTimKiem);
            this.navPaneRight.Location = new System.Drawing.Point(833, 47);
            this.navPaneRight.Name = "navPaneRight";
            this.navPaneRight.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.naviPanelNhapDuLieu,
            this.navPanelTimKiem});
            this.navPaneRight.RegularSize = new System.Drawing.Size(418, 525);
            this.navPaneRight.SelectedPage = this.navPanelTimKiem;
            this.navPaneRight.Size = new System.Drawing.Size(418, 525);
            this.navPaneRight.TabIndex = 1;
            // 
            // naviPanelNhapDuLieu
            // 
            this.naviPanelNhapDuLieu.Caption = "Nhập liệu thông tin";
            this.naviPanelNhapDuLieu.Controls.Add(this.btnLuuVaoDS);
            this.naviPanelNhapDuLieu.Controls.Add(this.txtEmail);
            this.naviPanelNhapDuLieu.Controls.Add(this.txtDiaChi);
            this.naviPanelNhapDuLieu.Controls.Add(this.txtTenHocSinh);
            this.naviPanelNhapDuLieu.Controls.Add(this.txtMaHocSinh);
            this.naviPanelNhapDuLieu.Controls.Add(this.lblEmail);
            this.naviPanelNhapDuLieu.Controls.Add(this.lblDiaChi);
            this.naviPanelNhapDuLieu.Controls.Add(this.dtpNgaySinh);
            this.naviPanelNhapDuLieu.Controls.Add(this.groupPanelGioiTinh);
            this.naviPanelNhapDuLieu.Controls.Add(this.lblGioiTinh);
            this.naviPanelNhapDuLieu.Controls.Add(this.lblNgaySinh);
            this.naviPanelNhapDuLieu.Controls.Add(this.lblTenHocSinh);
            this.naviPanelNhapDuLieu.Controls.Add(this.lblMaHocSinh);
            this.naviPanelNhapDuLieu.Name = "naviPanelNhapDuLieu";
            this.naviPanelNhapDuLieu.Size = new System.Drawing.Size(269, 455);
            // 
            // btnLuuVaoDS
            // 
            this.btnLuuVaoDS.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuuVaoDS.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnLuuVaoDS.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnLuuVaoDS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuuVaoDS.ForeColor = System.Drawing.Color.Black;
            this.btnLuuVaoDS.Location = new System.Drawing.Point(17, 350);
            this.btnLuuVaoDS.Name = "btnLuuVaoDS";
            this.btnLuuVaoDS.Size = new System.Drawing.Size(244, 23);
            this.btnLuuVaoDS.TabIndex = 17;
            this.btnLuuVaoDS.Text = "Lưu vào danh sách";
            this.btnLuuVaoDS.Click += new System.EventHandler(this.btnLuuVaoDS_Click);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Location = new System.Drawing.Point(17, 309);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(244, 22);
            this.txtEmail.TabIndex = 12;
            // 
            // txtDiaChi
            // 
            // 
            // 
            // 
            this.txtDiaChi.Border.Class = "TextBoxBorder";
            this.txtDiaChi.Location = new System.Drawing.Point(17, 253);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(244, 22);
            this.txtDiaChi.TabIndex = 11;
            // 
            // txtTenHocSinh
            // 
            // 
            // 
            // 
            this.txtTenHocSinh.Border.Class = "TextBoxBorder";
            this.txtTenHocSinh.Location = new System.Drawing.Point(17, 83);
            this.txtTenHocSinh.Name = "txtTenHocSinh";
            this.txtTenHocSinh.Size = new System.Drawing.Size(244, 22);
            this.txtTenHocSinh.TabIndex = 10;
            // 
            // txtMaHocSinh
            // 
            // 
            // 
            // 
            this.txtMaHocSinh.Border.Class = "TextBoxBorder";
            this.txtMaHocSinh.Location = new System.Drawing.Point(17, 33);
            this.txtMaHocSinh.Name = "txtMaHocSinh";
            this.txtMaHocSinh.Size = new System.Drawing.Size(244, 22);
            this.txtMaHocSinh.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Location = new System.Drawing.Point(19, 290);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 7;
            this.lblEmail.Text = "Email";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Location = new System.Drawing.Point(19, 234);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(47, 16);
            this.lblDiaChi.TabIndex = 4;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.dtpNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgaySinh.ButtonDropDown.Visible = true;
            this.dtpNgaySinh.Location = new System.Drawing.Point(17, 193);
            this.dtpNgaySinh.MaxDate = new System.DateTime(2050, 12, 31, 0, 0, 0, 0);
            this.dtpNgaySinh.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.AnnuallyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.BackgroundStyle.BackColor = System.Drawing.SystemColors.Window;
            this.dtpNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2023, 6, 1, 0, 0, 0, 0);
            this.dtpNgaySinh.MonthCalendar.MarkedDates = new System.DateTime[0];
            this.dtpNgaySinh.MonthCalendar.MonthlyMarkedDates = new System.DateTime[0];
            // 
            // 
            // 
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(244, 22);
            this.dtpNgaySinh.TabIndex = 2;
            // 
            // groupPanelGioiTinh
            // 
            this.groupPanelGioiTinh.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanelGioiTinh.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanelGioiTinh.Controls.Add(this.ckbGTinhNu);
            this.groupPanelGioiTinh.Controls.Add(this.ckbGTinhNam);
            this.groupPanelGioiTinh.Location = new System.Drawing.Point(17, 127);
            this.groupPanelGioiTinh.Name = "groupPanelGioiTinh";
            this.groupPanelGioiTinh.Size = new System.Drawing.Size(244, 35);
            // 
            // 
            // 
            this.groupPanelGioiTinh.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanelGioiTinh.Style.BackColorGradientAngle = 90;
            this.groupPanelGioiTinh.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanelGioiTinh.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderBottomWidth = 1;
            this.groupPanelGioiTinh.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanelGioiTinh.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderLeftWidth = 1;
            this.groupPanelGioiTinh.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderRightWidth = 1;
            this.groupPanelGioiTinh.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanelGioiTinh.Style.BorderTopWidth = 1;
            this.groupPanelGioiTinh.Style.CornerDiameter = 4;
            this.groupPanelGioiTinh.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanelGioiTinh.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanelGioiTinh.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanelGioiTinh.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            this.groupPanelGioiTinh.TabIndex = 2;
            // 
            // ckbGTinhNu
            // 
            this.ckbGTinhNu.BackColor = System.Drawing.Color.Transparent;
            this.ckbGTinhNu.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbGTinhNu.Location = new System.Drawing.Point(148, 3);
            this.ckbGTinhNu.Name = "ckbGTinhNu";
            this.ckbGTinhNu.Size = new System.Drawing.Size(75, 23);
            this.ckbGTinhNu.TabIndex = 1;
            this.ckbGTinhNu.Text = "Nữ";
            // 
            // ckbGTinhNam
            // 
            this.ckbGTinhNam.BackColor = System.Drawing.Color.Transparent;
            this.ckbGTinhNam.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.ckbGTinhNam.Location = new System.Drawing.Point(19, 3);
            this.ckbGTinhNam.Name = "ckbGTinhNam";
            this.ckbGTinhNam.Size = new System.Drawing.Size(75, 23);
            this.ckbGTinhNam.TabIndex = 0;
            this.ckbGTinhNam.Text = "Nam";
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Location = new System.Drawing.Point(19, 108);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(57, 16);
            this.lblGioiTinh.TabIndex = 3;
            this.lblGioiTinh.Text = "Giới tính:";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.lblNgaySinh.Location = new System.Drawing.Point(19, 174);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(70, 16);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // lblTenHocSinh
            // 
            this.lblTenHocSinh.AutoSize = true;
            this.lblTenHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.lblTenHocSinh.Location = new System.Drawing.Point(14, 61);
            this.lblTenHocSinh.Name = "lblTenHocSinh";
            this.lblTenHocSinh.Size = new System.Drawing.Size(86, 16);
            this.lblTenHocSinh.TabIndex = 0;
            this.lblTenHocSinh.Text = "Tên học sinh:";
            // 
            // lblMaHocSinh
            // 
            this.lblMaHocSinh.AutoSize = true;
            this.lblMaHocSinh.BackColor = System.Drawing.Color.Transparent;
            this.lblMaHocSinh.Location = new System.Drawing.Point(14, 14);
            this.lblMaHocSinh.Name = "lblMaHocSinh";
            this.lblMaHocSinh.Size = new System.Drawing.Size(81, 16);
            this.lblMaHocSinh.TabIndex = 0;
            this.lblMaHocSinh.Text = "Mã học sinh:";
            // 
            // navPanelTimKiem
            // 
            this.navPanelTimKiem.Caption = "Tìm kiếm học sinh";
            this.navPanelTimKiem.Controls.Add(this.btnTimKiem);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoTen);
            this.navPanelTimKiem.Controls.Add(this.chkTimTheoMa);
            this.navPanelTimKiem.Controls.Add(this.txtTimKiem);
            this.navPanelTimKiem.Controls.Add(this.lblNhapThongTinTimKiem);
            this.navPanelTimKiem.Name = "navPanelTimKiem";
            this.navPanelTimKiem.Size = new System.Drawing.Size(269, 455);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTimKiem.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnTimKiem.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Black;
            this.btnTimKiem.Location = new System.Drawing.Point(19, 127);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(247, 23);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // chkTimTheoTen
            // 
            this.chkTimTheoTen.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoTen.Location = new System.Drawing.Point(19, 98);
            this.chkTimTheoTen.Name = "chkTimTheoTen";
            this.chkTimTheoTen.Size = new System.Drawing.Size(247, 23);
            this.chkTimTheoTen.TabIndex = 4;
            this.chkTimTheoTen.Text = "Tìm theo tên học sinh";
            // 
            // chkTimTheoMa
            // 
            this.chkTimTheoMa.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.chkTimTheoMa.Checked = true;
            this.chkTimTheoMa.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkTimTheoMa.CheckValue = "Y";
            this.chkTimTheoMa.Location = new System.Drawing.Point(19, 69);
            this.chkTimTheoMa.Name = "chkTimTheoMa";
            this.chkTimTheoMa.Size = new System.Drawing.Size(247, 23);
            this.chkTimTheoMa.TabIndex = 3;
            this.chkTimTheoMa.Text = "Tìm theo mã học sinh";
            // 
            // txtTimKiem
            // 
            // 
            // 
            // 
            this.txtTimKiem.Border.Class = "TextBoxBorder";
            this.txtTimKiem.Location = new System.Drawing.Point(19, 31);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(247, 22);
            this.txtTimKiem.TabIndex = 1;
            this.txtTimKiem.WatermarkText = "Nhập thông tin cần tìm vào đây";
            // 
            // lblNhapThongTinTimKiem
            // 
            this.lblNhapThongTinTimKiem.AutoSize = true;
            this.lblNhapThongTinTimKiem.Location = new System.Drawing.Point(16, 12);
            this.lblNhapThongTinTimKiem.Name = "lblNhapThongTinTimKiem";
            this.lblNhapThongTinTimKiem.Size = new System.Drawing.Size(147, 16);
            this.lblNhapThongTinTimKiem.TabIndex = 0;
            this.lblNhapThongTinTimKiem.Text = "Nhập thông tin tìm kiếm:";
            // 
            // dgvHocSinh
            // 
            this.dgvHocSinh.AllowUserToAddRows = false;
            this.dgvHocSinh.AllowUserToResizeRows = false;
            this.dgvHocSinh.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHocSinh.ColumnHeadersHeight = 29;
            this.dgvHocSinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHocSinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colGioitinh,
            this.colNgaySinh,
            this.colDiaChi,
            this.colEmail});
            this.dgvHocSinh.Location = new System.Drawing.Point(0, 47);
            this.dgvHocSinh.Name = "dgvHocSinh";
            this.dgvHocSinh.RowHeadersWidth = 51;
            this.dgvHocSinh.RowTemplate.Height = 24;
            this.dgvHocSinh.Size = new System.Drawing.Size(827, 530);
            this.dgvHocSinh.TabIndex = 5;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã học sinh";
            this.colMaHocSinh.MaxInputLength = 6;
            this.colMaHocSinh.MinimumWidth = 6;
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.Width = 125;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MaxInputLength = 30;
            this.colHoTen.MinimumWidth = 6;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Width = 150;
            // 
            // colGioitinh
            // 
            this.colGioitinh.DataPropertyName = "GioiTinh";
            this.colGioitinh.HeaderText = "Giới tính nữ";
            this.colGioitinh.MinimumWidth = 6;
            this.colGioitinh.Name = "colGioitinh";
            this.colGioitinh.Width = 70;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.DataPropertyName = "NgaySinh";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy";
            this.colNgaySinh.DefaultCellStyle = dataGridViewCellStyle1;
            this.colNgaySinh.HeaderText = "Ngày sinh";
            this.colNgaySinh.MinimumWidth = 6;
            this.colNgaySinh.Name = "colNgaySinh";
            this.colNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.colNgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colNgaySinh.Width = 85;
            // 
            // colDiaChi
            // 
            this.colDiaChi.DataPropertyName = "DiaChi";
            this.colDiaChi.HeaderText = "Địa chỉ";
            this.colDiaChi.MaxInputLength = 50;
            this.colDiaChi.MinimumWidth = 6;
            this.colDiaChi.Name = "colDiaChi";
            this.colDiaChi.Width = 150;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.MinimumWidth = 6;
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 150;
            // 
            // bindingNavigatorHocSinh
            // 
            this.bindingNavigatorHocSinh.AddNewItem = null;
            this.bindingNavigatorHocSinh.AutoSize = false;
            this.bindingNavigatorHocSinh.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorHocSinh.CountItemFormat = "của {0}";
            this.bindingNavigatorHocSinh.DeleteItem = null;
            this.bindingNavigatorHocSinh.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.bindingNavigatorHocSinh.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bindingNavigatorRefreshItem,
            this.bindingNavigatorSaveItem});
            this.bindingNavigatorHocSinh.Location = new System.Drawing.Point(4, 19);
            this.bindingNavigatorHocSinh.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigatorHocSinh.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigatorHocSinh.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigatorHocSinh.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigatorHocSinh.Name = "bindingNavigatorHocSinh";
            this.bindingNavigatorHocSinh.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorHocSinh.Size = new System.Drawing.Size(1247, 25);
            this.bindingNavigatorHocSinh.TabIndex = 4;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(54, 22);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Đến đầu danh sách";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Trở lại dòng trước";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorAddNewItem.Text = "Thêm ";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorDeleteItem.Text = "Xoá";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorRefreshItem
            // 
            this.bindingNavigatorRefreshItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorRefreshItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorRefreshItem.Image")));
            this.bindingNavigatorRefreshItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorRefreshItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorRefreshItem.Name = "bindingNavigatorRefreshItem";
            this.bindingNavigatorRefreshItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorRefreshItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorRefreshItem.Text = "Làm mới danh sách";
            this.bindingNavigatorRefreshItem.Click += new System.EventHandler(this.bindingNavigatorRefreshItem_Click);
            // 
            // bindingNavigatorSaveItem
            // 
            this.bindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorSaveItem.Image")));
            this.bindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorSaveItem.Name = "bindingNavigatorSaveItem";
            this.bindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 22);
            this.bindingNavigatorSaveItem.Text = "Lưu";
            this.bindingNavigatorSaveItem.Click += new System.EventHandler(this.bindingNavigatorSaveItem_Click);
            // 
            // Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 584);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Name = "Student";
            this.Text = "Học sinh";
            this.Load += new System.EventHandler(this.Student_Load);
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navPaneRight)).EndInit();
            this.navPaneRight.ResumeLayout(false);
            this.naviPanelNhapDuLieu.ResumeLayout(false);
            this.naviPanelNhapDuLieu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh)).EndInit();
            this.groupPanelGioiTinh.ResumeLayout(false);
            this.navPanelTimKiem.ResumeLayout(false);
            this.navPanelTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHocSinh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorHocSinh)).EndInit();
            this.bindingNavigatorHocSinh.ResumeLayout(false);
            this.bindingNavigatorHocSinh.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private System.Windows.Forms.BindingNavigator bindingNavigatorHocSinh;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.DataGridView dgvHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.ToolStripButton bindingNavigatorRefreshItem;
        private DevExpress.XtraBars.Navigation.NavigationPane navPaneRight;
        private DevExpress.XtraBars.Navigation.NavigationPage naviPanelNhapDuLieu;
        private DevExpress.XtraBars.Navigation.NavigationPage navPanelTimKiem;
        private System.Windows.Forms.Label lblGioiTinh;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblTenHocSinh;
        private System.Windows.Forms.Label lblMaHocSinh;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanelGioiTinh;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbGTinhNu;
        private DevComponents.DotNetBar.Controls.CheckBoxX ckbGTinhNam;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTenHocSinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaHocSinh;
        private DevComponents.DotNetBar.Controls.TextBoxX txtDiaChi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.Controls.TextBoxX txtGioiTinh;
        private DevComponents.DotNetBar.ButtonX btnLuuVaoDS;
        private System.Windows.Forms.Label lblNhapThongTinTimKiem;
        private DevComponents.DotNetBar.ButtonX btnTimKiem;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoTen;
        private DevComponents.DotNetBar.Controls.CheckBoxX chkTimTheoMa;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTimKiem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorSaveItem;
    }
}