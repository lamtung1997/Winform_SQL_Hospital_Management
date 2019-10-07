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
    public partial class Frm_Them_Sua_Thuoc : Form
    {
        public Frm_Them_Sua_Thuoc()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();
            string qry = "SELECT * FROM view_ThongTinThuoc";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;
            BV.conn.Close();

            BV.conn.Open();
            string qry1 = @"SELECT NhaCungCap FROM NhaCungCapThuoc";
            SqlDataReader dr1 = new SqlCommand(qry1, BV.conn).ExecuteReader();
            while (dr1.Read())
            {
                comboBox1.Items.Add(dr1.GetValue(0).ToString());
            }
            BV.conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            textBox_Ma_Thuoc.Text = row.Cells[0].Value.ToString();
            textBox_TenThuoc.Text = row.Cells[1].Value.ToString();
            textBox_DonVi.Text = row.Cells[2].Value.ToString();
            textBox_DonGia.Text = row.Cells[3].Value.ToString();
            comboBox1.Text = row.Cells[4].Value.ToString();
            textBox_So_Luong.Text = row.Cells[5].Value.ToString();
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            BV.conn.Open();
            string strUpdate = "UPDATE Thuoc SET TenThuoc = N'" + textBox_TenThuoc.Text + "',DonGia = "+ textBox_DonGia.Text +",SoLuong =" + textBox_So_Luong.Text + "WHERE MaThuoc = '" + textBox_Ma_Thuoc.Text + "'";
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strUpdate;
            objCommand.Connection = BV.conn;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();


            BV.conn.Open();
            string qry = "SELECT * FROM view_ThongTinThuoc";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;
            BV.conn.Close();


            MessageBox.Show("Đã Sửa Xong");
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            if(textBox_Ma_Thuoc.Text != "" && textBox_DonGia.Text != "" && textBox_DonVi.Text != "" && textBox_So_Luong.Text != "" && textBox_TenThuoc.Text != "" && comboBox1.Text != "")
            {
                BV.conn.Open();
                string strInsert = "insert into Thuoc values ('" + textBox_Ma_Thuoc.Text + "','" + textBox_TenThuoc.Text + "',N'" + textBox_DonVi.Text + "'," + textBox_DonGia.Text + ",N'" + comboBox1.SelectedItem.ToString() + "'," + textBox_So_Luong.Text + ")";
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandText = strInsert;
                objCommand.Connection = BV.conn;
                objCommand.ExecuteNonQuery();
                BV.conn.Close();

                MessageBox.Show("Thêm Thuốc Thành Công");

                BV.conn.Open();
                string qry = "SELECT * FROM view_ThongTinThuoc";
                SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
                DataTable table1 = new DataTable();
                da.Fill(table1);
                dataGridView1.DataSource = table1;
                BV.conn.Close();
            }
            else
            {
                MessageBox.Show("Thiếu Thông Tin");
            }
        }
    }
}
