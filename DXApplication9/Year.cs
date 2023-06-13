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
    public partial class Year : Form
    {
        public Year()
        {
            InitializeComponent();
        }

        private void Year_Load(object sender, EventArgs e)
        {
            NamHocBUS.Instance.HienThi(dgvNamHoc, bindingNavigatorNamHoc);
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            if (dgvNamHoc.RowCount == 0) bindingNavigatorDeleteItem.Enabled = true;

            BindingSource bindingSource = bindingNavigatorNamHoc.BindingSource;
            DataTable dataTable = (DataTable)bindingSource.DataSource;
            DataRow dataRow = dataTable.NewRow();

            dataRow["MaNamHoc"] = "";
            dataRow["TenNamHoc"] = "";

            dataTable.Rows.Add(dataRow);
            bindingSource.MoveLast();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (dgvNamHoc.RowCount == 0) bindingNavigatorDeleteItem.Enabled = false;
            else if (
                MessageBox.Show(
                    "Bạn có chắc chắn xóa dòng này không?",
                    "Xóa năm học",
                    MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question
                ) == DialogResult.OK
            ) bindingNavigatorNamHoc.BindingSource.RemoveCurrent();
        }

        private void bindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            string[] colNames = { "colMaNamHoc", "colTenNamHoc" };
            if (KiemTraTruocKhiLuu.KiemTraDataGridView(dgvNamHoc, colNames))
            {
                bindingNavigatorPositionItem.Focus();
                BindingSource bindingSource = bindingNavigatorNamHoc.BindingSource;
                NamHocBUS.Instance.CapNhatNamHoc((DataTable)bindingSource.DataSource);

                MessageBox.Show(
                    "Dữ liệu đã được lưu vào CSDL",
                    "Cập nhật thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }
    }

}
