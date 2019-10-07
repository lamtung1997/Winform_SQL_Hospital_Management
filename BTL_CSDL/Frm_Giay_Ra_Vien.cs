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
    public partial class Frm_Giay_Ra_Vien : Form
    {
        string MaBenhNhan;
        string MaCoSo;
        string MaDichVu;
        public Frm_Giay_Ra_Vien()
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

            BV.conn.Open();
            qry = @"SELECT TenCoSo FROM CoSoYTe";          
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();   
            while (dr.Read())                     
            {
                comboBox_Co_So_Y_Te.Items.Add(dr.GetValue(0).ToString());
            }
            comboBox_Co_So_Y_Te.ValueMember = "MaCoSo";
            BV.conn.Close();

            BV.conn.Open();
            qry = @"SELECT TenDichVu FROM DichVu";
            dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                comboBox_Dich_Vu.Items.Add(dr.GetValue(0).ToString());
            }
            BV.conn.Close();
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BV.conn.Open();

            string qry = "EXEC Proc_ThongTinBenhNhan N'%" + textBox_Ho_Ten.Text + "%'";
            SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
            DataTable table1 = new DataTable();
            da.Fill(table1);
            dataGridView.DataSource = table1;

            BV.conn.Close();
        }

        private void btn_Xong_Click(object sender, EventArgs e)
        {
            try
            {
                lbl_Chon_Benh_Nhan.Text = "Giấy Ra Viện";
                dataGridView.DataSource = null;

                BV.conn.Open();
                string str = "INSERT INTO GiayRaVien VALUES ('" + MaBenhNhan + "','" + MaCoSo + "','" + MaDichVu + "',N'" + textBox_Ket_Qua.Text + "', N'" + textBox_Khuyen.Text + "')";
                SqlCommand objCommand = new SqlCommand();
                objCommand.CommandText = str;
                objCommand.Connection = BV.conn;
                objCommand.ExecuteNonQuery();
                BV.conn.Close();

                BV.conn.Open();
                string qry = "EXEC Proc_GiayRaVien '" + MaBenhNhan + "'";
                SqlDataAdapter da = new SqlDataAdapter(qry, BV.conn);
                DataTable table1 = new DataTable();
                da.Fill(table1);
                dataGridView.DataSource = table1;
                BV.conn.Close();
            }
            catch
            {
                MessageBox.Show("Bệnh Nhân Đã Ra Viện !!!");
            }
            
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;					
            DataGridViewRow row = dataGridView.Rows[rowIndex];	
            MaBenhNhan = row.Cells[0].Value.ToString();
        }

        private void comboBox_Co_So_Y_Te_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "SELECT MaCoSo FROM CoSoYTe WHERE TenCoSo = N'"+ comboBox_Co_So_Y_Te.SelectedItem.ToString() +"'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                MaCoSo = dr.GetValue(0).ToString();
            }
            BV.conn.Close();
        }

        private void comboBox_Dich_Vu_SelectedIndexChanged(object sender, EventArgs e)
        {
            BV.conn.Open();
            string qry = "SELECT MaDichVu FROM DichVu WHERE TenDichVu = N'" + comboBox_Dich_Vu.SelectedItem.ToString() + "'";
            SqlDataReader dr = new SqlCommand(qry, BV.conn).ExecuteReader();
            while (dr.Read())
            {
                MaDichVu = dr.GetValue(0).ToString();
            }
            BV.conn.Close();
        }
    }
}
