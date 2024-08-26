using DoAnQuanLyCuaHangXeMay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CuaHangXeMay
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }



        #region Bộ di chuyển form tự thiết kế
        //Đóng mở form
        private void frmminisize(object sender, EventArgs e)
        {
            DieuKhienFormCustom dk = new DieuKhienFormCustom();
            dk.MINIClick(sender, e, this);
        }

        private void frmexit(object sender, EventArgs e)
        {
            DieuKhienFormCustom dk = new DieuKhienFormCustom();
            dk.EXITClick(sender, e);
        }
        /// Di chuyển form
        private bool drag = false;
        private Point dragCursor, dragForm;

        private void frmMouseMove(object sender, MouseEventArgs e)
        {
            int wid = SystemInformation.VirtualScreen.Width;
            int hei = SystemInformation.VirtualScreen.Height;
            if (drag)
            {
                // Phải using System.Drawing;
                Point change = Point.Subtract(Cursor.Position, new Size(dragCursor));
                Point newpos = Point.Add(dragForm, new Size(change));
                // QUyết định có cho form chui ra ngoài màn hình không
                if (newpos.X < 0) newpos.X = 0;
                if (newpos.Y < 0) newpos.Y = 0;
                if (newpos.X + this.Width > wid) newpos.X = wid - this.Width;
                if (newpos.Y + this.Height > hei) newpos.Y = hei - this.Height;
                this.Location = newpos;
            }
        }

        private void frmMouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void frmMouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }
        #endregion

        private void checkBox_AnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AnHienMatKhau.Checked)
            {
                txt_matKhau.PasswordChar = false;
                txt_matKhauMoi.PasswordChar = false;
                txt_xacNhanMatKhau.PasswordChar = false;
            }
            else
            {
                txt_matKhau.PasswordChar = true;
                txt_matKhauMoi.PasswordChar = true;
                txt_xacNhanMatKhau.PasswordChar = true;
            }
        }

        private void link_quenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap dn = new DangNhap();
            frmQuenMatKhau frmq = new frmQuenMatKhau();
            frmDoiMatKhau dong = new frmDoiMatKhau();
            dn.dongMoForm(frmq, dong);
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void btn_doiMatKhau_Click(object sender, EventArgs e)
        {
            DBConnect kn = new DBConnect();
            DangNhap dangNhap = new DangNhap();

            string tenDangNhap = txt_tenDangNhap.Texts;
            string matKhauHienTai = txt_matKhau.Texts;
            string matKhauMoi = txt_matKhauMoi.Texts;
            string xacNhanMatKhau = txt_xacNhanMatKhau.Texts;
            string email = txt_email.Texts;

            int soLoi = -1;
            soLoi = kiemTraHopLeDangNhap(tenDangNhap, matKhauHienTai, matKhauMoi, xacNhanMatKhau, email);


            if (soLoi == 0)
            {
                List<TaiKhoan> DStaiKhoan = new List<TaiKhoan>();
                string matKhauMaHoa = dangNhap.maHoaHash(matKhauMoi);
                string matKhauHienTaiMaHoa = dangNhap.maHoaHash(matKhauHienTai);
                string layTatCaTaiKhoan = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "' and email = '" + email + "' and matkhau = '"+ matKhauHienTaiMaHoa + "'";
                DStaiKhoan = dangNhap.layDStaiKhoan(layTatCaTaiKhoan);
                if (DStaiKhoan.Count > 0)
                {

                    string capNhatMatKhau = "update TaiKhoan set MatKhau = '"+matKhauMaHoa+"' where TenDangNhap = '"+tenDangNhap+"' and Email = '"+email+"'";
                    int ketQua = 0;
                    ketQua = kn.getnonquery(capNhatMatKhau);
                    if(ketQua>0)
                    {
                        if(MessageBox.Show("Mật khẩu đã được thay đổi. Chọn OK để đăng nhập", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)== DialogResult.OK)
                        {
                            frmDangNhap frmdn = new frmDangNhap();
                            frmDoiMatKhau frmdoi = new frmDoiMatKhau();
                            dangNhap.dongMoForm(frmdn, frmdoi);
                        }
                    }  
                    else
                    {
                        MessageBox.Show("Thất bại hãy sửa lại đúng thông tin tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    
                }
                else
                {
                    string kiemTraTaiKhoanTonTai = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "'";
                    DStaiKhoan = dangNhap.layDStaiKhoan(kiemTraTaiKhoanTonTai);
                    if (DStaiKhoan.Count > 0)
                    {
                        string matKhauCu = DStaiKhoan.FirstOrDefault(t => string.Compare(t.TenDangNhap, tenDangNhap, true) == 0).MatKhau.ToString();
                        string emailDangKy = DStaiKhoan.FirstOrDefault(t => string.Compare(t.TenDangNhap,tenDangNhap,true)==0).Email.ToString();
                        //string matKhauCoDung = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "' and matkhau = '"+matKhauHienTai+"'";
                        //int kq = -1;
                        //kq = (int)kn.getScalar(matKhauCoDung);
                        if (string.Compare(matKhauCu, matKhauHienTaiMaHoa) != 0)
                        {
                            MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            DStaiKhoan.Clear();
                        }
                        if(string.Compare(emailDangKy, email, true) != 0)
                        {
                            MessageBox.Show("Email không trùng với email đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            DStaiKhoan.Clear();
                        }    
                    }
                    else
                    {
                        MessageBox.Show("Tên đăng nhập này chưa được đăng ký", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        #region Kiểm tra hợp lệ textbox
        public int kiemTraHopLeDangNhap(string tenDangNhap, string matKhau, string matKhauMoi, string xacNhanMatKhau, string email)
        {
            DangNhap dangNhap = new DangNhap();
            int soLoi = 0;
            if (tenDangNhap.Trim() == "" && matKhau.Trim() == "" && matKhauMoi.Trim() == "" && xacNhanMatKhau.Trim() == "" && email.Trim() == "")
            {
                MessageBox.Show("Vui lòng điền đầy đủ các trường", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soLoi++;
            }
            if (!dangNhap.kiemTraTenDangNhap(tenDangNhap))
            {
                if (tenDangNhap == "")
                {
                    MessageBox.Show("Vui lòng nhập tên đăng nhập", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập không hợp lệ! độ dài tên từ 3 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
            }
            if (!dangNhap.kiemTraTenDangNhap(matKhau))
            {
                if (matKhau.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
                else
                {
                    soLoi++;
                    MessageBox.Show("Mật khẩu không hợp lệ! độ dài tên từ 3 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (!dangNhap.kiemTraTenDangNhap(matKhauMoi))
            {
                if (matKhauMoi.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
                else
                {
                    soLoi++;
                    MessageBox.Show("Mật khẩu không hợp lệ! độ dài tên từ 3 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (xacNhanMatKhau != matKhauMoi || !dangNhap.kiemTraTenDangNhap(xacNhanMatKhau))
            {
                if (xacNhanMatKhau.Trim() == "")
                {
                    soLoi++;
                    MessageBox.Show("Vui lòng nhập trường này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Mật khẩu xác nhận chưa trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
            }
            if (!dangNhap.kiemTraEmail(email))
            {
                if (email.Trim() == "")
                {
                    MessageBox.Show("Vui lòng nhập emai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
                else
                {
                    MessageBox.Show("Email của bạn không hợp lệ vui lòng nhập đúng emai", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    soLoi++;
                }
            }
            //if (dangNhap.layDStaiKhoan(kiemTraTrungTen).Count > 0)
            //{
            //    MessageBox.Show("Tên người dùng đã được đăng ký, vui lòng nghĩ ra tên khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    soLoi++;
            //}
            //if (dangNhap.layDStaiKhoan(kiemTraTrungEmail).Count > 0)
            //{
            //    soLoi++;
            //    MessageBox.Show("Email này đã được đăng ký, vui lòng nhập email khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
            return soLoi;
        }
        #endregion

    }
}
