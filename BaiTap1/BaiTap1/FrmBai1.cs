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
    public partial class FrmBai1 : Form
    {
        public FrmBai1()
        {
            InitializeComponent();
        }

        private void FrmBai1_Load(object sender, EventArgs e)
        {
            this.Text = "Green Colour";
            this.BackColor = Color.Green;
        }

        private void btnGreen_Click(object sender, EventArgs e)
        {
            this.Text = "Yellow Colour";
            this.BackColor = Color.Yellow;
        }
 
     
    }
}
