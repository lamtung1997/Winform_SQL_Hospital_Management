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
    public partial class Frm_Dang_Nhap : Form
    {
        int i = 0;
        public Frm_Dang_Nhap()
        {
            InitializeComponent();

            BackgroundImage = BV.Image_Loading;

            BV.conn.Open();
            string qry = @"SELECT * FROM USERS";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                if (i == 0)
                {
                    BV.DN_NhanVien = dr.GetValue(1).ToString();
                    BV.MK_NhanVien = dr.GetValue(2).ToString();
                }
                if (i == 1)
                {
                    BV.DN_DuocSy = dr.GetValue(1).ToString();
                    BV.MK_DuocSy = dr.GetValue(2).ToString();
                }
                if (i == 2)
                {
                    BV.DN_QuanTri = dr.GetValue(1).ToString();
                    BV.MK_QuanTri = dr.GetValue(2).ToString();
                }
                i++;
            }
            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Dang_Nhap_Click(object sender, EventArgs e)
        {
            if (textBox_Dang_Nhap.Text == BV.DN_NhanVien && textBox_Mat_Khau.Text == BV.MK_NhanVien)
            {
                BV.XoaBenhNhan = false;
                BV.XoaNhanVien = false;
                BV.ThemNhanVien = false;
                BV.Thuoc = false;
                BV.BenhNhan = true;
                BV.NhanSu = true;
                BV.ThongKe = true;
                BV.ThongTin = true;
                BV.PhanQuyen = false;

                Frm_Menu _f = new Frm_Menu();
                _f.Show();
                Hide();
            }
            else if (textBox_Dang_Nhap.Text == BV.DN_DuocSy && textBox_Mat_Khau.Text == BV.MK_DuocSy)
            {
                BV.BenhNhan = false;
                BV.NhanSu = false;
                BV.ThongKe = false;
                BV.ThongTin = false;
                BV.XoaBenhNhan = false;
                BV.XoaNhanVien = false;
                BV.ThemNhanVien = false;
                BV.Thuoc = true;
                BV.PhanQuyen = false;

                Frm_Menu _f = new Frm_Menu();
                _f.Show();
                Hide();
            }
            else if (textBox_Dang_Nhap.Text == BV.DN_QuanTri && textBox_Mat_Khau.Text == BV.MK_QuanTri)
            {
                BV.XoaBenhNhan = true;
                BV.XoaNhanVien = true;
                BV.ThemNhanVien = true;
                BV.Thuoc = true;
                BV.BenhNhan = true;
                BV.NhanSu = true;
                BV.ThongKe = true;
                BV.ThongTin = true;
                BV.PhanQuyen = true;

                Frm_Menu _f = new Frm_Menu();
                _f.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu");
            }
        }
    }
}
