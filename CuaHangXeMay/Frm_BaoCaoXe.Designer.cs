namespace CuaHangXeMay
{
    partial class Frm_BaoCaoXe
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
            this.CTRPV_Xe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CTRPV_Xe
            // 
            this.CTRPV_Xe.ActiveViewIndex = -1;
            this.CTRPV_Xe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CTRPV_Xe.Cursor = System.Windows.Forms.Cursors.Default;
            this.CTRPV_Xe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CTRPV_Xe.Location = new System.Drawing.Point(0, 0);
            this.CTRPV_Xe.Name = "CTRPV_Xe";
            this.CTRPV_Xe.Size = new System.Drawing.Size(1041, 623);
            this.CTRPV_Xe.TabIndex = 0;
            this.CTRPV_Xe.Load += new System.EventHandler(this.CTRPV_Xe_Load);
            // 
            // Frm_BaoCaoXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 623);
            this.Controls.Add(this.CTRPV_Xe);
            this.Name = "Frm_BaoCaoXe";
            this.Text = "Frm_BaoCaoXe";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CTRPV_Xe;
    }
}