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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();

            BackgroundImage = BV.Image_Background;

            Benh_Nhan.Enabled = BV.BenhNhan;
            Nhan_Su.Enabled = BV.NhanSu;
            Thuoc.Enabled = BV.Thuoc;
            Thong_Tin.Enabled = BV.ThongTin;
            Thong_Ke.Enabled = BV.ThongKe;

            Xoa_Benh_Nhan.Enabled = BV.XoaBenhNhan;
            Xoa_Nhan_Vien.Enabled = BV.XoaNhanVien;
            Them_Nhan_Vien.Enabled = BV.ThemNhanVien;
            Phan_Quyen.Enabled = BV.PhanQuyen;
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Thong_Tin_Nhan_Vien _f = new Frm_Thong_Tin_Nhan_Vien();
            _f.ShowDialog();
        }

        private void xemThôngTinBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Thong_Tin_Benh_Nhan _f = new Frm_Thong_Tin_Benh_Nhan();
            _f.ShowDialog();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Thong_Tin_Phong _f = new Frm_Thong_Tin_Phong();
            _f.ShowDialog();
        }

        private void thêmBệnhNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Them_Benh_Nhan _f = new Frm_Them_Benh_Nhan();
            _f.ShowDialog();
        }

        private void Xoa_Benh_Nhan_Click(object sender, EventArgs e)
        {
            Frm_Xoa_Benh_Nhan _f = new Frm_Xoa_Benh_Nhan();
            _f.ShowDialog();
        }

        private void cậpNhậtQuáTrìnhĐiềuTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Cap_Nhat_Qua_Trinh_Dieu_Tri _f = new Frm_Cap_Nhat_Qua_Trinh_Dieu_Tri();
            _f.ShowDialog();
        }

        private void giấyRaViệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Giay_Ra_Vien _f = new Frm_Giay_Ra_Vien();
            _f.ShowDialog();
        }

        private void việnPhíToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Vien_Phi _f = new Frm_Vien_Phi();
            _f.ShowDialog();
        }

        private void caTrựcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Ca_Truc _f = new Frm_Ca_Truc();
            _f.ShowDialog();
        }

        private void Them_Nhan_Vien_Click(object sender, EventArgs e)
        {
            Frm_Them_Nhan_Vien _f = new Frm_Them_Nhan_Vien();
            _f.ShowDialog();
        }

        private void Xoa_Nhan_Vien_Click(object sender, EventArgs e)
        {
            Frm_Xoa_Nhan_Vien _f = new Frm_Xoa_Nhan_Vien();
            _f.ShowDialog();
        }

        private void xemThôngTinThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Thong_Tin_Thuoc _f = new Frm_Thong_Tin_Thuoc();
            _f.ShowDialog();
        }

        private void xemThôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Thong_Tin_Nha_Cung_Cap _f = new Frm_Thong_Tin_Nha_Cung_Cap();
            _f.ShowDialog();
        }

        private void cơSởYTếLiênKếtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Co_So_Y_Te _f = new Frm_Co_So_Y_Te();
            _f.ShowDialog();
        }

        private void khoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Khoa _f = new Frm_Khoa();
            _f.ShowDialog();
        }

        private void dịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Dich_Vu _f = new Frm_Dich_Vu();
            _f.ShowDialog();
        }

        private void Thong_Ke_Click(object sender, EventArgs e)
        {
            Frm_Thong_Ke _f = new Frm_Thong_Ke();
            _f.ShowDialog();
        }

        private void phânQuyềnNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Phan_Quyen _f = new Frm_Phan_Quyen();
            _f.ShowDialog();
        }
    }
}
