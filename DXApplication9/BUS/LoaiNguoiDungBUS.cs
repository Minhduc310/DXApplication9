using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DXApplication9.DAO;
using DXApplication9.DTO;

namespace DXApplication9.BUS
{
    public class LoaiNguoiDungBUS
    {
        private static LoaiNguoiDungBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private LoaiNguoiDungBUS() { }

        public static LoaiNguoiDungBUS Instance
        {
            get
            {
                if (instance == null) instance = new LoaiNguoiDungBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridView dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = LoaiNguoiDungDAO.Instance.LayDanhSachLoaiNguoiDung();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiDgvCmbCol(DataGridViewComboBoxColumn cmbColumn)
        {
            cmbColumn.DataSource = LoaiNguoiDungDAO.Instance.LayDanhSachLoaiNguoiDung();
            cmbColumn.DisplayMember = "TenLoai";
            cmbColumn.ValueMember = "MaLoai";
            cmbColumn.DataPropertyName = "MaLoai";
            cmbColumn.HeaderText = "Loại người dùng";
        }

        public void CapNhatLoaiNguoiDung(DataTable dataTable)
        {
            LoaiNguoiDungDAO.Instance.CapNhatLoaiNguoiDung(dataTable);
        }
    }
}
