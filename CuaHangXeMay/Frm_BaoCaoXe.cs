using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
namespace CuaHangXeMay
{
    public partial class Frm_BaoCaoXe : Form
    {
        public Frm_BaoCaoXe()
        {
            InitializeComponent();
        }
        public void DisplayReport()
        {
            CTRP_Xe rppn = new CTRP_Xe();
             CTRPV_Xe.ReportSource = rppn;
            rppn.SetDatabaseLogon("sa", "123", @"LAPTOP-4UK5DRJR\SQLEXPRESS", "QL_CuaHangXeGanMay");
            CTRPV_Xe.Refresh();
            CTRPV_Xe.DisplayToolbar = false;
            CTRPV_Xe.DisplayStatusBar = false;
        }
        private void CTRPV_Xe_Load(object sender, EventArgs e)
        {
            DisplayReport();
        }
    }
}
