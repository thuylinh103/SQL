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
    public partial class frmDangNhap : Form
    {
        
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public string tenDanNhap = "";
        public string loaiTK;
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbnDangNhap_Click(object sender, EventArgs e)
        {
            if(cmbLoaiTK.SelectedIndex <0)
            {
                MessageBox.Show("Vui lòng chọn loại tài khoản");
                return;
            }
            if (string.IsNullOrEmpty(txtTenDN.Text))
            {
                MessageBox.Show("Vui lòng nhập tài khoản");
                txtTenDN.Select();
                return;
            }
            if (string.IsNullOrEmpty(txtMatKhau.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
            }

            tenDanNhap = txtTenDN.Text;
            loaiTK = "";

            
            switch (cmbLoaiTK.Text)
            {
                case "Quản lý":
                    loaiTK = "QL";
                        break;
                case "Nhân viên":
                    loaiTK = "NV";
                        break;
            }

            List<CustomParameter> lst = new List<CustomParameter>()
            {
                new CustomParameter()
                {
                    key = "@Loai",
                    value = loaiTK
                },
                new CustomParameter() {
                     key = "@TenDangNhap",
                     value = txtTenDN.Text
                 },
                 new CustomParameter() {
                     key = "@MatKhau",
                     value = txtMatKhau.Text
                 },
            };
            var rs = new Database().SelectData("dangNhap", lst); //lấy dữ liệu
            if (rs.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công");
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản hặc mật khẩu không đúng");
            }
            
        }

        private void F_logOut(object sender, EventArgs e)
        {
            (sender as frmMain).isThoat = false;
            (sender as frmMain).Close();
            this.Show();
        }

        private void frmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void picDong_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                picMo.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void picMo_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                picDong.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void frmDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendKeys.Send("{TAB}");
        }
    }
}
