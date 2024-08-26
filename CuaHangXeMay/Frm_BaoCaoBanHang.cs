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
    public partial class Frm_BaoCaoBanHang : Form
    {
        DBConnect db = new DBConnect();
        public Frm_BaoCaoBanHang()
        {
            InitializeComponent();
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            string sql = "SELECT *FROM HoaDon AS H INNER JOIN ChiTietHoaDon AS C ON C.MaHoaDon = H.MaHoaDon WHERE H.NgayLap BETWEEN '"+dt_fromdar.Value+"' AND '"+dt_todate.Value+"'";
                DataTable dt_hoadontheongay = db.getDatatable(sql);
                CRP_TKHD tkhd = new CRP_TKHD();
            tkhd.SetDataSource(dt_hoadontheongay);
            CRV_TKHD.ReportSource = tkhd;
            tkhd.SetDatabaseLogon("sa", "123", @"LAPTOP-4UK5DRJR\SQLEXPRESS", "QL_CuaHangXeGanMay");
            CRV_TKHD.Refresh();
            CRV_TKHD.DisplayToolbar = false;
            CRV_TKHD.DisplayStatusBar = false;
          
        }

    }
}
