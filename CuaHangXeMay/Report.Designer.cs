namespace CuaHangXeMay
{
    partial class Report
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
            this.CRV_detail = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CRV_detail
            // 
            this.CRV_detail.ActiveViewIndex = -1;
            this.CRV_detail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CRV_detail.Location = new System.Drawing.Point(0, 0);
            this.CRV_detail.Name = "CRV_detail";
            this.CRV_detail.Size = new System.Drawing.Size(827, 614);
            this.CRV_detail.TabIndex = 0;
            this.CRV_detail.Load += new System.EventHandler(this.CRV_orderdetail_Load);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 614);
            this.Controls.Add(this.CRV_detail);
            this.Name = "Report";
            this.Text = "ReportHoaDon";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_detail;

    }
}