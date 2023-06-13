using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication9.DTO
{
    public class LoaiNguoiDungDTO
    {
        private string maLoai;
        private string tenLoai;

        public LoaiNguoiDungDTO() { }
        public string MaLoai { get => maLoai; set => maLoai = value; }
        public string TenLoai { get => tenLoai; set => tenLoai = value; }
    }
}
