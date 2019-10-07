using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_CSDL
{
    public partial class Frm_Thong_Tin_Nha_Cung_Cap : Form
    {
        public Frm_Thong_Tin_Nha_Cung_Cap()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();

            string qry = "select * from view_ThongTinNhaCungCap";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;

            BV.conn.Close();

            BV.conn.Open();
            qry = @"select * from view_ThongTinNhaCungCap";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetValue(0).ToString());
            }
            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();

            string qry = "select * from NhaCungCapThuoc where NhaCungCap = N'" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;

            BV.conn.Close();
        }
    }
}
