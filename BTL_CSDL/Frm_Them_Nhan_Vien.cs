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
    public partial class Frm_Them_Nhan_Vien : Form
    {
        string cmd;
        public Frm_Them_Nhan_Vien()
        {
            InitializeComponent();

            BV.conn.Open();
            string qry = "SELECT * FROM View_ThongTinNhanVien";           
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);    
            DataTable table1 = new DataTable();          
            da.Fill(table1);                      
            dataGridView_NhanVien.DataSource = table1;
            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentRow;
            try
            {
                cmd = "insert into NhanVien values ('" + row.Cells[0].Value.ToString() + "',N'" + row.Cells[1].Value.ToString() + "',N'" + row.Cells[2].Value.ToString() + "','" + row.Cells[3].Value.ToString() + "',N'" + row.Cells[4].Value.ToString() + "','" + row.Cells[5].Value.ToString() + "')";
                BV.conn.Open();
                SqlCommand Scmd = new SqlCommand(cmd, BV.conn);
                Scmd.ExecuteNonQuery();
                BV.conn.Close();
            }
            catch
            {
                MessageBox.Show("Thiếu hoặc sai thông tin");
            }
            BV.conn.Open();
            string qry = "SELECT * FROM View_ThongTinNhanVien";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView_NhanVien.DataSource = table1;
            BV.conn.Close();
        }
    }
}
