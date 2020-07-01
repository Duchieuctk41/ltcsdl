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
    public partial class FrmBai7 : Form
    {
        public FrmBai7()
        {
            InitializeComponent();
        }

        private void btnMoveOne_Click(object sender, EventArgs e)
        {
            if(lstMatHang.SelectedItems.Count > 0)
            {
                //di chuyển item từ listBox 1 sang list Da chon
            lstDaChon.Items.Add(lstMatHang.SelectedItem);

            // bỏ đi item đã add 
            lstMatHang.Items.Remove(lstMatHang.SelectedItem);
            }

            
        }

        private void btnMoveAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstMatHang.Items.Count; i++)
            {
                lstDaChon.Items.Add(lstMatHang.Items[i]);
            }

            for (int i = 0; i < lstDaChon.Items.Count; i++)
            {
                lstMatHang.Items.Remove(lstDaChon.Items[i]);
            }
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            if (lstDaChon.SelectedItems.Count > 0)
            {
                //di chuyển item từ listBox 1 sang list Da chon
                lstMatHang.Items.Add(lstDaChon.SelectedItem);

                // bỏ đi item đã add 
                lstDaChon.Items.Remove(lstDaChon.SelectedItem);
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lstDaChon.Items.Count; i++)
            {
                lstMatHang.Items.Add(lstDaChon.Items[i]);
            }

            for (int i = 0; i < lstMatHang.Items.Count; i++)
            {
                lstDaChon.Items.Remove(lstMatHang.Items[i]);
            }
        }
    }
}
