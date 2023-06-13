using System;
using System.Diagnostics;
using DXApplication9.BUS;
using DevComponents.DotNetBar;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication9;
using DXApplication9.Components;

namespace DXApplication9
{
    public partial class Main_page : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Log_in frmLogin = null;
        Password_change frmChangePass = null;
        
        public Main_page()
        {
            InitializeComponent();
            HienThiVersion();
        }

        private void HienThiVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            Text += $" v.{versionInfo.FileVersion}";
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
            Show();
            CenterToScreen();
            ShowGiaoDienMacDinh();
            btnDangNhap_ItemClick(sender, e);
        }
        


        private void btnDangNhap_ItemClick(object sender, EventArgs e)
        {
            while (true)
            {
                if (frmLogin == null || frmLogin.IsDisposed) frmLogin = new Log_in();
                if (frmLogin.ShowDialog() != DialogResult.OK) return;

                string username = frmLogin.txtUsername.Text;
                string password = frmLogin.txtPassword.Text;

                if (string.IsNullOrWhiteSpace(username))
                {
                    frmLogin.lblPassError.Text = "";
                    frmLogin.lblUserError.Text = "Bạn chưa nhập tên!";
                    continue;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    frmLogin.lblUserError.Text = "";
                    frmLogin.lblPassError.Text = "Bạn chưa nhập mật khẩu !";
                    continue;
                }

                if (NguoiDungBUS.Instance.DangNhap(username, password))
                {
                    string maLoai = NguoiDungBUS.Instance.NguoiDung.LoaiNguoiDung.MaLoai;
                    if (maLoai == "LND1") ShowGiaoDienBGH();
                    else if (maLoai == "LND2") ShowGiaoDienGiaoVien();
                    else if (maLoai == "LND3") ShowGiaoDienGiaoVu();
                    else ShowGiaoDienMacDinh();

                    string tenNguoiDung = NguoiDungBUS.Instance.NguoiDung.TenNguoiDung;
                    lblTenNguoiDung.Text = tenNguoiDung;
                    frmLogin.lblUserError.Text = "";
                    frmLogin.lblPassError.Text = "";
                    return;
                }
                else
                {
                    frmLogin.lblUserError.Text = "Thông tin không chính xác !";
                    frmLogin.lblPassError.Text = "Thông tin không chính xác !";
                    continue;
                }
            }

        }

        private void btnDangXuat_ItemClick(object sender, EventArgs e)
        {
            frmLogin.txtUsername.Text = "";
            frmLogin.txtPassword.Text = "";
            lblTenNguoiDung.Text = "Không có";

            foreach (Form form in MdiChildren) form.Close();
            ShowGiaoDienMacDinh();
        }

        private void btnDoiMatKhau_ItemClick(object sender, EventArgs e)
        {
            while (true)
            {
                if (frmChangePass == null || frmChangePass.IsDisposed) frmChangePass = new Password_change();
                if (frmChangePass.ShowDialog() != DialogResult.OK) return;

                string username = frmLogin.txtUsername.Text;
                string password = frmLogin.txtPassword.Text;

                string oldPassword = frmChangePass.txtOldPassword.Text;
                string newPassword = frmChangePass.txtNewPassword.Text;
                string confirmPassword = frmChangePass.txtConfirmPassword.Text;

                if (string.IsNullOrWhiteSpace(oldPassword))
                {
                    frmChangePass.lblOldPassError.Text = "Chưa nhập mật khẩu hiện tại!";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "";
                    continue;
                }

                if (string.IsNullOrWhiteSpace(newPassword))
                {
                    frmChangePass.lblOldPassError.Text = "";
                    frmChangePass.lblNewPassError.Text = "Chưa nhập mật khẩu mới!";
                    frmChangePass.lblConfirmPassError.Text = "";
                    continue;
                }

                if (string.IsNullOrWhiteSpace(confirmPassword))
                {
                    frmChangePass.lblOldPassError.Text = "";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "Chưa nhập xác nhận mật khẩu!";
                    continue;
                }

                if (password != oldPassword)
                {
                    frmChangePass.lblOldPassError.Text = "Nhập sai mật khẩu cũ!";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "";
                    continue;
                }
                else if (newPassword != confirmPassword)
                {
                    frmChangePass.lblOldPassError.Text = "";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "Nhập xác nhận không khớp!";
                    continue;
                }
                else
                {
                    NguoiDungBUS.Instance.DoiMatKhau(username, newPassword);
                    MessageBox.Show("Đổi mật khẩu thành công!", "PASSWORD CHANGED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    frmChangePass.txtOldPassword.Text = "";
                    frmChangePass.txtNewPassword.Text = "";
                    frmChangePass.txtConfirmPassword.Text = "";
                    frmChangePass.lblOldPassError.Text = "";
                    frmChangePass.lblNewPassError.Text = "";
                    frmChangePass.lblConfirmPassError.Text = "";
                    return;
                }
            }
        }

        private void btnSaoLuu_ItemClick(object sender, EventArgs e)
        {
            if (backupDialog.ShowDialog() != DialogResult.OK) return;
            NguoiDungBUS.Instance.SaoLuuCSDL(backupDialog.FileName.ToString());
            MessageBox.Show("Sao lưu dữ liệu thành công!", "BACKUP COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPhucHoi_ItemClick(object sender, EventArgs e)
        {
            if (restoreDialog.ShowDialog() != DialogResult.OK) return;
            NguoiDungBUS.Instance.SaoLuuCSDL(restoreDialog.FileName.ToString());
            MessageBox.Show("Phục hồi dữ liệu thành công!", "RESTORE COMPLETED", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnQLNguoiDung_ItemClick(object sender, EventArgs e)
        {
            Utilities.ShowForm("Users");
        }

        private void btnThoat_ItemClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btnHocSinh_ItemClick(object sender, EventArgs e)
        {
            Utilities.ShowForm("Student");
        }

        private void btnDoTuoi_ItemClick(object sender, EventArgs e)
        {
            Utilities.ShowForm("Quy_dinh", false);
        }

        private void btnSiSo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.ShowForm("Quy_dinh", false);
        }

        private void btnDiemDat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.ShowForm("Quy_dinh", false);
        }

        private void btnThayDoiQuyDinh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.ShowForm("Thay_đổi_quy_định", false);
        }


        #region Giao diện mặc định
        public void ShowGiaoDienMacDinh()
        {
            //True
            btnDangNhap.Enabled = true;
            btnThoat.Enabled = true;

            //False
            btnDangXuat.Enabled = false;
            btnDoiMatKhau.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnQLNguoiDung.Enabled = false;

            btnLopHoc.Enabled = false;
            btnKhoiLop.Enabled = false;
            btnHocKy.Enabled = false;
            btnNamHoc.Enabled = false;
            btnMonHoc.Enabled = false;
            btnDiem.Enabled = false;
            btnKetQua.Enabled = false;
            btnHocLuc.Enabled = false;
            btnHanhKiem.Enabled = false;
            btnHocSinh.Enabled = false;
            btnPhanLop.Enabled = false;

            btnKQHSMonHoc.Enabled = false;
            btnKQHSCaNam.Enabled = false;
            btnKQLHMonHoc.Enabled = false;
            btnKQLHHocKy.Enabled = false;
            btnDanhSachHocSinh.Enabled = false;
            btnHoSoLopHoc.Enabled = false;

            btnSiSo.Enabled = false;
            btnDiemDat.Enabled = false;
            btnDoTuoi.Enabled = false;
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền BGH
        public void ShowGiaoDienBGH()
        {
            //False
            btnDangNhap.Enabled = false;

            //True
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnSaoLuu.Enabled = true;
            btnPhucHoi.Enabled = true;
            btnThoat.Enabled = true;
            btnQLNguoiDung.Enabled = true;

            btnLopHoc.Enabled = true;
            btnKhoiLop.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
            btnKetQua.Enabled = true;
            btnHocLuc.Enabled = true;
            btnHanhKiem.Enabled = true;
            btnHocSinh.Enabled = true;
            btnPhanLop.Enabled = true;

            btnKQHSMonHoc.Enabled = true;
            btnKQHSCaNam.Enabled = true;
            btnKQLHMonHoc.Enabled = true;
            btnKQLHHocKy.Enabled = true;
            btnDanhSachHocSinh.Enabled = true;
            btnHoSoLopHoc.Enabled = true;

            btnSiSo.Enabled = true;
            btnDiemDat.Enabled = true;
            btnDoTuoi.Enabled = true;
            btnThayDoiQuyDinh.Enabled = true;
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền Giáo viên
        public void ShowGiaoDienGiaoVien()
        {
            //True
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnThoat.Enabled = true;

            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;

            btnKQHSMonHoc.Enabled = true;
            btnKQHSCaNam.Enabled = true;
            btnKQLHMonHoc.Enabled = true;
            btnKQLHHocKy.Enabled = true;
            btnDanhSachHocSinh.Enabled = true;
            btnHoSoLopHoc.Enabled = true;

            btnSiSo.Enabled = true;
            btnDiemDat.Enabled = true;
            btnDoTuoi.Enabled = true;

            //False
            btnDangNhap.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnQLNguoiDung.Enabled = false;

            btnLopHoc.Enabled = false;
            btnKhoiLop.Enabled = false;
            btnHocKy.Enabled = false;
            btnNamHoc.Enabled = false;
            btnKetQua.Enabled = false;
            btnHocLuc.Enabled = false;
            btnHanhKiem.Enabled = false;
            btnHocSinh.Enabled = false;
            btnPhanLop.Enabled = false;
            btnThayDoiQuyDinh.Enabled = false;
        }
        #endregion

        #region Giao diện khi đăng nhập với quyền Giáo vụ
        public void ShowGiaoDienGiaoVu()
        {
            //True
            btnDangXuat.Enabled = true;
            btnDoiMatKhau.Enabled = true;
            btnThoat.Enabled = true;

            btnLopHoc.Enabled = true;
            btnKhoiLop.Enabled = true;
            btnHocKy.Enabled = true;
            btnNamHoc.Enabled = true;
            btnKetQua.Enabled = true;
            btnHocLuc.Enabled = true;
            btnHanhKiem.Enabled = true;
            btnMonHoc.Enabled = true;
            btnDiem.Enabled = true;
            btnHocSinh.Enabled = true;
            btnPhanLop.Enabled = true;

            btnKQHSMonHoc.Enabled = true;
            btnKQHSCaNam.Enabled = true;
            btnKQLHMonHoc.Enabled = true;
            btnKQLHHocKy.Enabled = true;
            btnDanhSachHocSinh.Enabled = true;
            btnHoSoLopHoc.Enabled = true;
            btnSiSo.Enabled = true;
            btnDiemDat.Enabled = true;
            btnDoTuoi.Enabled = true;

            //False
            btnDangNhap.Enabled = false;
            btnSaoLuu.Enabled = false;
            btnPhucHoi.Enabled = false;
            btnThayDoiQuyDinh.Enabled = false;
            btnQLNguoiDung.Enabled = false;
        }







        #endregion

        private void btnMonHoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.ShowForm("Subject");
        }

        private void btnDiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Utilities.ShowForm("Score");
        }
    }
}