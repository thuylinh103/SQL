using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyBanHang.Class;

namespace QuanLyBanHang
{
    public partial class frmMain : Form
    {
        public bool isThoat = true;
        public string taikhoan;
        public string loaitk;
        public frmMain()
        {
            InitializeComponent();
        }
        
        private void frmMain_Load(object sender, EventArgs e)
        {
            var fn = new frmDangNhap();
            fn.ShowDialog();
            taikhoan = fn.tenDanNhap;
            loaitk = fn.loaiTK;
            mnuDangNhap.Enabled = false;
            if (string.Equals(loaitk,"NV"))
            {
                mnuHangHoa.Enabled = mnuNhanVien.Enabled = mnuNCC.Enabled = mnuTaiKhoan.Enabled = mnuBaoCao.Enabled = false;
            }
            Functions.Connect();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Functions.Disconnect();
            Application.Exit();
        }

        private void mnuChatLieu_Click(object sender, EventArgs e)
        {
            frmNhaCungCap frm = new frmNhaCungCap();
            frm.ShowDialog();
        }

        private void mnuHangHoa_Click(object sender, EventArgs e)
        {
            frmDMHangHoa frm = new frmDMHangHoa();
            frm.ShowDialog();
        }

        private void mnuNhanVien_Click(object sender, EventArgs e)
        {
            frmDMNhanVien frm = new frmDMNhanVien();
            frm.ShowDialog();
        }

        private void mnuKhachHang_Click(object sender, EventArgs e)
        {
            frmDMKhachHang frm = new frmDMKhachHang();
            frm.ShowDialog();
        }

        private void mnuHoaDonBan_Click(object sender, EventArgs e)
        {
            frmHoaDonBan frm = new frmHoaDonBan();
            frm.ShowDialog();
        }
        
        private void mnuDoanhThu_Click(object sender, EventArgs e)
        {
            frmBCDoanhThu frm = new frmBCDoanhThu();
            frm.ShowDialog();
        }

        private void quảnLýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaiKhoan frm = new frmTaiKhoan();
            frm.ShowDialog();
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTKNV frm = new frmTKNV();
            frm.ShowDialog();
        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            isThoat = false;
            this.Close();
            frmDangNhap frm = new frmDangNhap();
            frm.Show();
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }
        }

        private void mnuTop_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    if (isThoat)
        //    {
        //        Application.Exit();
        //    }
        //}

        //private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (isThoat)
        //    {
        //        if (MessageBox.Show("Bạn có muốn thoát chương trình", "Hệ thống cảnh báo", MessageBoxButtons.YesNo) != DialogResult.Yes)
        //            e.Cancel = true;
        //    }
        //}
    }
}
