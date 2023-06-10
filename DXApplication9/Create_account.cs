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

namespace DXApplication9
{
    public partial class Tạo_tài_khoản_mới : DevExpress.XtraEditors.XtraForm
    {
        public Tạo_tài_khoản_mới()
        {
            InitializeComponent();
        }

        private void Tạo_tài_khoản_mới_Load(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_in main = new Log_in();
            main.Show();
            main = null;
            this.Show();
        }
    }
}