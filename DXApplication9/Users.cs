using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication9.BUS;
using DXApplication9.Components;

namespace DXApplication9
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            LoaiNguoiDungBUS.Instance.HienThiDgvCmbCol(colMaLoai);
            NguoiDungBUS.Instance.HienThi(dgvNguoiDung, bindingNavigatorNguoiDung);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorNguoiDung.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            string stt = Utilities.LaySTT(dgvNguoiDung.Rows.Count + 1);
            dataRow["MaNguoiDung"] = "ND" + stt;
            dataRow["MaLoai"] = "";
            dataRow["TenNguoiDung"] = "";
            dataRow["TenDangNhap"] = "";
            dataRow["MatKhau"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNguoiDung.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không ?",
                    "Xóa lớp học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorNguoiDung.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaNguoiDung", "colMaLoai", "colTenNguoiDung", "colTenDangNhap", "colMatKhau" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvNguoiDung, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorNguoiDung.BindingSource;
                NguoiDungBUS.Instance.CapNhatNguoiDung((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            NguoiDungBUS.Instance.HienThi(dgvNguoiDung, bindingNavigatorNguoiDung);
        }

    }
}
