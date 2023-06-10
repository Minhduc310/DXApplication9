using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        }

        private void Main_page_Load(object sender, EventArgs e)
        {
            
        }

        private void ribbon_Click(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
            Thay_đổi_quy_định main = new Thay_đổi_quy_định();
            main.Show();
        }

        private void btnLopHoc_ItemClick(object sender, ItemClickEventArgs e)
        {

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quy_dinh main = new Quy_dinh();
            main.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quy_dinh main = new Quy_dinh();
            main.Show();
        }

        private void barButtonItem20_ItemClick(object sender, ItemClickEventArgs e)
        {
            Quy_dinh main = new Quy_dinh();
            main.Show();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
         
            Log_in main = new Log_in();
            main.ShowDialog();
            this.Hide();
           
        }
    }
}