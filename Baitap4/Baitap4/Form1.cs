using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Baitap4
{
    public partial class Form1 : Form
    {
        #region Khai bao bien
        SqlConnection con = new SqlConnection();
        string env = ConfigurationManager.ConnectionStrings["hieu"].ConnectionString;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Open();
            LoadBauTroiLaCuaDoita();
            Closedata();


        }

        #region Ham xu ly
        private void Open()
        {
            
            con.ConnectionString = env;
            con.Open();
        }
        private void Closedata()
        {
            con.Close();
        }
        private void LoadBauTroiLaCuaDoita()
        {
            string truyvan = "select * from tblMatHang";
            SqlCommand com = new SqlCommand(truyvan, con);

            SqlDataAdapter adapter = new SqlDataAdapter(com);

            DataSet dt = new DataSet();
            adapter.Fill(dt);

            dgwResult.DataSource = dt.Tables[0];
            dgwResult.Refresh();
        }
        private void Insertdata()
        {
            Open();
            string masp = txtMaSP.Text;
            string tensp = txtTenSp.Text;
            DateTime dt = dtpNgaySX.Value;
            DateTime dtEnd = dtpNgayHH.Value;
            string dv = txtDonVi.Text;
            string gc = txtGhiChu.Text;

            string insert = "insert into tblMatHang values ('" + masp + "', '" + tensp + "','" + dt.ToShortDateString() + "','" + dtEnd.ToShortDateString() + "','" + dv + "',25,'" + gc + "')";
            SqlCommand com = new SqlCommand(insert, con);

            com.ExecuteNonQuery();
            LoadBauTroiLaCuaDoita();
            Closedata();

        }

        private void Deletedata(string masp)
        {
            Open();

            string delete = "delete from tblMatHang where masp='"+ masp +"'";
            SqlCommand com = new SqlCommand(delete, con);
            com.ExecuteNonQuery();

            LoadBauTroiLaCuaDoita();
            Closedata();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgwResult.Rows.Count; i++)
            {
                if (dgwResult.Rows[i].Selected)
                {
                    Deletedata(dgwResult.Rows[i].Cells[0].Value.ToString());
                    break;
                }
            }
        }
        private void CapNhat(string masp)
        {
            Open();
           
            string tensp = txtTenSp.Text;
            DateTime dt = dtpNgaySX.Value;
            DateTime dtEnd = dtpNgayHH.Value;
            string dv = txtDonVi.Text;
            string gc = txtGhiChu.Text;

            string update = "update tblMatHang set " + tensp + "','" + dt.ToShortDateString() + "','" + dtEnd.ToShortDateString() + "','" + dv + "',25,'" + gc + "')";
            SqlCommand com = new SqlCommand(update, con);

            com.ExecuteNonQuery();
            LoadBauTroiLaCuaDoita();
            Closedata();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //CapNhat();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }

        private void btxThem_Click(object sender, EventArgs e)
        {
            Insertdata();
        }
        private void Setdata(string masp)
        {
            if(masp != "")
            {
                Open();
                string sql = "select * from tblMatHang where masp = '" + masp + "'";
                SqlCommand com = new SqlCommand(sql, con);
                SqlDataAdapter adapter = new SqlDataAdapter(com);
                DataSet dt = new DataSet();
                adapter.Fill(dt);
                string tensp = dt.Tables[0].Rows[0][1].ToString();
                string ngaysx = dt.Tables[0].Rows[0][2].ToString();
                string ngayhh = dt.Tables[0].Rows[0][3].ToString();
                string donvi = dt.Tables[0].Rows[0][4].ToString();
                string dongia = dt.Tables[0].Rows[0][5].ToString();
                string ghichu = dt.Tables[0].Rows[0][6].ToString();

                txtMaSP.Text = masp;
                txtTenSp.Text = tensp;
                dtpNgaySX.Value = DateTime.Parse(ngaysx);
                dtpNgayHH.Value = DateTime.Parse(ngayhh);
                txtDonVi.Text = donvi;
                txtDonGia.Text = dongia;
                txtGhiChu.Text = ghichu;

                Closedata();
            }
        }
        #endregion

        private void dgwResult_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string masp = dgwResult.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtMaSP.Enabled = false;
                Setdata(masp);
            }
        }

       

       
    }
}
