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
    public partial class Frm_Phan_Quyen : Form
    {
        public Frm_Phan_Quyen()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            textBox_DN_NV.Text = BV.DN_NhanVien;
            textBox_DN_DS.Text = BV.DN_DuocSy;
            textBox_DN_QT.Text = BV.DN_QuanTri;
            textBox_MK_DS.Text = BV.MK_DuocSy;
            textBox_MK_NV.Text = BV.MK_NhanVien;
            textBox_MK_QT.Text = BV.MK_QuanTri;
        }

        private void textBox_DN_NV_TextChanged(object sender, EventArgs e)
        {
            BV.DN_NhanVien = textBox_DN_NV.Text;
        }

        private void textBox_MK_NV_TextChanged(object sender, EventArgs e)
        {
            BV.MK_NhanVien = textBox_MK_NV.Text;
        }

        private void textBox_DN_DS_TextChanged(object sender, EventArgs e)
        {
            BV.DN_DuocSy = textBox_DN_DS.Text; 
        }

        private void textBox_MK_DS_TextChanged(object sender, EventArgs e)
        {
            BV.MK_DuocSy = textBox_MK_DS.Text;
        }

        private void textBox_DN_QT_TextChanged(object sender, EventArgs e)
        {
            BV.DN_QuanTri = textBox_DN_QT.Text;
        }

        private void textBox_MK_QT_TextChanged(object sender, EventArgs e)
        {
            BV.MK_QuanTri = textBox_MK_QT.Text;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            BV.conn.Open();
            string strUpdate = "UPDATE Users SET Ten = '" + textBox_DN_NV.Text + "', MatKhau = '" + textBox_MK_NV.Text + "' WHERE ID = 1";
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strUpdate;
            objCommand.Connection = BV.conn;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strUpdate = "UPDATE Users SET Ten = '" + textBox_DN_DS.Text + "', MatKhau = '" + textBox_MK_DS.Text + "' WHERE ID = 2";
            objCommand.CommandText = strUpdate;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strUpdate = "UPDATE Users SET Ten = '" + textBox_DN_QT.Text + "', MatKhau = '" + textBox_MK_QT.Text + "' WHERE ID = 3";
            objCommand.CommandText = strUpdate;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            MessageBox.Show("Cập nhật phân quyền thành công");
        }
    }
}
