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
    public partial class FrmBai5 : Form
    {
        public FrmBai5()
        {
            InitializeComponent();
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            string strKetQua = "";
          
                foreach (CheckBox item in grpCaSi.Controls)
                {
                    if(item.Checked)
                    strKetQua += item.Text+"\n";
                }
            if (strKetQua != "")
            {
                lblKetQua.Text = "Các ca sỹ mà bạn yêu thích:" + strKetQua;
            }
            else
            {
                lblKetQua.Text = "Không có ca sỹ nào được chọn";
            }
        }
    }
}
