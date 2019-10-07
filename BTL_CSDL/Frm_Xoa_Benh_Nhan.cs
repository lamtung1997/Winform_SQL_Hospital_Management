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
    public partial class Frm_Xoa_Benh_Nhan : Form
    {
        string MaBenhNhan;
        public Frm_Xoa_Benh_Nhan()
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

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            BV.conn.Open();
            string strDelete = "delete from BHYT where MaBenhNhan = '" + MaBenhNhan + "'";
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strDelete;
            objCommand.Connection = BV.conn;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strDelete = "delete from BenhAn where MaBenhNhan = '" + MaBenhNhan + "'";
            objCommand.CommandText = strDelete;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strDelete = "delete from QuaTrinhDieuTri where MaBenhNhan = '" + MaBenhNhan + "'";
            objCommand.CommandText = strDelete;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strDelete = "delete from GiayRaVien where MaBenhNhan = '" + MaBenhNhan + "'";
            objCommand.CommandText = strDelete;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strDelete = "delete from ThanNhan where MaBenhNhan = '" + MaBenhNhan + "'";
            objCommand.CommandText = strDelete;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strDelete = "delete from Giuong where MaBenhNhan = '" + MaBenhNhan + "'";
            objCommand.CommandText = strDelete;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            strDelete = "delete from BenhNhan where MaBenhNhan = '" + MaBenhNhan + "'";
            objCommand.CommandText = strDelete;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            BV.conn.Open();
            string qry = "SELECT * FROM View_ThongTinBenhNhan";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;
            BV.conn.Close();

            MessageBox.Show("Xóa Thành Công");
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView.Rows[rowIndex];
            MaBenhNhan = row.Cells[0].Value.ToString();
        }
    }
}
