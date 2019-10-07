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
    public partial class Frm_Them_Benh_Nhan : Form
    {
        string GioiTinh = "Nam";

        public Frm_Them_Benh_Nhan()
        {
            InitializeComponent();

            BackgroundImage = BV.Image_Form;
            Radio_Nam.Checked = true;

            BV.conn.Open();
            string qry = @"SELECT MaBenhNhan FROM BenhNhan";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                comboBox_Ma_Benh_Nhan.Items.Add(dr.GetValue(0).ToString());
            }
            BV.conn.Close();

            BV.conn.Open();
            qry = @"SELECT SoPhong FROM Phong";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                comboBox_Phong.Items.Add(dr.GetValue(0).ToString());
            }
            BV.conn.Close();

            BV.conn.Open();
            qry = @"SELECT DISTINCT LoaiBenhAn FROM BenhAn";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                comboBox_Loai_Benh_An.Items.Add(dr.GetValue(0).ToString());
            }
            BV.conn.Close();

            BV.conn.Open();
            qry = @"SELECT DISTINCT MaBenh FROM BenhLy";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                comboBox_Ma_Benh.Items.Add(dr.GetValue(0).ToString());
            }
            BV.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Radio_Nam_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Nam.Checked == true)
            {
                Radio_Nu.Checked = false;
                GioiTinh = "Nam";
            }
        }

        private void Radio_Nu_CheckedChanged(object sender, EventArgs e)
        {
            if (Radio_Nu.Checked == true)
            {
                Radio_Nam.Checked = false;
                GioiTinh = "Nữ";
            }
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            try
            {
                BV.conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BV.conn;

                string str_cmd = "EXEC Proc_ThemBenhNhan '" + textBox_Ma_Benh_Nhan.Text + "',N'" + textBox_Ho_Ten_BenhNhan.Text + "','" + dateTimePicker_Ngay_Sinh.Text + "',N'" + GioiTinh + "',N'" + textBox_Nghe_Nghiep.Text + "',N'" + textBox_Dia_Chi_Benh_Nhan.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                str_cmd = "EXEC Proc_ThemThanNhan '" + textBox_Ma_Benh_Nhan.Text + "',N'" + textBox_Ho_Ten_ThanNhan.Text + "','" + textBox_So_Dien_Thoai.Text + "',N'" + textBox_Dia_Chi_Than_Nhan.Text + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                str_cmd = "INSERT INTO BHYT VALUES('" + textBox_Ma_Benh_Nhan.Text + "', '" + textBox_BHYT.Text + "')";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                str_cmd = "EXEC Proc_ThemBenhAn '" + textBox_Ma_Benh_Nhan.Text + "','" + textBox_So_Benh_An.Text + "',N'" + comboBox_Loai_Benh_An.SelectedItem.ToString() + "','" + comboBox_Ma_Benh.SelectedItem.ToString() + "'";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                str_cmd = "INSERT INTO Giuong VALUES ('" + textBox_Ma_Benh_Nhan.Text + "','" + comboBox_Giuong.Text + "','" + comboBox_Phong.Text + "')";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();

                BV.conn.Close();

                MessageBox.Show("Thêm Bệnh Nhân Thành Công");
            }
            catch
            {
                MessageBox.Show("Thiếu Thông Tin hoặc Mã Bệnh Nhân bị trùng");
            }
        }
    }
}
