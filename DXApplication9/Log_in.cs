using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DXApplication9
{
    public partial class Log_in : DevExpress.XtraEditors.XtraForm
    {
        public Log_in()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main_page main = new Main_page();
      
            main.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Tạo_tài_khoản_mới main = new Tạo_tài_khoản_mới();
        
            main.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void checkButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
