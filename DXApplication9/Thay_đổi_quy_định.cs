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
    public partial class Thay_đổi_quy_định : DevExpress.XtraEditors.XtraForm
    {
        public Thay_đổi_quy_định()
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

        private void Thay_đổi_quy_định_Load(object sender, EventArgs e)
        {
            HienThi();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
                if (txtTuoiCanDuoi.Value > txtTuoiCanTren.Value)
                    MessageBox.Show(
                        "Đổ tuổi cận dưới phải nhỏ hơn độ tuổi cận trên !",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                else
                {
                    QuyDinhBUS.Instance.CapNhatQuyDinhDoTuoi(txtTuoiCanDuoi.Value, txtTuoiCanTren.Value);
                }

                if (txtSiSoCanDuoi.Value > txtSiSoCanTren.Value)
                    MessageBox.Show(
                        "Sỉ số cận dưới phải nhỏ hơn sỉ số cận trên !",
                        "ERROR",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                else
                {
                    QuyDinhBUS.Instance.CapNhatQuyDinhSiSo(txtSiSoCanDuoi.Value, txtSiSoCanTren.Value);
                }

                QuyDinhBUS.Instance.CapNhatQuyDinhDiemDat(txtDiemDat.Value);
                MessageBox.Show(
                    "Cập nhật thành công quy định!",
                    "COMPLETED",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                HienThi();
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}