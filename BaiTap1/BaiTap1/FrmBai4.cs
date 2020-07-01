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
    public partial class FrmBai4 : Form
    {
        public FrmBai4()
        {
            InitializeComponent();
        }

        private void rdtChuNghieng_CheckedChanged(object sender, EventArgs e)
        {
            if (rdtChuNghieng.Checked)
                lblKetQua.Text = "Sai";
            if (rdtXuongDong.Checked)
                lblKetQua.Text = "Đúng";
        }

        private void rdtXuongDong_CheckedChanged(object sender, EventArgs e)
        {
            //if (rdtXuongDong.Checked)
            //    lblKetQua.Text = "Đúng";
        }
    }
}
