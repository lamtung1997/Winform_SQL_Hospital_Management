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
    public partial class Frm_Khoa : Form
    {
        public Frm_Khoa()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();
            string qry1 = @"SELECT Khoa FROM Khoa";
            SqlDataReader dr1 = new SqlCommand(qry1, BV.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1.GetValue(0).ToString());
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
            string qry = "select tang from Khoa where Khoa = N'" + comboBox1.SelectedItem.ToString() + "'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Tang.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            BV.conn.Open();
            qry = "select SoLuongPhong from Khoa where Khoa = N'" + comboBox1.SelectedItem.ToString() + "'";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_So_Phong.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            BV.conn.Open();
            qry = "select MoTa from Khoa where Khoa = N'" + comboBox1.SelectedItem.ToString() + "'";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox1_Mo_Ta.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            BV.conn.Open();
            qry = "select * from TruongKhoa where Khoa = N'" + comboBox1.SelectedItem.ToString() + "'";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Ho_Ten.Text = dr.GetValue(1).ToString();
                textBox_Gioi_Tinh.Text = dr.GetValue(2).ToString();
                textBox_Ngay_Sinh.Text = dr.GetValue(3).ToString();
                textBox_Dia_Chi.Text = dr.GetValue(4).ToString();
                textBox_SDT.Text = dr.GetValue(5).ToString();
            }
            BV.conn.Close();
        }
    }
}
