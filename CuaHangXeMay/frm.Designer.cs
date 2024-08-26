//using System.Drawing;
//using System.Windows.Forms;

//namespace CuaHangXeMay
//{
//    partial class frm
//    {
//        /// <summary>
//        /// Required designer variable.
//        /// </summary>
//        private System.ComponentModel.IContainer components = null;

//        /// <summary>
//        /// Clean up any resources being used.
//        /// </summary>
//        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
//        protected override void Dispose(bool disposing)
//        {
//            if (disposing && (components != null))
//            {
//                components.Dispose();
//            }
//            base.Dispose(disposing);
//        }

//        #region Windows Form Designer generated code

//        /// <summary>
//        /// Required method for Designer support - do not modify
//        /// the contents of this method with the code editor.
//        /// </summary>
//        private void InitializeComponent()
//        {
//            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
//            this.panel1 = new System.Windows.Forms.Panel();
//            this.pnlNav = new System.Windows.Forms.Panel();
//            this.btn_timKiem = new System.Windows.Forms.Button();
//            this.btn_nhapHang = new System.Windows.Forms.Button();
//            this.btn_danhMuc = new System.Windows.Forms.Button();
//            this.btn_quanLy = new System.Windows.Forms.Button();
//            this.btn_trangChu = new System.Windows.Forms.Button();
//            this.panel2 = new System.Windows.Forms.Panel();
//            this.l_quyen = new System.Windows.Forms.Label();
//            this.l_tenNguoiDung = new System.Windows.Forms.Label();
//            this.pictureBox1 = new System.Windows.Forms.PictureBox();
//            this.panel3 = new System.Windows.Forms.Panel();
//            this.pictureBox2 = new System.Windows.Forms.PictureBox();
//            this.dataGridView_taiKhoan = new System.Windows.Forms.DataGridView();
//            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
//            this.pictureBox3 = new System.Windows.Forms.PictureBox();
//            this.btn_xoa = new CuaHangXeMay.KhanhBangButton();
//            this.btn_sua = new CuaHangXeMay.KhanhBangButton();
//            this.txt_tenHienThi = new CustomControls.RJControls.RJTextBox();
//            this.txt_email = new CustomControls.RJControls.RJTextBox();
//            this.txt_matKhau = new CustomControls.RJControls.RJTextBox();
//            this.txt_tenDangNhap = new CustomControls.RJControls.RJTextBox();
//            this.checkBox_AnHienMatKhau = new System.Windows.Forms.CheckBox();
//            this.label5 = new System.Windows.Forms.Label();
//            this.chkb_quyen = new System.Windows.Forms.CheckBox();
//            this.label4 = new System.Windows.Forms.Label();
//            this.label3 = new System.Windows.Forms.Label();
//            this.label1 = new System.Windows.Forms.Label();
//            this.label2 = new System.Windows.Forms.Label();
//            this.btn_Them = new CuaHangXeMay.KhanhBangButton();
//            this.panel1.SuspendLayout();
//            this.panel2.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
//            this.panel3.SuspendLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taiKhoan)).BeginInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
//            this.SuspendLayout();
//            // 
//            // panel1
//            // 
//            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
//            this.panel1.Controls.Add(this.pnlNav);
//            this.panel1.Controls.Add(this.btn_timKiem);
//            this.panel1.Controls.Add(this.btn_nhapHang);
//            this.panel1.Controls.Add(this.btn_danhMuc);
//            this.panel1.Controls.Add(this.btn_quanLy);
//            this.panel1.Controls.Add(this.btn_trangChu);
//            this.panel1.Controls.Add(this.panel2);
//            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
//            this.panel1.Location = new System.Drawing.Point(0, 0);
//            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.panel1.Name = "panel1";
//            this.panel1.Size = new System.Drawing.Size(238, 934);
//            this.panel1.TabIndex = 0;
//            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
//            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
//            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
//            // 
//            // pnlNav
//            // 
//            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
//            this.pnlNav.Location = new System.Drawing.Point(0, 257);
//            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.pnlNav.Name = "pnlNav";
//            this.pnlNav.Size = new System.Drawing.Size(6, 134);
//            this.pnlNav.TabIndex = 3;
//            // 
//            // btn_timKiem
//            // 
//            this.btn_timKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btn_timKiem.Dock = System.Windows.Forms.DockStyle.Top;
//            this.btn_timKiem.FlatAppearance.BorderSize = 0;
//            this.btn_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btn_timKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
//            this.btn_timKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
//            this.btn_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.btn_timKiem.Location = new System.Drawing.Point(0, 412);
//            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btn_timKiem.Name = "btn_timKiem";
//            this.btn_timKiem.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
//            this.btn_timKiem.Size = new System.Drawing.Size(238, 55);
//            this.btn_timKiem.TabIndex = 14;
//            this.btn_timKiem.Text = "Tìm kiếm";
//            this.btn_timKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.btn_timKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
//            this.btn_timKiem.UseVisualStyleBackColor = true;
//            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
//            // 
//            // btn_nhapHang
//            // 
//            this.btn_nhapHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btn_nhapHang.Dock = System.Windows.Forms.DockStyle.Top;
//            this.btn_nhapHang.FlatAppearance.BorderSize = 0;
//            this.btn_nhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btn_nhapHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
//            this.btn_nhapHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
//            this.btn_nhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.btn_nhapHang.Location = new System.Drawing.Point(0, 357);
//            this.btn_nhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btn_nhapHang.Name = "btn_nhapHang";
//            this.btn_nhapHang.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
//            this.btn_nhapHang.Size = new System.Drawing.Size(238, 55);
//            this.btn_nhapHang.TabIndex = 13;
//            this.btn_nhapHang.Text = "Đăng ký";
//            this.btn_nhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.btn_nhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
//            this.btn_nhapHang.UseVisualStyleBackColor = true;
//            this.btn_nhapHang.Click += new System.EventHandler(this.btn_nhapHang_Click);
//            // 
//            // btn_danhMuc
//            // 
//            this.btn_danhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btn_danhMuc.Dock = System.Windows.Forms.DockStyle.Top;
//            this.btn_danhMuc.FlatAppearance.BorderSize = 0;
//            this.btn_danhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btn_danhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
//            this.btn_danhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
//            this.btn_danhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.btn_danhMuc.Location = new System.Drawing.Point(0, 302);
//            this.btn_danhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btn_danhMuc.Name = "btn_danhMuc";
//            this.btn_danhMuc.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
//            this.btn_danhMuc.Size = new System.Drawing.Size(238, 55);
//            this.btn_danhMuc.TabIndex = 12;
//            this.btn_danhMuc.Text = "Quên mật khẩu";
//            this.btn_danhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.btn_danhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
//            this.btn_danhMuc.UseVisualStyleBackColor = true;
//            this.btn_danhMuc.Click += new System.EventHandler(this.btn_danhMuc_Click);
//            // 
//            // btn_quanLy
//            // 
//            this.btn_quanLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btn_quanLy.Dock = System.Windows.Forms.DockStyle.Top;
//            this.btn_quanLy.FlatAppearance.BorderSize = 0;
//            this.btn_quanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btn_quanLy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
//            this.btn_quanLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
//            this.btn_quanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.btn_quanLy.Location = new System.Drawing.Point(0, 247);
//            this.btn_quanLy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btn_quanLy.Name = "btn_quanLy";
//            this.btn_quanLy.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
//            this.btn_quanLy.Size = new System.Drawing.Size(238, 55);
//            this.btn_quanLy.TabIndex = 11;
//            this.btn_quanLy.Text = "Đổi mật khẩu";
//            this.btn_quanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.btn_quanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
//            this.btn_quanLy.UseVisualStyleBackColor = true;
//            this.btn_quanLy.Click += new System.EventHandler(this.btn_quanLy_Click);
//            // 
//            // btn_trangChu
//            // 
//            this.btn_trangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
//            this.btn_trangChu.Dock = System.Windows.Forms.DockStyle.Top;
//            this.btn_trangChu.FlatAppearance.BorderSize = 0;
//            this.btn_trangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btn_trangChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
//            this.btn_trangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
//            this.btn_trangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
//            this.btn_trangChu.Location = new System.Drawing.Point(0, 192);
//            this.btn_trangChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btn_trangChu.Name = "btn_trangChu";
//            this.btn_trangChu.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
//            this.btn_trangChu.Size = new System.Drawing.Size(238, 55);
//            this.btn_trangChu.TabIndex = 1;
//            this.btn_trangChu.Text = "Về Trang chủ";
//            this.btn_trangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
//            this.btn_trangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
//            this.btn_trangChu.UseVisualStyleBackColor = true;
//            this.btn_trangChu.Click += new System.EventHandler(this.btn_trangChu_Click);
//            // 
//            // panel2
//            // 
//            this.panel2.Controls.Add(this.l_quyen);
//            this.panel2.Controls.Add(this.l_tenNguoiDung);
//            this.panel2.Controls.Add(this.pictureBox1);
//            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panel2.Location = new System.Drawing.Point(0, 0);
//            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.panel2.Name = "panel2";
//            this.panel2.Size = new System.Drawing.Size(238, 192);
//            this.panel2.TabIndex = 0;
//            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
//            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
//            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
//            // 
//            // l_quyen
//            // 
//            this.l_quyen.AutoSize = true;
//            this.l_quyen.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
//            this.l_quyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
//            this.l_quyen.Location = new System.Drawing.Point(62, 152);
//            this.l_quyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.l_quyen.Name = "l_quyen";
//            this.l_quyen.Size = new System.Drawing.Size(129, 19);
//            this.l_quyen.TabIndex = 2;
//            this.l_quyen.Text = "mô tả người dùng";
//            // 
//            // l_tenNguoiDung
//            // 
//            this.l_tenNguoiDung.AutoSize = true;
//            this.l_tenNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
//            this.l_tenNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
//            this.l_tenNguoiDung.Location = new System.Drawing.Point(52, 120);
//            this.l_tenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.l_tenNguoiDung.Name = "l_tenNguoiDung";
//            this.l_tenNguoiDung.Size = new System.Drawing.Size(149, 25);
//            this.l_tenNguoiDung.TabIndex = 1;
//            this.l_tenNguoiDung.Text = "Tên Người dùng";
//            // 
//            // pictureBox1
//            // 
//            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
//            this.pictureBox1.Location = new System.Drawing.Point(76, 29);
//            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.pictureBox1.Name = "pictureBox1";
//            this.pictureBox1.Size = new System.Drawing.Size(76, 85);
//            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
//            this.pictureBox1.TabIndex = 0;
//            this.pictureBox1.TabStop = false;
//            // 
//            // panel3
//            // 
//            this.panel3.Controls.Add(this.pictureBox2);
//            this.panel3.Controls.Add(this.pictureBox3);
//            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
//            this.panel3.Location = new System.Drawing.Point(238, 0);
//            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.panel3.Name = "panel3";
//            this.panel3.Size = new System.Drawing.Size(1306, 71);
//            this.panel3.TabIndex = 1;
//            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
//            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
//            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
//            // 
//            // pictureBox2
//            // 
//            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
//            this.pictureBox2.Location = new System.Drawing.Point(1255, 14);
//            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.pictureBox2.Name = "pictureBox2";
//            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
//            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
//            this.pictureBox2.TabIndex = 43;
//            this.pictureBox2.TabStop = false;
//            // 
//            // dataGridView_taiKhoan
//            // 
//            this.dataGridView_taiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
//            this.dataGridView_taiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
//            this.dataGridView_taiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
//            this.dataGridView_taiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
//            this.Column1,
//            this.Column2,
//            this.Column3,
//            this.Column4,
//            this.Column5});
//            this.dataGridView_taiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
//            this.dataGridView_taiKhoan.Location = new System.Drawing.Point(238, 69);
//            this.dataGridView_taiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.dataGridView_taiKhoan.Name = "dataGridView_taiKhoan";
//            this.dataGridView_taiKhoan.Size = new System.Drawing.Size(1287, 398);
//            this.dataGridView_taiKhoan.TabIndex = 59;
//            // 
//            // Column1
//            // 
//            this.Column1.DataPropertyName = "Tendangnhap";
//            this.Column1.HeaderText = "Tên đăng nhập";
//            this.Column1.Name = "Column1";
//            this.Column1.Width = 165;
//            // 
//            // Column2
//            // 
//            this.Column2.DataPropertyName = "TenHienthi";
//            this.Column2.HeaderText = "Tên hiển thị";
//            this.Column2.Name = "Column2";
//            this.Column2.Width = 166;
//            // 
//            // Column3
//            // 
//            this.Column3.DataPropertyName = "MatKhau";
//            this.Column3.HeaderText = "Mật khẩu";
//            this.Column3.Name = "Column3";
//            this.Column3.Width = 165;
//            // 
//            // Column4
//            // 
//            this.Column4.DataPropertyName = "Quyen";
//            this.Column4.HeaderText = "Quyền ";
//            this.Column4.Name = "Column4";
//            this.Column4.Width = 166;
//            // 
//            // Column5
//            // 
//            this.Column5.DataPropertyName = "Email";
//            this.Column5.HeaderText = "Email";
//            this.Column5.Name = "Column5";
//            this.Column5.Width = 165;
//            // 
//            // pictureBox3
//            // 
//            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
//            this.pictureBox3.Location = new System.Drawing.Point(1207, 14);
//            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.pictureBox3.Name = "pictureBox3";
//            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
//            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
//            this.pictureBox3.TabIndex = 44;
//            this.pictureBox3.TabStop = false;
//            // 
//            // btn_xoa
//            // 
//            this.btn_xoa.BackColor = System.Drawing.Color.MediumSlateBlue;
//            this.btn_xoa.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
//            this.btn_xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
//            this.btn_xoa.BorderRadius = 20;
//            this.btn_xoa.BorderSize = 0;
//            this.btn_xoa.FlatAppearance.BorderSize = 0;
//            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btn_xoa.ForeColor = System.Drawing.SystemColors.Info;
//            this.btn_xoa.Location = new System.Drawing.Point(554, 707);
//            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btn_xoa.Name = "btn_xoa";
//            this.btn_xoa.Size = new System.Drawing.Size(225, 62);
//            this.btn_xoa.TabIndex = 58;
//            this.btn_xoa.Text = "Xóa";
//            this.btn_xoa.TextColor = System.Drawing.SystemColors.Info;
//            this.btn_xoa.UseVisualStyleBackColor = false;
//            // 
//            // btn_sua
//            // 
//            this.btn_sua.BackColor = System.Drawing.Color.MediumSlateBlue;
//            this.btn_sua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
//            this.btn_sua.BorderColor = System.Drawing.Color.PaleVioletRed;
//            this.btn_sua.BorderRadius = 20;
//            this.btn_sua.BorderSize = 0;
//            this.btn_sua.FlatAppearance.BorderSize = 0;
//            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btn_sua.ForeColor = System.Drawing.SystemColors.Info;
//            this.btn_sua.Location = new System.Drawing.Point(818, 707);
//            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btn_sua.Name = "btn_sua";
//            this.btn_sua.Size = new System.Drawing.Size(225, 62);
//            this.btn_sua.TabIndex = 57;
//            this.btn_sua.Text = "Sửa";
//            this.btn_sua.TextColor = System.Drawing.SystemColors.Info;
//            this.btn_sua.UseVisualStyleBackColor = false;
//            // 
//            // txt_tenHienThi
//            // 
//            this.txt_tenHienThi.BackColor = System.Drawing.SystemColors.Info;
//            this.txt_tenHienThi.BorderColor = System.Drawing.Color.Transparent;
//            this.txt_tenHienThi.BorderFocusColor = System.Drawing.Color.HotPink;
//            this.txt_tenHienThi.BorderSize = 0;
//            this.txt_tenHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txt_tenHienThi.ForeColor = System.Drawing.Color.DimGray;
//            this.txt_tenHienThi.Location = new System.Drawing.Point(668, 516);
//            this.txt_tenHienThi.Margin = new System.Windows.Forms.Padding(6);
//            this.txt_tenHienThi.Multiline = false;
//            this.txt_tenHienThi.Name = "txt_tenHienThi";
//            this.txt_tenHienThi.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
//            this.txt_tenHienThi.PasswordChar = false;
//            this.txt_tenHienThi.Size = new System.Drawing.Size(375, 47);
//            this.txt_tenHienThi.TabIndex = 56;
//            this.txt_tenHienThi.Texts = "";
//            this.txt_tenHienThi.UnderlinedStyle = false;
//            // 
//            // txt_email
//            // 
//            this.txt_email.BackColor = System.Drawing.SystemColors.Info;
//            this.txt_email.BorderColor = System.Drawing.Color.Transparent;
//            this.txt_email.BorderFocusColor = System.Drawing.Color.HotPink;
//            this.txt_email.BorderSize = 0;
//            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txt_email.ForeColor = System.Drawing.Color.DimGray;
//            this.txt_email.Location = new System.Drawing.Point(280, 616);
//            this.txt_email.Margin = new System.Windows.Forms.Padding(6);
//            this.txt_email.Multiline = false;
//            this.txt_email.Name = "txt_email";
//            this.txt_email.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
//            this.txt_email.PasswordChar = false;
//            this.txt_email.Size = new System.Drawing.Size(375, 47);
//            this.txt_email.TabIndex = 55;
//            this.txt_email.Texts = "";
//            this.txt_email.UnderlinedStyle = false;
//            // 
//            // txt_matKhau
//            // 
//            this.txt_matKhau.BackColor = System.Drawing.SystemColors.Info;
//            this.txt_matKhau.BorderColor = System.Drawing.Color.Transparent;
//            this.txt_matKhau.BorderFocusColor = System.Drawing.Color.HotPink;
//            this.txt_matKhau.BorderSize = 0;
//            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txt_matKhau.ForeColor = System.Drawing.Color.DimGray;
//            this.txt_matKhau.Location = new System.Drawing.Point(1054, 516);
//            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(6);
//            this.txt_matKhau.Multiline = false;
//            this.txt_matKhau.Name = "txt_matKhau";
//            this.txt_matKhau.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
//            this.txt_matKhau.PasswordChar = true;
//            this.txt_matKhau.Size = new System.Drawing.Size(382, 47);
//            this.txt_matKhau.TabIndex = 54;
//            this.txt_matKhau.Texts = "";
//            this.txt_matKhau.UnderlinedStyle = false;
//            // 
//            // txt_tenDangNhap
//            // 
//            this.txt_tenDangNhap.BackColor = System.Drawing.SystemColors.Info;
//            this.txt_tenDangNhap.BorderColor = System.Drawing.Color.Transparent;
//            this.txt_tenDangNhap.BorderFocusColor = System.Drawing.Color.HotPink;
//            this.txt_tenDangNhap.BorderSize = 0;
//            this.txt_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.txt_tenDangNhap.ForeColor = System.Drawing.Color.DimGray;
//            this.txt_tenDangNhap.Location = new System.Drawing.Point(280, 516);
//            this.txt_tenDangNhap.Margin = new System.Windows.Forms.Padding(6);
//            this.txt_tenDangNhap.Multiline = false;
//            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
//            this.txt_tenDangNhap.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
//            this.txt_tenDangNhap.PasswordChar = false;
//            this.txt_tenDangNhap.Size = new System.Drawing.Size(375, 47);
//            this.txt_tenDangNhap.TabIndex = 53;
//            this.txt_tenDangNhap.Texts = "";
//            this.txt_tenDangNhap.UnderlinedStyle = false;
//            // 
//            // checkBox_AnHienMatKhau
//            // 
//            this.checkBox_AnHienMatKhau.AutoSize = true;
//            this.checkBox_AnHienMatKhau.BackColor = System.Drawing.Color.Transparent;
//            this.checkBox_AnHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.checkBox_AnHienMatKhau.ForeColor = System.Drawing.SystemColors.Info;
//            this.checkBox_AnHienMatKhau.Location = new System.Drawing.Point(1251, 480);
//            this.checkBox_AnHienMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.checkBox_AnHienMatKhau.Name = "checkBox_AnHienMatKhau";
//            this.checkBox_AnHienMatKhau.Size = new System.Drawing.Size(198, 35);
//            this.checkBox_AnHienMatKhau.TabIndex = 52;
//            this.checkBox_AnHienMatKhau.Text = "Hiện mật khẩu";
//            this.checkBox_AnHienMatKhau.UseVisualStyleBackColor = false;
//            // 
//            // label5
//            // 
//            this.label5.AutoSize = true;
//            this.label5.BackColor = System.Drawing.Color.Transparent;
//            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label5.ForeColor = System.Drawing.SystemColors.Info;
//            this.label5.Location = new System.Drawing.Point(663, 580);
//            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label5.Name = "label5";
//            this.label5.Size = new System.Drawing.Size(83, 31);
//            this.label5.TabIndex = 51;
//            this.label5.Text = "Quyền";
//            // 
//            // chkb_quyen
//            // 
//            this.chkb_quyen.AutoSize = true;
//            this.chkb_quyen.BackColor = System.Drawing.Color.Transparent;
//            this.chkb_quyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.chkb_quyen.ForeColor = System.Drawing.SystemColors.Info;
//            this.chkb_quyen.Location = new System.Drawing.Point(670, 623);
//            this.chkb_quyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.chkb_quyen.Name = "chkb_quyen";
//            this.chkb_quyen.Size = new System.Drawing.Size(122, 35);
//            this.chkb_quyen.TabIndex = 50;
//            this.chkb_quyen.Text = "Quản lý";
//            this.chkb_quyen.UseVisualStyleBackColor = false;
//            // 
//            // label4
//            // 
//            this.label4.AutoSize = true;
//            this.label4.BackColor = System.Drawing.Color.Transparent;
//            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label4.ForeColor = System.Drawing.SystemColors.Info;
//            this.label4.Location = new System.Drawing.Point(274, 580);
//            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label4.Name = "label4";
//            this.label4.Size = new System.Drawing.Size(73, 31);
//            this.label4.TabIndex = 49;
//            this.label4.Text = "Email";
//            // 
//            // label3
//            // 
//            this.label3.AutoSize = true;
//            this.label3.BackColor = System.Drawing.Color.Transparent;
//            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label3.ForeColor = System.Drawing.SystemColors.Info;
//            this.label3.Location = new System.Drawing.Point(1048, 480);
//            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label3.Name = "label3";
//            this.label3.Size = new System.Drawing.Size(116, 31);
//            this.label3.TabIndex = 48;
//            this.label3.Text = "Mật khẩu";
//            // 
//            // label1
//            // 
//            this.label1.AutoSize = true;
//            this.label1.BackColor = System.Drawing.Color.Transparent;
//            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label1.ForeColor = System.Drawing.SystemColors.Info;
//            this.label1.Location = new System.Drawing.Point(662, 480);
//            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label1.Name = "label1";
//            this.label1.Size = new System.Drawing.Size(140, 31);
//            this.label1.TabIndex = 47;
//            this.label1.Text = "Tên hiển thị";
//            // 
//            // label2
//            // 
//            this.label2.AutoSize = true;
//            this.label2.BackColor = System.Drawing.Color.Transparent;
//            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.label2.ForeColor = System.Drawing.SystemColors.Info;
//            this.label2.Location = new System.Drawing.Point(274, 480);
//            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
//            this.label2.Name = "label2";
//            this.label2.Size = new System.Drawing.Size(172, 31);
//            this.label2.TabIndex = 46;
//            this.label2.Text = "Tên đăng nhập";
//            // 
//            // btn_Them
//            // 
//            this.btn_Them.BackColor = System.Drawing.Color.MediumSlateBlue;
//            this.btn_Them.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
//            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
//            this.btn_Them.BorderRadius = 20;
//            this.btn_Them.BorderSize = 0;
//            this.btn_Them.FlatAppearance.BorderSize = 0;
//            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
//            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
//            this.btn_Them.ForeColor = System.Drawing.SystemColors.Info;
//            this.btn_Them.Location = new System.Drawing.Point(280, 707);
//            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.btn_Them.Name = "btn_Them";
//            this.btn_Them.Size = new System.Drawing.Size(225, 62);
//            this.btn_Them.TabIndex = 45;
//            this.btn_Them.Text = "Thêm";
//            this.btn_Them.TextColor = System.Drawing.SystemColors.Info;
//            this.btn_Them.UseVisualStyleBackColor = false;
//            // 
//            // frm
//            // 
//            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
//            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
//            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
//            this.ClientSize = new System.Drawing.Size(1544, 934);
//            this.Controls.Add(this.dataGridView_taiKhoan);
//            this.Controls.Add(this.btn_xoa);
//            this.Controls.Add(this.btn_sua);
//            this.Controls.Add(this.txt_tenHienThi);
//            this.Controls.Add(this.txt_email);
//            this.Controls.Add(this.txt_matKhau);
//            this.Controls.Add(this.txt_tenDangNhap);
//            this.Controls.Add(this.checkBox_AnHienMatKhau);
//            this.Controls.Add(this.label5);
//            this.Controls.Add(this.chkb_quyen);
//            this.Controls.Add(this.label4);
//            this.Controls.Add(this.label3);
//            this.Controls.Add(this.label1);
//            this.Controls.Add(this.label2);
//            this.Controls.Add(this.btn_Them);
//            this.Controls.Add(this.panel3);
//            this.Controls.Add(this.panel1);
//            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
//            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
//            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
//            this.Name = "frm";
//            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
//            this.Text = "frmMain";
//            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
//            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
//            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
//            this.panel1.ResumeLayout(false);
//            this.panel2.ResumeLayout(false);
//            this.panel2.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
//            this.panel3.ResumeLayout(false);
//            this.panel3.PerformLayout();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taiKhoan)).EndInit();
//            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
//            this.ResumeLayout(false);
//            this.PerformLayout();

//        }

//        #endregion

//        private System.Windows.Forms.Panel panel1;
//        private System.Windows.Forms.Panel panel2;
//        private System.Windows.Forms.Label l_quyen;
//        private System.Windows.Forms.Label l_tenNguoiDung;
//        private System.Windows.Forms.PictureBox pictureBox1;
//        private System.Windows.Forms.Button btn_timKiem;
//        private System.Windows.Forms.Button btn_nhapHang;
//        private System.Windows.Forms.Button btn_danhMuc;
//        private System.Windows.Forms.Button btn_quanLy;
//        private System.Windows.Forms.Button btn_trangChu;
//        private System.Windows.Forms.Panel panel3;
//        private Panel pnlNav;
//        private PictureBox pictureBox2;
//        private PictureBox pictureBox3;
//        private DataGridView dataGridView_taiKhoan;
//        private DataGridViewTextBoxColumn Column1;
//        private DataGridViewTextBoxColumn Column2;
//        private DataGridViewTextBoxColumn Column3;
//        private DataGridViewTextBoxColumn Column4;
//        private DataGridViewTextBoxColumn Column5;
//        private KhanhBangButton btn_xoa;
//        private KhanhBangButton btn_sua;
//        private CustomControls.RJControls.RJTextBox txt_tenHienThi;
//        private CustomControls.RJControls.RJTextBox txt_email;
//        private CustomControls.RJControls.RJTextBox txt_matKhau;
//        private CustomControls.RJControls.RJTextBox txt_tenDangNhap;
//        private CheckBox checkBox_AnHienMatKhau;
//        private Label label5;
//        private CheckBox chkb_quyen;
//        private Label label4;
//        private Label label3;
//        private Label label1;
//        private Label label2;
//        private KhanhBangButton btn_Them;
//    }
//}

using System.Drawing;
using System.Windows.Forms;

namespace CuaHangXeMay
{
    partial class frm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.btn_timKiem = new System.Windows.Forms.Button();
            this.btn_nhapHang = new System.Windows.Forms.Button();
            this.btn_danhMuc = new System.Windows.Forms.Button();
            this.btn_quanLy = new System.Windows.Forms.Button();
            this.btn_trangChu = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.l_quyen = new System.Windows.Forms.Label();
            this.l_tenNguoiDung = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chkb_quyen = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox_AnHienMatKhau = new System.Windows.Forms.CheckBox();
            this.btn_xoa = new CuaHangXeMay.KhanhBangButton();
            this.btn_sua = new CuaHangXeMay.KhanhBangButton();
            this.txt_tenHienThi = new CustomControls.RJControls.RJTextBox();
            this.txt_email = new CustomControls.RJControls.RJTextBox();
            this.txt_matKhau = new CustomControls.RJControls.RJTextBox();
            this.txt_tenDangNhap = new CustomControls.RJControls.RJTextBox();
            this.btn_Them = new CuaHangXeMay.KhanhBangButton();
            this.dataGridView_taiKhoan = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pnlNav);
            this.panel1.Controls.Add(this.btn_timKiem);
            this.panel1.Controls.Add(this.btn_nhapHang);
            this.panel1.Controls.Add(this.btn_danhMuc);
            this.panel1.Controls.Add(this.btn_quanLy);
            this.panel1.Controls.Add(this.btn_trangChu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 934);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pnlNav.Location = new System.Drawing.Point(0, 257);
            this.pnlNav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(6, 134);
            this.pnlNav.TabIndex = 3;
            // 
            // btn_timKiem
            // 
            this.btn_timKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_timKiem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_timKiem.FlatAppearance.BorderSize = 0;
            this.btn_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_timKiem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_timKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_timKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_timKiem.Location = new System.Drawing.Point(0, 412);
            this.btn_timKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_timKiem.Name = "btn_timKiem";
            this.btn_timKiem.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.btn_timKiem.Size = new System.Drawing.Size(238, 55);
            this.btn_timKiem.TabIndex = 14;
            this.btn_timKiem.Text = "Tìm kiếm";
            this.btn_timKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_timKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_timKiem.UseVisualStyleBackColor = true;
            this.btn_timKiem.Click += new System.EventHandler(this.btn_timKiem_Click);
            // 
            // btn_nhapHang
            // 
            this.btn_nhapHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_nhapHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_nhapHang.FlatAppearance.BorderSize = 0;
            this.btn_nhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nhapHang.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_nhapHang.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_nhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_nhapHang.Location = new System.Drawing.Point(0, 357);
            this.btn_nhapHang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_nhapHang.Name = "btn_nhapHang";
            this.btn_nhapHang.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.btn_nhapHang.Size = new System.Drawing.Size(238, 55);
            this.btn_nhapHang.TabIndex = 13;
            this.btn_nhapHang.Text = "Đăng ký";
            this.btn_nhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_nhapHang.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_nhapHang.UseVisualStyleBackColor = true;
            this.btn_nhapHang.Click += new System.EventHandler(this.btn_nhapHang_Click);
            // 
            // btn_danhMuc
            // 
            this.btn_danhMuc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_danhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_danhMuc.FlatAppearance.BorderSize = 0;
            this.btn_danhMuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_danhMuc.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_danhMuc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_danhMuc.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_danhMuc.Location = new System.Drawing.Point(0, 302);
            this.btn_danhMuc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_danhMuc.Name = "btn_danhMuc";
            this.btn_danhMuc.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.btn_danhMuc.Size = new System.Drawing.Size(238, 55);
            this.btn_danhMuc.TabIndex = 12;
            this.btn_danhMuc.Text = "Quên mật khẩu";
            this.btn_danhMuc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_danhMuc.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_danhMuc.UseVisualStyleBackColor = true;
            this.btn_danhMuc.Click += new System.EventHandler(this.btn_danhMuc_Click);
            // 
            // btn_quanLy
            // 
            this.btn_quanLy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_quanLy.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_quanLy.FlatAppearance.BorderSize = 0;
            this.btn_quanLy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quanLy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_quanLy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_quanLy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_quanLy.Location = new System.Drawing.Point(0, 247);
            this.btn_quanLy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_quanLy.Name = "btn_quanLy";
            this.btn_quanLy.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.btn_quanLy.Size = new System.Drawing.Size(238, 55);
            this.btn_quanLy.TabIndex = 11;
            this.btn_quanLy.Text = "Đổi mật khẩu";
            this.btn_quanLy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quanLy.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_quanLy.UseVisualStyleBackColor = true;
            this.btn_quanLy.Click += new System.EventHandler(this.btn_quanLy_Click);
            // 
            // btn_trangChu
            // 
            this.btn_trangChu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_trangChu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_trangChu.FlatAppearance.BorderSize = 0;
            this.btn_trangChu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_trangChu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_trangChu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_trangChu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_trangChu.Location = new System.Drawing.Point(0, 192);
            this.btn_trangChu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_trangChu.Name = "btn_trangChu";
            this.btn_trangChu.Padding = new System.Windows.Forms.Padding(14, 0, 14, 0);
            this.btn_trangChu.Size = new System.Drawing.Size(238, 55);
            this.btn_trangChu.TabIndex = 1;
            this.btn_trangChu.Text = "Về Trang chủ";
            this.btn_trangChu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_trangChu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btn_trangChu.UseVisualStyleBackColor = true;
            this.btn_trangChu.Click += new System.EventHandler(this.btn_trangChu_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.l_quyen);
            this.panel2.Controls.Add(this.l_tenNguoiDung);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(238, 192);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // l_quyen
            // 
            this.l_quyen.AutoSize = true;
            this.l_quyen.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Bold);
            this.l_quyen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.l_quyen.Location = new System.Drawing.Point(54, 152);
            this.l_quyen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_quyen.Name = "l_quyen";
            this.l_quyen.Size = new System.Drawing.Size(129, 19);
            this.l_quyen.TabIndex = 2;
            this.l_quyen.Text = "mô tả người dùng";
            // 
            // l_tenNguoiDung
            // 
            this.l_tenNguoiDung.AutoSize = true;
            this.l_tenNguoiDung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.l_tenNguoiDung.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.l_tenNguoiDung.Location = new System.Drawing.Point(44, 120);
            this.l_tenNguoiDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_tenNguoiDung.Name = "l_tenNguoiDung";
            this.l_tenNguoiDung.Size = new System.Drawing.Size(149, 25);
            this.l_tenNguoiDung.TabIndex = 1;
            this.l_tenNguoiDung.Text = "Tên Người dùng";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(76, 29);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 85);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.pictureBox3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(238, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1306, 71);
            this.panel3.TabIndex = 1;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.panel3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Info;
            this.label2.Location = new System.Drawing.Point(274, 482);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 31);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(662, 482);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 31);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tên hiển thị";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Info;
            this.label3.Location = new System.Drawing.Point(1048, 482);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 30;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Info;
            this.label4.Location = new System.Drawing.Point(274, 582);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 31);
            this.label4.TabIndex = 32;
            this.label4.Text = "Email";
            // 
            // chkb_quyen
            // 
            this.chkb_quyen.AutoSize = true;
            this.chkb_quyen.BackColor = System.Drawing.Color.Transparent;
            this.chkb_quyen.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkb_quyen.ForeColor = System.Drawing.SystemColors.Info;
            this.chkb_quyen.Location = new System.Drawing.Point(670, 625);
            this.chkb_quyen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkb_quyen.Name = "chkb_quyen";
            this.chkb_quyen.Size = new System.Drawing.Size(122, 35);
            this.chkb_quyen.TabIndex = 33;
            this.chkb_quyen.Text = "Quản lý";
            this.chkb_quyen.UseVisualStyleBackColor = false;
            this.chkb_quyen.CheckedChanged += new System.EventHandler(this.checkBox_AnHienMatKhau_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Info;
            this.label5.Location = new System.Drawing.Point(663, 582);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 31);
            this.label5.TabIndex = 34;
            this.label5.Text = "Quyền";
            // 
            // checkBox_AnHienMatKhau
            // 
            this.checkBox_AnHienMatKhau.AutoSize = true;
            this.checkBox_AnHienMatKhau.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_AnHienMatKhau.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_AnHienMatKhau.ForeColor = System.Drawing.SystemColors.Info;
            this.checkBox_AnHienMatKhau.Location = new System.Drawing.Point(1251, 482);
            this.checkBox_AnHienMatKhau.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox_AnHienMatKhau.Name = "checkBox_AnHienMatKhau";
            this.checkBox_AnHienMatKhau.Size = new System.Drawing.Size(198, 35);
            this.checkBox_AnHienMatKhau.TabIndex = 35;
            this.checkBox_AnHienMatKhau.Text = "Hiện mật khẩu";
            this.checkBox_AnHienMatKhau.UseVisualStyleBackColor = false;
            this.checkBox_AnHienMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_AnHienMatKhau_CheckedChanged_1);
            // 
            // btn_xoa
            // 
            this.btn_xoa.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_xoa.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_xoa.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_xoa.BorderRadius = 20;
            this.btn_xoa.BorderSize = 0;
            this.btn_xoa.FlatAppearance.BorderSize = 0;
            this.btn_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xoa.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xoa.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_xoa.Location = new System.Drawing.Point(554, 709);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(225, 62);
            this.btn_xoa.TabIndex = 41;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.TextColor = System.Drawing.SystemColors.Info;
            this.btn_xoa.UseVisualStyleBackColor = false;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_sua.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_sua.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_sua.BorderRadius = 20;
            this.btn_sua.BorderSize = 0;
            this.btn_sua.FlatAppearance.BorderSize = 0;
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_sua.Location = new System.Drawing.Point(818, 709);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(225, 62);
            this.btn_sua.TabIndex = 40;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.TextColor = System.Drawing.SystemColors.Info;
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // txt_tenHienThi
            // 
            this.txt_tenHienThi.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tenHienThi.BorderColor = System.Drawing.Color.Transparent;
            this.txt_tenHienThi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tenHienThi.BorderSize = 0;
            this.txt_tenHienThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenHienThi.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tenHienThi.Location = new System.Drawing.Point(668, 518);
            this.txt_tenHienThi.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_tenHienThi.Multiline = false;
            this.txt_tenHienThi.Name = "txt_tenHienThi";
            this.txt_tenHienThi.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txt_tenHienThi.PasswordChar = false;
            this.txt_tenHienThi.Size = new System.Drawing.Size(375, 47);
            this.txt_tenHienThi.TabIndex = 39;
            this.txt_tenHienThi.Texts = "";
            this.txt_tenHienThi.UnderlinedStyle = false;
            // 
            // txt_email
            // 
            this.txt_email.BackColor = System.Drawing.SystemColors.Info;
            this.txt_email.BorderColor = System.Drawing.Color.Transparent;
            this.txt_email.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_email.BorderSize = 0;
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.ForeColor = System.Drawing.Color.DimGray;
            this.txt_email.Location = new System.Drawing.Point(280, 618);
            this.txt_email.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_email.Multiline = false;
            this.txt_email.Name = "txt_email";
            this.txt_email.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txt_email.PasswordChar = false;
            this.txt_email.Size = new System.Drawing.Size(375, 47);
            this.txt_email.TabIndex = 38;
            this.txt_email.Texts = "";
            this.txt_email.UnderlinedStyle = false;
            // 
            // txt_matKhau
            // 
            this.txt_matKhau.BackColor = System.Drawing.SystemColors.Info;
            this.txt_matKhau.BorderColor = System.Drawing.Color.Transparent;
            this.txt_matKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_matKhau.BorderSize = 0;
            this.txt_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_matKhau.ForeColor = System.Drawing.Color.DimGray;
            this.txt_matKhau.Location = new System.Drawing.Point(1054, 518);
            this.txt_matKhau.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_matKhau.Multiline = false;
            this.txt_matKhau.Name = "txt_matKhau";
            this.txt_matKhau.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txt_matKhau.PasswordChar = true;
            this.txt_matKhau.Size = new System.Drawing.Size(382, 47);
            this.txt_matKhau.TabIndex = 37;
            this.txt_matKhau.Texts = "";
            this.txt_matKhau.UnderlinedStyle = false;
            this.txt_matKhau._TextChanged += new System.EventHandler(this.txt_matKhau__TextChanged);
            // 
            // txt_tenDangNhap
            // 
            this.txt_tenDangNhap.BackColor = System.Drawing.SystemColors.Info;
            this.txt_tenDangNhap.BorderColor = System.Drawing.Color.Transparent;
            this.txt_tenDangNhap.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txt_tenDangNhap.BorderSize = 0;
            this.txt_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tenDangNhap.ForeColor = System.Drawing.Color.DimGray;
            this.txt_tenDangNhap.Location = new System.Drawing.Point(280, 518);
            this.txt_tenDangNhap.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txt_tenDangNhap.Multiline = false;
            this.txt_tenDangNhap.Name = "txt_tenDangNhap";
            this.txt_tenDangNhap.Padding = new System.Windows.Forms.Padding(10, 11, 10, 11);
            this.txt_tenDangNhap.PasswordChar = false;
            this.txt_tenDangNhap.Size = new System.Drawing.Size(375, 47);
            this.txt_tenDangNhap.TabIndex = 36;
            this.txt_tenDangNhap.Texts = "";
            this.txt_tenDangNhap.UnderlinedStyle = false;
            // 
            // btn_Them
            // 
            this.btn_Them.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_Them.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btn_Them.BorderRadius = 20;
            this.btn_Them.BorderSize = 0;
            this.btn_Them.FlatAppearance.BorderSize = 0;
            this.btn_Them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Them.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_Them.Location = new System.Drawing.Point(280, 709);
            this.btn_Them.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(225, 62);
            this.btn_Them.TabIndex = 3;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.TextColor = System.Drawing.SystemColors.Info;
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // dataGridView_taiKhoan
            // 
            this.dataGridView_taiKhoan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.dataGridView_taiKhoan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_taiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_taiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView_taiKhoan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.dataGridView_taiKhoan.Location = new System.Drawing.Point(238, 71);
            this.dataGridView_taiKhoan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView_taiKhoan.Name = "dataGridView_taiKhoan";
            this.dataGridView_taiKhoan.Size = new System.Drawing.Size(1287, 398);
            this.dataGridView_taiKhoan.TabIndex = 42;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Tendangnhap";
            this.Column1.HeaderText = "Tên đăng nhập";
            this.Column1.Name = "Column1";
            this.Column1.Width = 165;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenHienthi";
            this.Column2.HeaderText = "Tên hiển thị";
            this.Column2.Name = "Column2";
            this.Column2.Width = 166;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MatKhau";
            this.Column3.HeaderText = "Mật khẩu";
            this.Column3.Name = "Column3";
            this.Column3.Width = 165;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Quyen";
            this.Column4.HeaderText = "Quyền ";
            this.Column4.Name = "Column4";
            this.Column4.Width = 166;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Email";
            this.Column5.HeaderText = "Email";
            this.Column5.Name = "Column5";
            this.Column5.Width = 165;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1199, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.minisize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1247, 14);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 32);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.exit_Click);
            // 
            // frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(51)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1544, 934);
            this.Controls.Add(this.dataGridView_taiKhoan);
            this.Controls.Add(this.btn_xoa);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.txt_tenHienThi);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_matKhau);
            this.Controls.Add(this.txt_tenDangNhap);
            this.Controls.Add(this.checkBox_AnHienMatKhau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.chkb_quyen);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Them);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frm_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_taiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label l_quyen;
        private System.Windows.Forms.Label l_tenNguoiDung;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_timKiem;
        private System.Windows.Forms.Button btn_nhapHang;
        private System.Windows.Forms.Button btn_danhMuc;
        private System.Windows.Forms.Button btn_quanLy;
        private System.Windows.Forms.Button btn_trangChu;
        private System.Windows.Forms.Panel panel3;
        private Panel pnlNav;
        private KhanhBangButton btn_Them;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private CheckBox chkb_quyen;
        private Label label5;
        private CheckBox checkBox_AnHienMatKhau;
        private CustomControls.RJControls.RJTextBox txt_email;
        private CustomControls.RJControls.RJTextBox txt_matKhau;
        private CustomControls.RJControls.RJTextBox txt_tenDangNhap;
        private CustomControls.RJControls.RJTextBox txt_tenHienThi;
        private KhanhBangButton btn_sua;
        private KhanhBangButton btn_xoa;
        private DataGridView dataGridView_taiKhoan;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}