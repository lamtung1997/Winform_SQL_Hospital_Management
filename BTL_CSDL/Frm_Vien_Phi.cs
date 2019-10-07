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
    public partial class Frm_Vien_Phi : Form
    {
        double Tong = 0;
        double Giam = 1.0;
        double TienBenh = 0;
        int GiaThuoc = 0;
        int Soluong = 0;
        public Frm_Vien_Phi()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();
            string qry1 = @"SELECT TenThuoc FROM Thuoc";
            SqlDataReader dr1 = new SqlCommand(qry1, BV.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_Thuoc.Items.Add(dr1.GetValue(0).ToString());
            }
            BV.conn.Close();

            BV.conn.Open();
            qry1 = @"SELECT TenBenh FROM BenhLy";
            dr1 = new SqlCommand(qry1, BV.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox_Benh.Items.Add(dr1.GetValue(0).ToString());
            }
            BV.conn.Close();

            BV.conn.Open();
            qry1 = @"SELECT TenDichVu FROM DichVu";
            dr1 = new SqlCommand(qry1, BV.conn).ExecuteReader();
            while (dr1.Read())
            {
                checkedListBox_DichVu.Items.Add(dr1.GetValue(0).ToString());
            }
            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            if (textBox_So_Luong_Thuoc.Text != "")
            {
                listBox_Thuoc.Items.Add(comboBox_Thuoc.Text + " x " + textBox_So_Luong_Thuoc.Text);
                Soluong = Int32.Parse(textBox_So_Luong_Thuoc.Text);
                Tong += GiaThuoc * Soluong;
            }
        }

        private void checkBox_BHYT_CheckedChanged(object sender, EventArgs e)
        {
            Giam = 0.3;
        }

        private void btn_Xong_Click(object sender, EventArgs e)
        {
            textBox_Tong.Text = (Tong * Giam).ToString();
        }

        private void checkBox_Tu_Van_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Tu_Van.Checked == true)
            {
                Tong += 500;
            }
        }

        private void checkBox_Kham_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Kham.Checked == true)
            {
                Tong += 1000;
            }
        }

        private void checkBox_Chua_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Chua.Checked == true)
            {
                Tong += 1500;
            }
        }

        private void comboBox_Thuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "Select DonGia from Thuoc where TenThuoc = N'" + comboBox_Thuoc.SelectedItem.ToString() + "'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                GiaThuoc = Int32.Parse(dr.GetValue(0).ToString());
            }
            BV.conn.Close();
        }

        private void checkedListBox_DichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tong += 500;
        }

        private void comboBox_Benh_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = " Select PhiChuaBenh from ChiPhiBenh, BenhLy WHERE ChiPhiBenh.MaBenh = BenhLy.MaBenh AND TenBenh = N'" + comboBox_Benh.SelectedItem.ToString() + "'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                TienBenh = Double.Parse(dr.GetValue(0).ToString());
            }
            BV.conn.Close();
            Tong += TienBenh;
        }
    }
}
