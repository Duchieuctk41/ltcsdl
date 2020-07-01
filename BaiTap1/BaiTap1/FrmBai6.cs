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
    public partial class FrmBai6 : Form
    {
        public FrmBai6()
        {
            InitializeComponent();
        }

        private void lstMatHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKetQua.Text = lstMatHang.SelectedItem.ToString();
            //lstMatHang.Items.Add("ABC");
            //lstMatHang.Items.Remove("2");
        }
    }
}
