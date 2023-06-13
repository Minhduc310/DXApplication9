using DevComponents.DotNetBar.Controls;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication9.DAO;

namespace DXApplication9.BUS
{
    internal class HocKyBUS
    {
        private static HocKyBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HocKyBUS() { }

        public static HocKyBUS Instance
        {
            get
            {
                if (instance == null) instance = new HocKyBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(DataGridViewX dataGridViewX, BindingNavigator bindingNavigator)
        {
            bindingSource.DataSource = HocKyDAO.Instance.LayDanhSachHocKy();
            bindingNavigator.BindingSource = bindingSource;
            dataGridViewX.DataSource = bindingSource;
        }

        public void HienThiComboBox(ComboBoxEx comboBox)
        {
            comboBox.DataSource = HocKyDAO.Instance.LayDanhSachHocKy();
            comboBox.DisplayMember = "TenHocKy";
            comboBox.ValueMember = "MaHocKy";
        }

        public void CapNhatHocKy(DataTable dataTable)
        {
            HocKyDAO.Instance.CapNhatHocKy(dataTable);
        }
    }
}
