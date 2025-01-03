using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Reporting.WinForms;

namespace QuanLyBanHang
{
    public partial class frmBCDoanhThu : Form
    {
        public frmBCDoanhThu()
        {
            InitializeComponent();
        }

        private void frmBCDoanhThu_Load(object sender, EventArgs e)
        {

            this.rpvBCMHBan.RefreshReport();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = Properties.Settings.Default.NewQLCHTLConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BCDoanhThu";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;
            cmd.Parameters.Add(new SqlParameter("@NgayBan", dtpNgayBC.Value.Date));
            //khia báo dataset để lấy dữ liệu
            DataSet ds = new DataSet();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(ds);
            //thiết lập báo cáo
            rpvBCMHBan.ProcessingMode = ProcessingMode.Local;
            rpvBCMHBan.LocalReport.ReportPath = "C:\\Users\\convi\\Downloads\\Phạm Hoàng Đoàn_Phạm Thị Hạnh_Đoàn Huy Hoàng\\Phạm Hoàng Đoàn_Phạm Thị Hạnh_Đoàn Huy Hoàng\\QLBH\\QuanLyBanHang\\Report\\Report1.rdlc";
            MessageBox.Show(ds.Tables[0].Rows.Count.ToString());

            ReportDataSource rds = new ReportDataSource();
            rds.Name = "dsMatHangBan";
            rds.Value = ds.Tables[0];
            //gắn lên mẫu báo cáo
            rpvBCMHBan.LocalReport.DataSources.Clear();
            rpvBCMHBan.LocalReport.DataSources.Add(rds);
            rpvBCMHBan.RefreshReport();
        }

        private void dtpNgayBC_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
