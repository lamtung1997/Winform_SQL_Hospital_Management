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
    public partial class Frm_Co_So_Y_Te : Form
    {
        public Frm_Co_So_Y_Te()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();
            string qry1 = @"select * from CoSoYTe";
            SqlDataReader dr1 = new SqlCommand(qry1, BV.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_Co_So_Y_Te.Items.Add(dr1.GetValue(1).ToString());
            }
            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Co_So_Y_Te_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "select * from CoSoYTe where TenCoSo = N'" + comboBox_Co_So_Y_Te.SelectedItem.ToString() + "'";
            SqlDataAdapter da1 = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da1.Fill(table1);
            dataGridView1.DataSource = table1;
            BV.conn.Close();
        }
    }
}
