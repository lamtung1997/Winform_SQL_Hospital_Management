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
    public partial class Frm_Thong_Tin_Phong : Form
    {
        public Frm_Thong_Tin_Phong()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();

            string qry1 = @"SELECT Khoa FROM Khoa";
            SqlDataReader dr1 = new SqlCommand(qry1, BV.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_Khoa.Items.Add(dr1.GetValue(0).ToString());
            }

            BV.conn.Close();


            BV.conn.Open();

            string qry2 = "SELECT SoPhong FROM PHONG";
            SqlDataReader dr2 = new SqlCommand(qry2, BV.conn).ExecuteReader();
            while (dr2.Read())
            {
                comboBox_Phong.Items.Add(dr2.GetValue(0).ToString());
            }

            BV.conn.Close();
        }

        private void comboBox_Khoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_Phong.Items.Clear();

            BV.conn.Open();

            string qry2 = @"SELECT SoPhong FROM PHONG WHERE Khoa like N'" + comboBox_Khoa.SelectedItem.ToString() + "'";
            SqlDataReader dr2 = new SqlCommand(qry2, BV.conn).ExecuteReader();
            while (dr2.Read())
            {
                comboBox_Phong.Items.Add(dr2.GetValue(0).ToString());
            }

            BV.conn.Close();
        }

        private void btn_Hien_Thi_Thong_Tin_Click(object sender, EventArgs e)
        {
            BV.conn.Open();

            string qry1 = "EXEC Proc_ThongTinBenhNhanPhong '" + comboBox_Phong.SelectedItem.ToString() + "'";        
            SqlDataAdapter da1 = new SqlDataAdapter(qry1, BV.conn);      
            DataTable table1 = new DataTable();      
            da1.Fill(table1);           
            dataGridView_Benh_Nhan.DataSource = table1;

            BV.conn.Close();

            BV.conn.Open();

            string qry2 = "EXEC Proc_ThongTinNhanVienPhong '" + comboBox_Phong.SelectedItem.ToString() + "'";
            SqlDataAdapter da2 = new SqlDataAdapter(qry2, BV.conn);
            DataTable table2 = new DataTable();
            da2.Fill(table2);
            dataGridView_Nhan_Vien.DataSource = table2;

            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
