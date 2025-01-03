
namespace QuanLyBanHang
{
    partial class frmBCGiaSP
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.BCSanPhamReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.CTHDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rpvBaoCaoDT = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblChiTietHDBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.BCSanPhamReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDonBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBanBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BCSanPhamReportBindingSource
            // 
            this.BCSanPhamReportBindingSource.DataSource = typeof(QuanLyBanHang.Class.BCSanPhamReport);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(854, 403);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rpvBaoCaoDT);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 403);
            this.panel1.TabIndex = 4;
            // 
            // rpvBaoCaoDT
            // 
            this.rpvBaoCaoDT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rpvBaoCaoDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            reportDataSource1.Name = "SanPhamDataset";
            reportDataSource1.Value = this.BCSanPhamReportBindingSource;
            this.rpvBaoCaoDT.LocalReport.DataSources.Add(reportDataSource1);
            this.rpvBaoCaoDT.LocalReport.ReportEmbeddedResource = "QuanLyBanHang.Report.rptSanPham.rdlc";
            this.rpvBaoCaoDT.Location = new System.Drawing.Point(0, 0);
            this.rpvBaoCaoDT.Name = "rpvBaoCaoDT";
            this.rpvBaoCaoDT.ServerReport.BearerToken = null;
            this.rpvBaoCaoDT.Size = new System.Drawing.Size(854, 403);
            this.rpvBaoCaoDT.TabIndex = 3;
            this.rpvBaoCaoDT.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // tblChiTietHDBanBindingSource
            // 
            this.tblChiTietHDBanBindingSource.DataSource = typeof(QuanLyBanHang.Model.tblChiTietHDBan);
            // 
            // frmBCGiaSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 403);
            this.Controls.Add(this.panel2);
            this.Name = "frmBCGiaSP";
            this.Text = "BẢNG BÁO GIÁ SẢN PHẨM";
            this.Load += new System.EventHandler(this.frmBaoCaoDoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BCSanPhamReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CTHDonBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblChiTietHDBanBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource tblChiTietHDBanBindingSource;
        private System.Windows.Forms.BindingSource CTHDonBindingSource;
        private System.Windows.Forms.Panel panel2;
        private Microsoft.Reporting.WinForms.ReportViewer rpvBaoCaoDT;
        private System.Windows.Forms.BindingSource BCSanPhamReportBindingSource;
        private System.Windows.Forms.Panel panel1;
    }
}