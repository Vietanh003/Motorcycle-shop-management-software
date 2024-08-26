using DoAnQuanLyCuaHangXeMay;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CuaHangXeMay
{
    public partial class frm : Form
    {
        DangNhap dangNhap = new DangNhap();
        DataTable taiKhoanBang = new DataTable();
        DBConnect kn = new DBConnect();
        static string tenND;
        static string quyenND;
        public string TenND { get { return tenND; } set { tenND = value; } }
        public string QuyenND { get { return quyenND; } set { quyenND = value; } }
        public frm()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            hieuUngClick(btn_trangChu);
            loadDuLieu();
        }

        public frm(string tenNguoiDung, string quyen)
        {
            tenND = tenNguoiDung;
            quyenND = quyen;
        }
         
        public string tenQuyen(string quyen)
        {
            string chucVu = "";
            if (quyen == "nhanVien")
            {
                chucVu = "Nhân viên";
            }
            if (quyen == "QuanLy")
            {
                chucVu = "Quản lý";
            }
            if (quyen == "toanQuyen")
            {
                chucVu = "Quản trị viên";
            }
            return chucVu;
        }

        public void loadDuLieu()
        {
            l_quyen.Text = tenQuyen(quyenND);
            l_tenNguoiDung.Text = tenND;
        }

        /// <summary>
        /// Di chuyển form
        /// </summary>
        private bool drag = false;
        private Point dragCursor, dragForm;

        DieuKhienFormCustom dieuKhien = new DieuKhienFormCustom();

        

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
                int nLeftRect,
                int nTopRect,
                int nRightRect,
                int nBottomRect,
                int nWidthEllipse,
                int nHeightEllipse
            );
      

        //Hàm dùng chung
        #region
        public void hieuUngClick(Button tenBtn)
        {
            pnlNav.Height = tenBtn.Height;
            pnlNav.Top = tenBtn.Top;
            //pnlNav.Left = tenBtn.Left;
            pnlNav.BackColor = Color.FromArgb(0, 126, 249);//(46, 51, 73);
        }

        public void hieuUngLeav()
        {
            pnlNav.BackColor = Color.FromArgb(24, 30, 54);
        }
        #endregion
        private void btn_trangChu_Click(object sender, EventArgs e)
        {
            hieuUngClick(btn_trangChu);
            frm dong = new frm();
            Main mo = new Main();
            dangNhap.dongMoForm(mo, dong);
        }

        private void btn_quanLy_Click(object sender, EventArgs e)
        {
            hieuUngClick(btn_quanLy);
            //frm dong = new frm();
            frmDoiMatKhau mo = new frmDoiMatKhau();
            this.Hide();
            mo.ShowDialog();
            //dangNhap.dongMoForm(mo, dong);
        }

        private void btn_danhMuc_Click(object sender, EventArgs e)
        {
            hieuUngClick(btn_danhMuc);
            frm dong = new frm();
            frmQuenMatKhau mo = new frmQuenMatKhau();
            dangNhap.dongMoForm(mo, dong);
        }

        private void btn_nhapHang_Click(object sender, EventArgs e)
        {
            hieuUngClick(btn_nhapHang);
            frm dong = new frm();
            frmDangKy mo = new frmDangKy();
            dangNhap.dongMoForm(mo, dong);
        }

        private void btn_timKiem_Click(object sender, EventArgs e)
        {
            hieuUngClick(btn_timKiem);

        }

        private void btn_danhKhoan_Click(object sender, EventArgs e)
        {
            //hieuUngClick(btn_taiKhoan1);

        }

        private void btn_trangChu_Leave(object sender, EventArgs e)
        {
            hieuUngLeav();
        }

        private void frm_MouseMove(object sender, MouseEventArgs e)
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

        private void frm_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void frm_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            dragCursor = Cursor.Position;
            dragForm = this.Location;
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_matKhau__TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Load(object sender, EventArgs e)
        {
            dataGridView_taiKhoan.DataSource = null;
            taiDuLieu();
            loadDuLieu();
        }

        string layTaiKhoan = "select * from taikhoan";
        public void taiDuLieu()
        {
            taiKhoanBang = kn.getDatatable(layTaiKhoan);
            dataGridView_taiKhoan.DataSource = taiKhoanBang;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tenDangNhap.Texts;
            string matKhau = txt_matKhau.Texts;
            string email = txt_email.Texts;
            string tenHienThi;
            string quyen = themQuyen;
            if(txt_tenHienThi.Texts == "")
            {
                tenHienThi = tenDangNhap;
            }   
            else
            {
                tenHienThi = txt_tenHienThi.Texts;
            }    

            string kiemTraTrungTen = "select * from taikhoan where tendangnhap = '" + tenDangNhap + "'";
            string kiemTraTrungEmail = "select * from taikhoan where email = '" + email + "'";

            int soLoi = -1;
            soLoi = kiemTraHopLeDangNhap(tenDangNhap, matKhau, email, tenHienThi, kiemTraTrungTen, kiemTraTrungEmail);

            if (soLoi == 0)
            {
                frmDangKy dangKy = new frmDangKy();

                string maHoaMatKhau = dangNhap.maHoaHash(matKhau);
                string taoTaiKhoan = "insert into taikhoan values('" + tenDangNhap + "',N'" + tenHienThi + "','" + maHoaMatKhau + "','" + quyen + "','" + email + "')";
                kn.getnonquery(taoTaiKhoan);
                MessageBox.Show("Tài khoản đã được đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lamTrong();
                taiDuLieu();
            }
        }

        public void chonTuBang()
        {
            TaiKhoan tk = new TaiKhoan();
            txt_tenDangNhap.DataBindings.Add("Text", dataGridView_taiKhoan.DataSource, "tendangnhap");
            txt_tenHienThi.DataBindings.Add("Text", dataGridView_taiKhoan.DataSource, "tenHienthi");
            txt_matKhau.DataBindings.Add("Text", dataGridView_taiKhoan.DataSource, "matkhau");
            txt_email.DataBindings.Add("Text", dataGridView_taiKhoan.DataSource, "email");
            
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tenDangNhap.Texts;
            string xoatk = "delete from TaiKhoan where TenDangNhap = '"+tenDangNhap+"'";
            int kq = 0;
            if(tenDangNhap.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập để xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                kq = kn.getnonquery(xoatk);
                if (kq > 0)
                {
                    MessageBox.Show("Tài khoản đã được xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    taiDuLieu();
                    lamTrong();
                }
                else
                {
                    MessageBox.Show("Lỗi khi xóa. Vui lòng nhập tên đăng nhập cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lamTrong();
                }
            }    
               
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txt_tenDangNhap.Texts;
            string tenHienThi = txt_tenHienThi.Texts;
            string matKhau = txt_matKhau.Texts;
            string email = txt_email.Texts;
            string quyen = themQuyen;

            int kq = 0;
            int soLoi = -1;

            soLoi = coRong(tenDangNhap, matKhau, email, tenHienThi);

            if (soLoi == 0)
            {
                frmDangKy dangKy = new frmDangKy();

                string maHoaMatKhau = dangNhap.maHoaHash(matKhau);
                string suatk = "update TaiKhoan set TenHienThi = N'" + tenHienThi + "', MatKhau = '"+maHoaMatKhau+"', Quyen = '" + quyen + "', Email = '" + email + "' where TenDangNhap = '" + tenDangNhap + "'";
                kq = kn.getnonquery(suatk);
                lamTrong();
                taiDuLieu();
            }
            if (kq > 0)
            {
                MessageBox.Show("Tài khoản đã được cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                taiDuLieu();
            }
            else
            {
                MessageBox.Show("Lỗi khi cập nhật. Vui lòng nhập tên đăng nhập cần cần sửa và các trường!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void minisize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void lamTrong()
        {
            txt_tenDangNhap.Texts = "";
            txt_tenHienThi.Texts = "";
            txt_matKhau.Texts = "";
            txt_email.Texts = "";
            chkb_quyen.Checked = false;
        }

        public string themQuyen = "NhanVien";
        private void checkBox_AnHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if(chkb_quyen.Checked == true)
            {
                themQuyen = "QuanLy";
            }   
            else
            {
                themQuyen = "nhanVien";
            }
        }

        public int coRong(string tenDangNhap, string matKhau, string email, string tenHienThi)
        {
            int soLoi = 0;
            if (tenDangNhap.Trim() == "" && matKhau.Trim() == "" && email.Trim() == "" && tenHienThi.Trim() == "")
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
                    MessageBox.Show("Tên đăng nhập không hợp lệ! độ dài tên từ 6 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Mật khẩu không hợp lệ! độ dài tên từ 6 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (tenHienThi.Trim() == "")
            {
                soLoi++;
                MessageBox.Show("Vui lòng nhập Tên hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            return soLoi;
        }

        private void checkBox_AnHienMatKhau_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox_AnHienMatKhau.Checked)
            {
                txt_matKhau.PasswordChar = false;
            }
            else
            {
                txt_matKhau.PasswordChar = true;
            }
        }

        public int kiemTraHopLeDangNhap(string tenDangNhap, string matKhau, string email, string tenHienThi, string kiemTraTrungTen, string kiemTraTrungEmail)
        {
            int soLoi = 0;
            if (tenDangNhap.Trim() == "" && matKhau.Trim() == "" && email.Trim() == "" && tenHienThi.Trim() == "")
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
                    MessageBox.Show("Tên đăng nhập không hợp lệ! độ dài tên từ 6 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    MessageBox.Show("Mật khẩu không hợp lệ! độ dài tên từ 6 đến 24 ký tự và không có ký tự đặc biệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            if (tenHienThi.Trim() == "")
            {
                soLoi++;
                MessageBox.Show("Vui lòng nhập Tên hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (dangNhap.layDStaiKhoan(kiemTraTrungTen).Count > 0)
            {
                MessageBox.Show("Tên người dùng đã được đăng ký, vui lòng nghĩ ra tên khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                soLoi++;
            }
            if (dangNhap.layDStaiKhoan(kiemTraTrungEmail).Count > 0)
            {
                soLoi++;
                MessageBox.Show("Email này đã được đăng ký, vui lòng nhập email khác!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return soLoi;
        }

    }
}
