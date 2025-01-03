using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QuanLyBanHang.Class;
using QuanLyBanHang.Model;

namespace QuanLyBanHang
{
    public partial class frmBCGiaSP : Form
    {
        
        public frmBCGiaSP()
        {
            InitializeComponent();
        }

        private void frmBaoCaoDoanhThu_Load(object sender, EventArgs e)
        {
            QLBanHangContext context = new QLBanHangContext();
            List<tblHang> listHang = context.tblHang.ToList();
            List<BCSanPhamReport> listReport = new List<BCSanPhamReport>();
            foreach (tblHang i in listHang)
            {
                BCSanPhamReport temp = new BCSanPhamReport();
                temp.MaHang = i.MaHang;
                temp.TenHang = i.TenHang;
                temp.SoLuong = i.SoLuong;
                temp.DonGiaNhap = i.DonGiaNhap;
                listReport.Add(temp);
            }
            this.rpvBaoCaoDT.LocalReport.ReportPath = "./Report/rptSanPham.rdlc";
            var reportDataSource = new ReportDataSource("SanPhamDataset", listReport);
            this.rpvBaoCaoDT.LocalReport.DataSources.Clear(); //clear
            this.rpvBaoCaoDT.LocalReport.DataSources.Add(reportDataSource);
            this.rpvBaoCaoDT.RefreshReport();
        }
    }
}
