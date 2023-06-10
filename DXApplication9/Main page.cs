using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace DXApplication9
{
    public partial class Main_page : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main_page()
        {
            InitializeComponent();
            HienThiVersion();
        }
        private void HienThiVersion()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            FileVersionInfo versionInfo = FileVersionInfo.GetVersionInfo(assembly.Location);
            Text += $" v.{versionInfo.FileVersion}";
        }
        private void Main_page_Load(object sender, EventArgs e)
        {
            Show();
            CenterToScreen();
        }
        private void btnThayDoiQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            Thay_đổi_quy_định main = new Thay_đổi_quy_định();
            main.Show();
        }

        private void btnDoTuoi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quy_dinh main = new Quy_dinh();
            main.Show();
        }

        private void btnSiSo_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quy_dinh main = new Quy_dinh();
            main.Show();
        }

        private void btnDiemDat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quy_dinh main = new Quy_dinh();
            main.Show();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            Log_in main = new Log_in();
            _ = main.ShowDialog();
        }
    }
}