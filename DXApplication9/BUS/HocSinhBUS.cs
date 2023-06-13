using DevComponents.DotNetBar.Controls;
using DevComponents.Editors.DateTimeAdv;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication9.DTO;
using DXApplication9.DAO;

namespace DXApplication9.BUS
{
    public class HocSinhBUS
    {
        private static HocSinhBUS instance;
        private BindingSource bindingSource = new BindingSource();

        private HocSinhBUS() { }

        public static HocSinhBUS Instance
        {
            get
            {
                if (instance == null) instance = new HocSinhBUS();
                return instance;
            }
            private set => instance = value;
        }

        public void HienThi(
            BindingNavigator bindingNavigator,
            DataGridView dataGridView,
            TextBoxX txtMaHocSinh,
            TextBoxX txtTenHocSinh,
            TextBoxX txtGioiTinh,
            CheckBoxX ckbGTinhNam,
            CheckBoxX ckbGTinhNu,
            DateTimeInput dtpNgaySinh,
            TextBoxX txtDiaChi,
            TextBoxX txtEmail)
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinh();
            bindingSource.DataSource = dataTable;

            bool gioiTinh = Convert.ToBoolean(dataTable.Rows[0]["GioiTinh"]);
            if (gioiTinh) ckbGTinhNu.Checked = true;
            else ckbGTinhNam.Checked = true;

            txtMaHocSinh.DataBindings.Clear();
            txtMaHocSinh.DataBindings.Add("Text", bindingSource, "MaHocSinh");

            txtTenHocSinh.DataBindings.Clear();
            txtTenHocSinh.DataBindings.Add("Text", bindingSource, "HoTen");

            txtGioiTinh.DataBindings.Clear();
            txtGioiTinh.DataBindings.Add("Text", bindingSource, "GioiTinh");

            dtpNgaySinh.DataBindings.Clear();
            dtpNgaySinh.DataBindings.Add("Value", bindingSource, "NgaySinh");

            txtDiaChi.DataBindings.Clear();
            txtDiaChi.DataBindings.Add("Text", bindingSource, "DiaChi");

            txtEmail.DataBindings.Clear();
            txtEmail.DataBindings.Add("Text", bindingSource, "Email");

            bindingNavigator.BindingSource = bindingSource;
            dataGridView.DataSource = bindingSource;
        }

        public void HienThiHocSinhTheoLop(
            BindingNavigator bindingNavigator,
            DataGridViewX dataGridViewX,
            string namHoc,
            string lop)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = HocSinhDAO.Instance.LayDanhSachHocSinh(namHoc, lop);
            bindingNavigator.BindingSource = bs;
            dataGridViewX.DataSource = bs;
        }

        public void HienThiHocSinhTheoLop(string namHoc, string khoiLop, string lop, ListViewEx listViewEx)
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinhTheoLop(namHoc, khoiLop, lop);
            listViewEx.Items.Clear();

            foreach (DataRow Row in dataTable.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = Row["MaHocSinh"].ToString();
                item.SubItems.Add(Row["HoTen"].ToString());
                listViewEx.Items.Add(item);
            }
        }

        public void HienThiComboBox(string namHoc, string lop, ComboBoxEx comboBox)
        {
            comboBox.DataSource = HocSinhDAO.Instance.LayDanhSachHocSinh(namHoc, lop);
            comboBox.DisplayMember = "HoTen";
            comboBox.ValueMember = "MaHocSinh";
        }

        public DataTable LayDanhSachHocSinhTheoNamHoc(string namHoc)
        {
            return HocSinhDAO.Instance.LayDanhSachHocSinhTheoNamHoc(namHoc);
        }

        public IList<HocSinhDTO> Report()
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinh();
            IList<HocSinhDTO> ilist = new List<HocSinhDTO>();

            foreach (DataRow Row in dataTable.Rows)
            {
                HocSinhDTO hocSinh = new HocSinhDTO();
                hocSinh.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hocSinh.HoTen = Convert.ToString(Row["HoTen"]);
                hocSinh.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
                hocSinh.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
                hocSinh.DiaChi = Convert.ToString(Row["DiaChi"]);
                hocSinh.Email = Convert.ToString(Row["Email"]);
                ilist.Add(hocSinh);
            }
            return ilist;
        }

        public IList<HocSinhDTO> Report(string namHoc, string lop)
        {
            DataTable dataTable = HocSinhDAO.Instance.LayDanhSachHocSinh(namHoc, lop, true);
            IList<HocSinhDTO> ilist = new List<HocSinhDTO>();

            foreach (DataRow Row in dataTable.Rows)
            {
                HocSinhDTO hocSinh = new HocSinhDTO();
                hocSinh.MaHocSinh = Convert.ToString(Row["MaHocSinh"]);
                hocSinh.HoTen = Convert.ToString(Row["HoTen"]);
                hocSinh.GioiTinh = Convert.ToBoolean(Row["GioiTinh"]);
                hocSinh.NgaySinh = Convert.ToDateTime(Row["NgaySinh"]);
                hocSinh.DiaChi = Convert.ToString(Row["DiaChi"]);
                ilist.Add(hocSinh);
            }
            return ilist;
        }

        public void CapNhatHocSinh(DataTable dataTable)
        {
            HocSinhDAO.Instance.CapNhatHocSinh(dataTable);
        }

        public void ThemHocSinh(HocSinhDTO hocSinh)
        {
            HocSinhDAO.Instance.ThemHocSinh(hocSinh);
        }

        public void TimTheoMa(string maHocSinh)
        {
            bindingSource.DataSource = HocSinhDAO.Instance.TimTheoMa(maHocSinh);
        }

        public void TimTheoTen(string tenHocSinh)
        {
            bindingSource.DataSource = HocSinhDAO.Instance.TimTheoTen(tenHocSinh);
        }
    }
}
