using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTap1
{
    public partial class FrmBai3 : Form
    {
        public FrmBai3()
        {
            InitializeComponent();
        }

        private void txtHienThi_TextChanged(object sender, EventArgs e)
        {

            if (txtHienThi.Text.Trim() != "")
                btnView.Enabled = true;
            else
                btnView.Enabled = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lbHienThi.Text = txtHienThi.Text;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
