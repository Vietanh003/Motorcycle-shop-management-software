using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Dùng thư viện này để mã hóa 
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CuaHangXeMay
{
    public class DangNhap
    {
        DBConnect kn = new DBConnect();

        static string quyenTaiKhoan;
        public string QuyenTaiKhoan 
        {
            get 
            { 
                return quyenTaiKhoan; 
            }
            set 
            {
                quyenTaiKhoan = value;
            }
        }

        public DangNhap()
        {
        }

        public DangNhap(string chuoi)
        {
            quyenTaiKhoan = chuoi;
        }

        private static List<TaiKhoan> danhSachTaiKhoan = new List<TaiKhoan>();


        public List<TaiKhoan> layDStaiKhoan(string sql)
        {
            kn.open();
            SqlDataReader doc = kn.getexcuteReader(sql);
            while (doc.Read())
            {
                TaiKhoan tk = new TaiKhoan();
                tk.TenDangNhap = doc["tendangnhap"].ToString();
                tk.TenHienThi = doc["TenHienThi"].ToString();
                tk.MatKhau = doc["MatKhau"].ToString();
                tk.Quyen = doc["Quyen"].ToString();
                tk.Email = doc["email"].ToString();

                danhSachTaiKhoan.Add(tk);
            }
            kn.close();
            return danhSachTaiKhoan;
        }


        public int phanQuyenTaiKhoan()
        {//Bên đang sửa
            frmDangNhap dn = new frmDangNhap();
            string a = quyenTaiKhoan;
            int t = 0;
            //So sánh không phân biệt hoa thường
            string quyen = danhSachTaiKhoan.FirstOrDefault(tim => string.Compare(tim.TenDangNhap, a, true) == 0).Quyen.ToString();
            //Có phân biệt hoa thường
            //string quyen = danhSachTaiKhoan.FirstOrDefault(tim=>tim.TenDangNhap.Contains(a)).Quyen.ToString();
            if (quyen == "nhanVien")
            {
                t = 0;
            }
            if (quyen == "QuanLy")
            {
                t = 1;
            }
            if (quyen == "toanQuyen")
            {
                t = 10;
            }
            return t;
        }

        public void dongMoForm(Form frmMo, Form frmDong)
        {
            frmDong.Hide();
            frmDong.Close();
            frmMo.ShowDialog();
        }


        //Mã hóa mật khẩu
        public string maHoaHash(string chuoiCanMaHoa)
        {
            byte[] tam = ASCIIEncoding.ASCII.GetBytes(chuoiCanMaHoa);
            byte[] duLieuDaBam = new MD5CryptoServiceProvider().ComputeHash(tam);
            string chuoiDaMaHoa = "";
            foreach(byte pt in duLieuDaBam)
            {
                chuoiDaMaHoa += pt;
            }    
            return chuoiDaMaHoa;
        }

        //Hàm dùng chung kiểm tra hợp lệ
        #region
        public bool kiemTraTenDangNhap(string tenDangNhap)
        {
            return Regex.IsMatch(tenDangNhap, "^[a-zA-Z0-9]{2,24}$");
        }

        public bool kiemTraEmail(string email)
        {
            return Regex.IsMatch(email, "^[a-zA-Z0-9_.]{2,120}@gmail.com(.vn|)$");
        }
        #endregion


        //Đặt lại mật khẩu
        public void datLaiMatKhau()
        {

        }

    }
}
