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
    public partial class Frm_Thong_Tin_Thuoc : Form
    {
        string MaThuoc;
        public Frm_Thong_Tin_Thuoc()
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
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            BV.conn.Open();

            string qry = "EXEC Proc_ThongTinThuoc '%" + textBox1.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView1.DataSource = table1;

            BV.conn.Close();
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            BV.conn.Open();
            string strDelete = "delete from Thuoc where MaThuoc = '" + MaThuoc + "'";
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strDelete;
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
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            MaThuoc = row.Cells[0].Value.ToString();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            Frm_Them_Sua_Thuoc _f = new Frm_Them_Sua_Thuoc();
            _f.ShowDialog();
        }
    }
}
