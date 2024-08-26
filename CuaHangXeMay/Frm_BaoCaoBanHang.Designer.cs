namespace CuaHangXeMay
{
    partial class Frm_BaoCaoBanHang
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
            this.dt_fromdar = new System.Windows.Forms.DateTimePicker();
            this.dt_todate = new System.Windows.Forms.DateTimePicker();
            this.btn_Show = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CRV_TKHD = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // dt_fromdar
            // 
            this.dt_fromdar.Location = new System.Drawing.Point(25, 50);
            this.dt_fromdar.Name = "dt_fromdar";
            this.dt_fromdar.Size = new System.Drawing.Size(320, 26);
            this.dt_fromdar.TabIndex = 0;
            // 
            // dt_todate
            // 
            this.dt_todate.Location = new System.Drawing.Point(548, 50);
            this.dt_todate.Name = "dt_todate";
            this.dt_todate.Size = new System.Drawing.Size(338, 26);
            this.dt_todate.TabIndex = 1;
            // 
            // btn_Show
            // 
            this.btn_Show.Location = new System.Drawing.Point(762, 99);
            this.btn_Show.Name = "btn_Show";
            this.btn_Show.Size = new System.Drawing.Size(124, 50);
            this.btn_Show.TabIndex = 2;
            this.btn_Show.Text = "show";
            this.btn_Show.UseVisualStyleBackColor = true;
            this.btn_Show.Click += new System.EventHandler(this.btn_Show_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ Ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(544, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến Ngày";
            // 
            // CRV_TKHD
            // 
            this.CRV_TKHD.ActiveViewIndex = -1;
            this.CRV_TKHD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CRV_TKHD.Cursor = System.Windows.Forms.Cursors.Default;
            this.CRV_TKHD.Location = new System.Drawing.Point(2, 155);
            this.CRV_TKHD.Name = "CRV_TKHD";
            this.CRV_TKHD.Size = new System.Drawing.Size(959, 538);
            this.CRV_TKHD.TabIndex = 5;
            // 
            // Frm_BaoCaoBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 705);
            this.Controls.Add(this.CRV_TKHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Show);
            this.Controls.Add(this.dt_todate);
            this.Controls.Add(this.dt_fromdar);
            this.Name = "Frm_BaoCaoBanHang";
            this.Text = "Frm_BaoCaoBanHang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dt_fromdar;
        private System.Windows.Forms.DateTimePicker dt_todate;
        private System.Windows.Forms.Button btn_Show;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer CRV_TKHD;
    }
}