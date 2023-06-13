using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication9.DTO
{
    public class HocKyDTO
    {
        private string maHocKy;
        private string tenHocKy;
        private int heSo;

        public HocKyDTO() { }
        public string MaHocKy { get => maHocKy; set => maHocKy = value; }
        public string TenHocKy { get => tenHocKy; set => tenHocKy = value; }
        public int HeSo { get => heSo; set => heSo = value; }
    }
}
