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
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }

        public void DisplayReport(ReportClass report)
        {
          CRV_detail.ReportSource = report;
report.SetDatabaseLogon("sa","123",@"LAPTOP-4UK5DRJR\SQLEXPRESS","QL_CuaHangXeGanMay");
          CRV_detail.Refresh();
        }

        private void CRV_orderdetail_Load(object sender, EventArgs e)
        {
           
        }
    }
}
