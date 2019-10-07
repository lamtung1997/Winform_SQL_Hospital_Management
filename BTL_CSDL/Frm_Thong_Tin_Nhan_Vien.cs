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
    public partial class Frm_Thong_Tin_Nhan_Vien : Form
    {
        public Frm_Thong_Tin_Nhan_Vien()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();

            string qry = "SELECT * FROM View_ThongTinNhanVien";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;

            BV.conn.Close();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            BV.conn.Open();

            string qry = "Exec Proc_ThongTinNhanVien N'%" + textBox_Ho_Ten.Text + "%'";
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
    }
}
