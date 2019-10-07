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
    public partial class Frm_Dich_Vu : Form
    {
        public Frm_Dich_Vu()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();
            string qry1 = @"SELECT TenDichVu FROM DichVu";
            SqlDataReader dr1 = new SqlCommand(qry1, BV.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1.GetValue(0).ToString());
            }
            BV.conn.Close();

            BV.conn.Open();
            string qry = "SELECT * FROM view_DichVu";
            SqlDataAdapter da1 = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da1.Fill(table1);
            dataGridView1.DataSource = table1;
            BV.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "EXEC Proc_XemGiaDichVu N'" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da1.Fill(table1);
            dataGridView1.DataSource = table1;
            BV.conn.Close();
        }
    }
}
