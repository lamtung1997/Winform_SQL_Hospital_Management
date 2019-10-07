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
    public partial class Frm_Thong_Ke : Form
    {
        public Frm_Thong_Ke()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            // Số Y Tá
            BV.conn.Open();
            string qry = "SELECT COUNT(*) as N'Số Lượng Y Tá' FROM NhanVien WHERE ChucVu = N'Y Tá'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_So_Y_Ta.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            // Số Bác Sỹ
            BV.conn.Open();
            qry = "SELECT COUNT(*) as N'Số Lượng Bác Sỹ' FROM NhanVien WHERE ChucVu = N'Bác Sỹ'";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_So_Bac_Sy.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            // Số Bệnh Nhân
            BV.conn.Open();
            qry = "SELECT COUNT(MaBenhNhan) as N'Số Bệnh Nhân' FROM Giuong";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_So_Benh_Nhan.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            // Số Giường Trống
            BV.conn.Open();
            qry = "SELECT 61 - COUNT(MaBenhNhan) as N'Số Giường Còn Trống' FROM Giuong";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_So_Giuong.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            // Số Bệnh nhân có BHYT
            BV.conn.Open();
            qry = "SELECT COUNT(*) FROM BHYT";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Co_BHYT.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            //Số Bệnh Nhân Nguy Kịch
            BV.conn.Open();
            qry = "EXEC Proc_ThongKe_BenhNhanNguyKich";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Nguy_Kich.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();

            // ComboBox Thuốc
            BV.conn.Open();
            qry = "SELECT TenThuoc FROM Thuoc";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                comboBox_Thuoc.Items.Add(dr.GetValue(0).ToString());
            }
            BV.conn.Close();

            // ComboBox Bệnh
            BV.conn.Open();
            qry = "SELECT TenBenh FROM BenhLy";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                comboBox_Benh.Items.Add(dr.GetValue(0).ToString());
                comboBox_Benh_1.Items.Add(dr.GetValue(0).ToString());
                comboBox_Benh_2.Items.Add(dr.GetValue(0).ToString());
            }
            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void comboBox_Tu_Vong_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "EXEC Proc_ThongKe_SoBenhNhanTuVong " + comboBox_Tu_Vong.SelectedItem.ToString();
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Tu_Vong.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();
        }

        private void comboBox_Thuoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "SELECT SoLuong FROM Thuoc WHERE TenThuoc = '" + comboBox_Thuoc.SelectedItem.ToString() + "'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Thuoc.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();
        }

        private void comboBox_Mac_Nhieu_Nhat_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "EXEC Proc_ThongKe_BenhMacNhieuNhat " + comboBox_Mac_Nhieu_Nhat.SelectedItem.ToString();
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Benh_Mac_Nhieu_Nhat.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();
        }

        private void textBox_Ngay_Dieu_Tri_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Ngay_Dieu_Tri.Text != "")
            {
                BV.conn.Open();
                string qry = "SELECT COUNT(*) FROM QuaTrinhDieuTri WHERE NgayThu = " + textBox_Ngay_Dieu_Tri.Text;
                SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
                while (dr.Read())
                {
                    textBox_Benh_Nhan_Nam_Lau.Text = dr.GetValue(0).ToString();
                }
                BV.conn.Close();
            }
        }

        private void comboBox_Benh_1_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "EXEC Proc_ThongKe_TuoiTreNhatMacBenh N'" + comboBox_Benh_1.SelectedItem.ToString() + "'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Tre_Nhat.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();
        }

        private void comboBox_Benh_2_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "EXEC Proc_ThongKe_TuoiCaoNhatMacBenh N'" + comboBox_Benh_2.SelectedItem.ToString() + "'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                textBox_Lon_Nhat.Text = dr.GetValue(0).ToString();
            }
            BV.conn.Close();
        }

        private void comboBox_Benh_SelectedIndexChanged(object sender, EventArgs e)
        {
            float Tong = 0;
            float SoLuong = 0;
            BV.conn.Open();
            string qry = "EXEC Proc_TuoiMacBenh N'" + comboBox_Benh.SelectedItem.ToString() + "'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                Tong = Tong + float.Parse(dr.GetValue(0).ToString());
                SoLuong++;
            }
            BV.conn.Close();
            if (SoLuong > 0)
                textBox_Tuoi_Trung_Binh.Text = (Tong / SoLuong).ToString();
        }
    }
}
