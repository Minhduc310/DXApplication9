using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DXApplication9.BUS;

namespace DXApplication9
{
    public partial class Quy_dinh : DevExpress.XtraEditors.XtraForm
    {
        public Quy_dinh()
        {
            InitializeComponent();
        }

        private void HienThi()
        {
            QuyDinhBUS.Instance.HienThi(
                txtTuoiCanDuoi,
                txtTuoiCanTren,
                txtSiSoCanDuoi,
                txtSiSoCanTren,
                txtDiemDat
            );
        }

        private void Quy_dinh_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}