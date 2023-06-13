namespace DXApplication9
{
    partial class Score
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Score));
            this.buttonItemNhapDuLieu = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDanhSach = new System.Windows.Forms.GroupBox();
            this.ctxMenu = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnMenu = new DevComponents.DotNetBar.ButtonItem();
            this.btnXDiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnLDiem = new DevComponents.DotNetBar.ButtonItem();
            this.btnClose = new DevComponents.DotNetBar.ButtonItem();
            this.dgvDiem = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.colMaHocSinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemMieng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem15Phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiem45Phut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingNavigatorDiem = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnLuuDiem = new System.Windows.Forms.ToolStripButton();
            this.btnXemDiem = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.navPaneLeft = new DevComponents.DotNetBar.NavigationPane();
            this.navPanelNhapDuLieu = new DevComponents.DotNetBar.NavigationPanePanel();
            this.btnHienThiDanhSach = new DevComponents.DotNetBar.ButtonX();
            this.btnThemMonHoc = new DevComponents.DotNetBar.ButtonX();
            this.btnThemHocKy = new DevComponents.DotNetBar.ButtonX();
            this.btnThemNamHoc = new DevComponents.DotNetBar.ButtonX();
            this.btnThemLop = new DevComponents.DotNetBar.ButtonX();
            this.label01 = new System.Windows.Forms.Label();
            this.label02 = new System.Windows.Forms.Label();
            this.label04 = new System.Windows.Forms.Label();
            this.cmbMonHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbNamHoc = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbHocKy = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.cmbLop = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label03 = new System.Windows.Forms.Label();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.groupBoxDanhSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDiem)).BeginInit();
            this.bindingNavigatorDiem.SuspendLayout();
            this.navPaneLeft.SuspendLayout();
            this.navPanelNhapDuLieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonItemNhapDuLieu
            // 
            this.buttonItemNhapDuLieu.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItemNhapDuLieu.Checked = true;
            this.buttonItemNhapDuLieu.ImagePaddingHorizontal = 8;
            this.buttonItemNhapDuLieu.Name = "buttonItemNhapDuLieu";
            this.buttonItemNhapDuLieu.OptionGroup = "navBar";
            this.buttonItemNhapDuLieu.Text = "    Nhập điểm học sinh";
            // 
            // groupBoxDanhSach
            // 
            this.groupBoxDanhSach.Controls.Add(this.navPaneLeft);
            this.groupBoxDanhSach.Controls.Add(this.ctxMenu);
            this.groupBoxDanhSach.Controls.Add(this.dgvDiem);
            this.groupBoxDanhSach.Controls.Add(this.bindingNavigatorDiem);
            this.groupBoxDanhSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxDanhSach.Location = new System.Drawing.Point(0, 0);
            this.groupBoxDanhSach.Name = "groupBoxDanhSach";
            this.groupBoxDanhSach.Size = new System.Drawing.Size(909, 481);
            this.groupBoxDanhSach.TabIndex = 4;
            this.groupBoxDanhSach.TabStop = false;
            this.groupBoxDanhSach.Text = "Danh sách nhập điểm";
            // 
            // ctxMenu
            // 
            this.ctxMenu.DockSide = DevComponents.DotNetBar.eDockSide.Document;
            this.ctxMenu.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnMenu});
            this.ctxMenu.Location = new System.Drawing.Point(822, 19);
            this.ctxMenu.Name = "ctxMenu";
            this.ctxMenu.Size = new System.Drawing.Size(75, 25);
            this.ctxMenu.Stretch = true;
            this.ctxMenu.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.ctxMenu.TabIndex = 5;
            this.ctxMenu.TabStop = false;
            this.ctxMenu.Text = "ctxMenu";
            // 
            // btnMenu
            // 
            this.btnMenu.AutoExpandOnClick = true;
            this.btnMenu.ImagePaddingHorizontal = 8;
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Shape = new DevComponents.DotNetBar.RoundRectangleShapeDescriptor(2);
            this.btnMenu.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnXDiem,
            this.btnLDiem,
            this.btnClose});
            this.btnMenu.Text = "Menu";
            // 
            // btnXDiem
            // 
            this.btnXDiem.ImagePaddingHorizontal = 8;
            this.btnXDiem.Name = "btnXDiem";
            this.btnXDiem.Text = "Xem điểm";
            // 
            // btnLDiem
            // 
            this.btnLDiem.ImagePaddingHorizontal = 8;
            this.btnLDiem.Name = "btnLDiem";
            this.btnLDiem.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.CtrlS);
            this.btnLDiem.Text = "Lưu vào bảng điểm";
            // 
            // btnClose
            // 
            this.btnClose.ImagePaddingHorizontal = 8;
            this.btnClose.Name = "btnClose";
            this.btnClose.Shortcuts.Add(DevComponents.DotNetBar.eShortcut.AltF4);
            this.btnClose.Text = "Đóng cửa sổ này";
            // 
            // dgvDiem
            // 
            this.dgvDiem.AllowUserToAddRows = false;
            this.dgvDiem.AllowUserToDeleteRows = false;
            this.dgvDiem.AllowUserToResizeRows = false;
            this.dgvDiem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(243)))), ((int)(((byte)(250)))));
            this.dgvDiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colMaHocSinh,
            this.colHoTen,
            this.colDiemMieng,
            this.colDiem15Phut,
            this.colDiem45Phut,
            this.colDiemThi});
            this.ctxMenu.SetContextMenuEx(this.dgvDiem, this.btnMenu);
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDiem.DefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDiem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDiem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvDiem.Location = new System.Drawing.Point(3, 51);
            this.dgvDiem.Name = "dgvDiem";
            this.dgvDiem.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvDiem.Size = new System.Drawing.Size(903, 427);
            this.dgvDiem.TabIndex = 5;
            // 
            // colMaHocSinh
            // 
            this.colMaHocSinh.DataPropertyName = "MaHocSinh";
            this.colMaHocSinh.HeaderText = "Mã học sinh";
            this.colMaHocSinh.MaxInputLength = 6;
            this.colMaHocSinh.Name = "colMaHocSinh";
            this.colMaHocSinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colMaHocSinh.Width = 80;
            // 
            // colHoTen
            // 
            this.colHoTen.DataPropertyName = "HoTen";
            this.colHoTen.HeaderText = "Họ và tên";
            this.colHoTen.MaxInputLength = 30;
            this.colHoTen.Name = "colHoTen";
            this.colHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.colHoTen.Width = 155;
            // 
            // colDiemMieng
            // 
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDiemMieng.DefaultCellStyle = dataGridViewCellStyle6;
            this.colDiemMieng.HeaderText = "Điểm miệng";
            this.colDiemMieng.MaxInputLength = 30;
            this.colDiemMieng.Name = "colDiemMieng";
            this.colDiemMieng.Width = 90;
            // 
            // colDiem15Phut
            // 
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.colDiem15Phut.DefaultCellStyle = dataGridViewCellStyle7;
            this.colDiem15Phut.HeaderText = "Điểm 15 phút";
            this.colDiem15Phut.MaxInputLength = 30;
            this.colDiem15Phut.Name = "colDiem15Phut";
            this.colDiem15Phut.Width = 90;
            // 
            // colDiem45Phut
            // 
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Courier New", 9.75F);
            this.colDiem45Phut.DefaultCellStyle = dataGridViewCellStyle8;
            this.colDiem45Phut.HeaderText = "Điểm 45 phút";
            this.colDiem45Phut.MaxInputLength = 30;
            this.colDiem45Phut.Name = "colDiem45Phut";
            this.colDiem45Phut.Width = 90;
            // 
            // colDiemThi
            // 
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colDiemThi.DefaultCellStyle = dataGridViewCellStyle9;
            this.colDiemThi.HeaderText = "Điểm thi";
            this.colDiemThi.MaxInputLength = 8;
            this.colDiemThi.Name = "colDiemThi";
            this.colDiemThi.Width = 90;
            // 
            // bindingNavigatorDiem
            // 
            this.bindingNavigatorDiem.AddNewItem = null;
            this.bindingNavigatorDiem.AutoSize = false;
            this.bindingNavigatorDiem.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigatorDiem.CountItemFormat = "của {0}";
            this.bindingNavigatorDiem.DeleteItem = null;
            this.bindingNavigatorDiem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.btnLuuDiem,
            this.btnXemDiem,
            this.btnHelp});
            this.bindingNavigatorDiem.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigatorDiem.MoveFirstItem = null;
            this.bindingNavigatorDiem.MoveLastItem = null;
            this.bindingNavigatorDiem.MoveNextItem = null;
            this.bindingNavigatorDiem.MovePreviousItem = null;
            this.bindingNavigatorDiem.Name = "bindingNavigatorDiem";
            this.bindingNavigatorDiem.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigatorDiem.Size = new System.Drawing.Size(903, 35);
            this.bindingNavigatorDiem.TabIndex = 4;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 32);
            this.bindingNavigatorCountItem.Text = "của {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Tổng số dòng trong danh sách";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Vị trí hiện tại";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // btnLuuDiem
            // 
            this.btnLuuDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnLuuDiem.Image")));
            this.btnLuuDiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnLuuDiem.Name = "btnLuuDiem";
            this.btnLuuDiem.RightToLeftAutoMirrorImage = true;
            this.btnLuuDiem.Size = new System.Drawing.Size(77, 32);
            this.btnLuuDiem.Text = "Lưu điểm";
            
            // 
            // btnXemDiem
            // 
            this.btnXemDiem.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDiem.Image")));
            this.btnXemDiem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnXemDiem.Name = "btnXemDiem";
            this.btnXemDiem.RightToLeftAutoMirrorImage = true;
            this.btnXemDiem.Size = new System.Drawing.Size(81, 32);
            this.btnXemDiem.Text = "Xem điểm";
            // 
            // btnHelp
            // 
            this.btnHelp.AutoToolTip = false;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.RightToLeftAutoMirrorImage = true;
            this.btnHelp.Size = new System.Drawing.Size(23, 32);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton1.Text = "Đến đầu danh sách";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 32);
            this.toolStripButton2.Text = "Trở lại dòng trước";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveNextItem.Text = "Tới dòng kế tiếp";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 32);
            this.bindingNavigatorMoveLastItem.Text = "Đến cuối danh sách";
            // 
            // navPaneLeft
            // 
            this.navPaneLeft.CanCollapse = true;
            this.navPaneLeft.Controls.Add(this.navPanelNhapDuLieu);
            this.navPaneLeft.Dock = System.Windows.Forms.DockStyle.Right;
            this.navPaneLeft.ItemPaddingBottom = 2;
            this.navPaneLeft.ItemPaddingTop = 2;
            this.navPaneLeft.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.navPaneLeft.Location = new System.Drawing.Point(639, 51);
            this.navPaneLeft.Name = "navPaneLeft";
            this.navPaneLeft.NavigationBarHeight = 59;
            this.navPaneLeft.Padding = new System.Windows.Forms.Padding(1);
            this.navPaneLeft.Size = new System.Drawing.Size(267, 427);
            this.navPaneLeft.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TabIndex = 6;
            this.navPaneLeft.TitleButtonAlignment = DevComponents.DotNetBar.eTitleButtonAlignment.Left;
            // 
            // 
            // 
            this.navPaneLeft.TitlePanel.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPaneLeft.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.navPaneLeft.TitlePanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navPaneLeft.TitlePanel.Location = new System.Drawing.Point(1, 1);
            this.navPaneLeft.TitlePanel.Name = "panelTitle";
            this.navPaneLeft.TitlePanel.Size = new System.Drawing.Size(265, 24);
            this.navPaneLeft.TitlePanel.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.navPaneLeft.TitlePanel.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.navPaneLeft.TitlePanel.Style.Border = DevComponents.DotNetBar.eBorderType.RaisedInner;
            this.navPaneLeft.TitlePanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPaneLeft.TitlePanel.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Bottom;
            this.navPaneLeft.TitlePanel.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.navPaneLeft.TitlePanel.Style.GradientAngle = 90;
            this.navPaneLeft.TitlePanel.Style.MarginLeft = 4;
            this.navPaneLeft.TitlePanel.TabIndex = 0;
            this.navPaneLeft.TitlePanel.Text = "Nhập điểm học sinh";
            // 
            // navPanelNhapDuLieu
            // 
            this.navPanelNhapDuLieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.navPanelNhapDuLieu.Controls.Add(this.btnHienThiDanhSach);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemMonHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemHocKy);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemNamHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.btnThemLop);
            this.navPanelNhapDuLieu.Controls.Add(this.label01);
            this.navPanelNhapDuLieu.Controls.Add(this.label02);
            this.navPanelNhapDuLieu.Controls.Add(this.label04);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbMonHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbNamHoc);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbHocKy);
            this.navPanelNhapDuLieu.Controls.Add(this.cmbLop);
            this.navPanelNhapDuLieu.Controls.Add(this.label03);
            this.navPanelNhapDuLieu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navPanelNhapDuLieu.Location = new System.Drawing.Point(1, 25);
            this.navPanelNhapDuLieu.Name = "navPanelNhapDuLieu";
            this.navPanelNhapDuLieu.ParentItem = this.buttonItem1;
            this.navPanelNhapDuLieu.Size = new System.Drawing.Size(265, 342);
            this.navPanelNhapDuLieu.Style.Alignment = System.Drawing.StringAlignment.Center;
            this.navPanelNhapDuLieu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.navPanelNhapDuLieu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.navPanelNhapDuLieu.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.navPanelNhapDuLieu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.navPanelNhapDuLieu.Style.GradientAngle = 90;
            this.navPanelNhapDuLieu.TabIndex = 1;
            // 
            // btnHienThiDanhSach
            // 
            this.btnHienThiDanhSach.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHienThiDanhSach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnHienThiDanhSach.ColorTable = DevComponents.DotNetBar.eButtonColor.Blue;
            this.btnHienThiDanhSach.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHienThiDanhSach.Location = new System.Drawing.Point(17, 200);
            this.btnHienThiDanhSach.Name = "btnHienThiDanhSach";
            this.btnHienThiDanhSach.Size = new System.Drawing.Size(233, 23);
            this.btnHienThiDanhSach.TabIndex = 9;
            this.btnHienThiDanhSach.Text = "Hiển thị danh sách";
            // 
            // btnThemMonHoc
            // 
            this.btnThemMonHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemMonHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemMonHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemMonHoc.Image")));
            this.btnThemMonHoc.Location = new System.Drawing.Point(230, 160);
            this.btnThemMonHoc.Name = "btnThemMonHoc";
            this.btnThemMonHoc.Size = new System.Drawing.Size(20, 20);
            this.btnThemMonHoc.TabIndex = 8;
            // 
            // btnThemHocKy
            // 
            this.btnThemHocKy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemHocKy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemHocKy.Image = ((System.Drawing.Image)(resources.GetObject("btnThemHocKy.Image")));
            this.btnThemHocKy.Location = new System.Drawing.Point(230, 115);
            this.btnThemHocKy.Name = "btnThemHocKy";
            this.btnThemHocKy.Size = new System.Drawing.Size(20, 20);
            this.btnThemHocKy.TabIndex = 6;
            // 
            // btnThemNamHoc
            // 
            this.btnThemNamHoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemNamHoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemNamHoc.Image = ((System.Drawing.Image)(resources.GetObject("btnThemNamHoc.Image")));
            this.btnThemNamHoc.Location = new System.Drawing.Point(230, 25);
            this.btnThemNamHoc.Name = "btnThemNamHoc";
            this.btnThemNamHoc.Size = new System.Drawing.Size(20, 20);
            this.btnThemNamHoc.TabIndex = 2;
            // 
            // btnThemLop
            // 
            this.btnThemLop.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThemLop.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThemLop.Image = ((System.Drawing.Image)(resources.GetObject("btnThemLop.Image")));
            this.btnThemLop.Location = new System.Drawing.Point(230, 70);
            this.btnThemLop.Name = "btnThemLop";
            this.btnThemLop.Size = new System.Drawing.Size(20, 20);
            this.btnThemLop.TabIndex = 4;
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(14, 10);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(53, 13);
            this.label01.TabIndex = 0;
            this.label01.Text = "Năm học:";
            // 
            // label02
            // 
            this.label02.AutoSize = true;
            this.label02.Location = new System.Drawing.Point(14, 55);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(28, 13);
            this.label02.TabIndex = 0;
            this.label02.Text = "Lớp:";
            // 
            // label04
            // 
            this.label04.AutoSize = true;
            this.label04.Location = new System.Drawing.Point(14, 145);
            this.label04.Name = "label04";
            this.label04.Size = new System.Drawing.Size(52, 13);
            this.label04.TabIndex = 0;
            this.label04.Text = "Môn học:";
            // 
            // cmbMonHoc
            // 
            this.cmbMonHoc.DisplayMember = "Text";
            this.cmbMonHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbMonHoc.FormattingEnabled = true;
            this.cmbMonHoc.ItemHeight = 14;
            this.cmbMonHoc.Location = new System.Drawing.Point(17, 160);
            this.cmbMonHoc.Name = "cmbMonHoc";
            this.cmbMonHoc.Size = new System.Drawing.Size(207, 20);
            this.cmbMonHoc.TabIndex = 7;
            // 
            // cmbNamHoc
            // 
            this.cmbNamHoc.DisplayMember = "Text";
            this.cmbNamHoc.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNamHoc.FormattingEnabled = true;
            this.cmbNamHoc.ItemHeight = 14;
            this.cmbNamHoc.Location = new System.Drawing.Point(17, 25);
            this.cmbNamHoc.Name = "cmbNamHoc";
            this.cmbNamHoc.Size = new System.Drawing.Size(207, 20);
            this.cmbNamHoc.TabIndex = 1;
            // 
            // cmbHocKy
            // 
            this.cmbHocKy.DisplayMember = "Text";
            this.cmbHocKy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbHocKy.FormattingEnabled = true;
            this.cmbHocKy.ItemHeight = 14;
            this.cmbHocKy.Location = new System.Drawing.Point(17, 115);
            this.cmbHocKy.Name = "cmbHocKy";
            this.cmbHocKy.Size = new System.Drawing.Size(207, 20);
            this.cmbHocKy.TabIndex = 5;
            // 
            // cmbLop
            // 
            this.cmbLop.DisplayMember = "Text";
            this.cmbLop.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbLop.FormattingEnabled = true;
            this.cmbLop.ItemHeight = 14;
            this.cmbLop.Location = new System.Drawing.Point(17, 70);
            this.cmbLop.Name = "cmbLop";
            this.cmbLop.Size = new System.Drawing.Size(207, 20);
            this.cmbLop.TabIndex = 3;
            // 
            // label03
            // 
            this.label03.AutoSize = true;
            this.label03.Location = new System.Drawing.Point(14, 100);
            this.label03.Name = "label03";
            this.label03.Size = new System.Drawing.Size(44, 13);
            this.label03.TabIndex = 0;
            this.label03.Text = "Học kỳ:";
            // 
            // buttonItem1
            // 
            this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
            this.buttonItem1.Checked = true;
            this.buttonItem1.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground;
            this.buttonItem1.Image = ((System.Drawing.Image)(resources.GetObject("buttonItem1.Image")));
            this.buttonItem1.ImagePaddingHorizontal = 8;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.OptionGroup = "navBar";
            this.buttonItem1.Text = "    Nhập điểm học sinh";
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 481);
            this.Controls.Add(this.groupBoxDanhSach);
            this.Name = "Score";
            this.Text = "Score";
            
            this.groupBoxDanhSach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigatorDiem)).EndInit();
            this.bindingNavigatorDiem.ResumeLayout(false);
            this.bindingNavigatorDiem.PerformLayout();
            this.navPaneLeft.ResumeLayout(false);
            this.navPanelNhapDuLieu.ResumeLayout(false);
            this.navPanelNhapDuLieu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonItem buttonItemNhapDuLieu;
        private System.Windows.Forms.GroupBox groupBoxDanhSach;
        private DevComponents.DotNetBar.ContextMenuBar ctxMenu;
        private DevComponents.DotNetBar.ButtonItem btnMenu;
        private DevComponents.DotNetBar.ButtonItem btnXDiem;
        private DevComponents.DotNetBar.ButtonItem btnLDiem;
        private DevComponents.DotNetBar.ButtonItem btnClose;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaHocSinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemMieng;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem15Phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiem45Phut;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemThi;
        private System.Windows.Forms.BindingNavigator bindingNavigatorDiem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton btnLuuDiem;
        private System.Windows.Forms.ToolStripButton btnXemDiem;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private DevComponents.DotNetBar.NavigationPane navPaneLeft;
        private DevComponents.DotNetBar.NavigationPanePanel navPanelNhapDuLieu;
        private DevComponents.DotNetBar.ButtonX btnHienThiDanhSach;
        private DevComponents.DotNetBar.ButtonX btnThemMonHoc;
        private DevComponents.DotNetBar.ButtonX btnThemHocKy;
        private DevComponents.DotNetBar.ButtonX btnThemNamHoc;
        private DevComponents.DotNetBar.ButtonX btnThemLop;
        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.Label label04;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbMonHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbNamHoc;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbHocKy;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbLop;
        private System.Windows.Forms.Label label03;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
    }
}