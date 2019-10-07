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
    public partial class Frm_Sua_Benh_Nhan : Form
    {
        public Frm_Sua_Benh_Nhan()
        {
            InitializeComponent();
            BackgroundImage = BV.Image_Form;

            BV.conn.Open();

            string qry = "SELECT * FROM BenhNhan";
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];

            textBox_Ma_Benh_Nhan.Text = row.Cells[0].Value.ToString();
            textBox_Ho_Ten.Text = row.Cells[1].Value.ToString();
            if(row.Cells[2].Value.ToString() == "Nam")
            {
                radioButton_Nam.Checked = true;
                radioButton_Nu.Checked = false;
            }
            else
            {
                radioButton_Nam.Checked = false;
                radioButton_Nu.Checked = true;
            }
            textBox_Nghe_Nghiep.Text = row.Cells[4].Value.ToString();
            textBox_Dia_Chi.Text = row.Cells[5].Value.ToString();
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            BV.conn.Open();
            string strUpdate = "UPDATE BenhNhan SET HoTen = N'" + textBox_Ho_Ten.Text + "',NgaySinh = '" + dateTimePicker_Ngay_Sinh.Text + "', NgheNghiep = N'" + textBox_Nghe_Nghiep.Text + "', DiaChi = N'" + textBox_Dia_Chi.Text + "' WHERE MaBenhNhan = '" + textBox_Ma_Benh_Nhan.Text + "'";
            SqlCommand objCommand = new SqlCommand();
            objCommand.CommandText = strUpdate;
            objCommand.Connection = BV.conn;
            objCommand.ExecuteNonQuery();
            BV.conn.Close();

            MessageBox.Show("Cập nhật thành công");
        }
    }
}
