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
    public partial class Frm_Xoa_Nhan_Vien : Form
    {
        string MaNhanVien;
        public Frm_Xoa_Nhan_Vien()
        {
            InitializeComponent();

            BackgroundImage = BV.Image_Form;

            BV.conn.Open();

            string qry = "SELECT * FROM View_ThongTinNhanVien";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;

            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            BV.conn.Open();

            string qry = "Exec Proc_ThongTinNhanVien N'%" + textBox_Ho_Ten.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;

            BV.conn.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            BV.conn.Open();
            string strDelete = "delete from CaTruc where MaNhanVien = '" + MaNhanVien + "'";
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strDelete;
            objCommand.Connection = BV.conn;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strDelete = "delete from NhanVien where MaNhanVien = '" + MaNhanVien + "'";
            objCommand.CommandText = strDelete;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            string qry = "SELECT * FROM View_ThongTinNhanVien";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;
            BV.conn.Close();

            MessageBox.Show("Xóa Thành Công");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            MaNhanVien = row.Cells[0].Value.ToString();
        }
    }
}
