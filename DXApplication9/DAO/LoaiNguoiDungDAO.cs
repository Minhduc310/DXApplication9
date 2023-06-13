using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication9.DAO
{
    public class LoaiNguoiDungDAO
    {
        private static LoaiNguoiDungDAO instance;

        private LoaiNguoiDungDAO() { }

        public static LoaiNguoiDungDAO Instance
        {
            get
            {
                if (instance == null) instance = new LoaiNguoiDungDAO();
                return instance;
            }
            private set => instance = value;
        }

        public DataTable LayDanhSachLoaiNguoiDung()
        {
            string query = "SELECT * FROM LOAINGUOIDUNG";
            return DataProvider.Instance.ExecuteQuery(query);
        }

        public void CapNhatLoaiNguoiDung(DataTable dataTable)
        {
            DataProvider.Instance.UpdateTable(dataTable, "LOAINGUOIDUNG");
        }
    }
}
