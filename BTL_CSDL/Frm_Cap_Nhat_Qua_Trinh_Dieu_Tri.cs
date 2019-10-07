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
    public partial class Frm_Cap_Nhat_Qua_Trinh_Dieu_Tri : Form
    {
        string MaBenhNhan;
        public Frm_Cap_Nhat_Qua_Trinh_Dieu_Tri()
        {
            InitializeComponent();

            BackgroundImage = BV.Image_Form;

            BV.conn.Open();
            string qry = "SELECT * FROM View_ThongTinBenhNhan";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;
            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[rowIndex];
            MaBenhNhan = row.Cells[0].Value.ToString();

            BV.conn.Open();
            string qry = "SELECT * FROM QuaTrinhDieuTri WHERE MaBenhNhan = '" + MaBenhNhan + "' ";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;
            BV.conn.Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            BV.conn.Open();

            string qry = "EXEC Proc_ThongTinBenhNhan N'%" + textBox_Ho_Ten.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;

            BV.conn.Close();
        }

        private void btn_Cap_Nhat_Click(object sender, EventArgs e)
        {
            string str_cmd = "";
            try
            {
                BV.conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = BV.conn;
                str_cmd = "INSERT INTO QuaTrinhDieuTri VALUES('" + MaBenhNhan + "', " + numericUpDown.Value.ToString() + ", '" + dateTimePicker_Nhap_Vien.Text + "', N'" + textBox_Tinh_Trang.Text + "')";
                cmd.CommandText = str_cmd;
                cmd.ExecuteNonQuery();
                BV.conn.Close();
                MessageBox.Show("Cập nhật thành công !!!");

                BV.conn.Open();
                string qry = "SELECT * FROM QuaTrinhDieuTri WHERE MaBenhNhan = '" + MaBenhNhan + "' ";
                SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
                DataTable table1 = new DataTable();
                da.Fill(table1);
                dataGridView1.DataSource = table1;
                BV.conn.Close();
            }
            catch
            {
                MessageBox.Show("Ngày này đã cập nhật rồi !!!");
            }
            finally
            {
                
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown.Value > 1)
            {
                BV.conn.Open();
                string qry = "SELECT NgayNhapVien FROM QuaTrinhDieuTri WHERE MaBenhNhan = '" + MaBenhNhan + "' AND NgayThu = 1";
                SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
                while (dr.Read())
                {
                    dateTimePicker_Nhap_Vien.Text = dr.GetValue(0).ToString();
                    dateTimePicker_Nhap_Vien.Enabled = false;
                }
                BV.conn.Close();
            }
        }
    }
}
