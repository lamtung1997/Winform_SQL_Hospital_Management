using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_CSDL
{
    public static class BV
    {
        public static Bitmap Image_Background = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Background.png");
        public static Bitmap Image_Loading = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\Login.jpg");
        public static Bitmap Image_Form = new Bitmap(Directory.GetCurrentDirectory() + "\\Resources\\FormBackground.jpg");

        public static bool XoaBenhNhan, XoaNhanVien, ThemNhanVien, BenhNhan, NhanSu, Thuoc, ThongTin, ThongKe, PhanQuyen;

        public static SqlConnection conn = new SqlConnection("Data Source=DESKTOP-CV8KF9D;Initial Catalog=Nhom4_QLBV;Integrated Security=True");

        public static string DN_NhanVien = "NV";
        public static string DN_DuocSy = "DS";
        public static string DN_QuanTri = "QT";

        public static string MK_NhanVien = "NV";
        public static string MK_DuocSy = "DS";
        public static string MK_QuanTri = "QT";
    }
}
