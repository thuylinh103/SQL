using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyBanHang
{
    public partial class frmTKNV : Form
    {
        private DataTable tblTKNV;
        public frmTKNV()
        {
            InitializeComponent();
        }

        private void frmTKNV_Load(object sender, EventArgs e)
        {
            txtTaiKhoan.Enabled = false;
            btnLuu.Enabled = false;
            btnBoQua.Enabled = false;
            LoadDataGridView();
        }
        private void LoadDataGridView()
        {
            string sql;
            sql = "SELECT TenDangNhap, MatKhau FROM tblQltkNhanVien";
            tblTKNV = Class.Functions.GetDataToTable(sql); //Đọc dữ liệu từ bảng
            dgvQLTaiKhoanNV.DataSource = tblTKNV; //Nguồn dữ liệu            
            dgvQLTaiKhoanNV.Columns[0].HeaderText = "Tên tài khoản";
            dgvQLTaiKhoanNV.Columns[1].HeaderText = "Mật khẩu";
            dgvQLTaiKhoanNV.Columns[0].Width = 100;
            dgvQLTaiKhoanNV.Columns[1].Width = 300;
            dgvQLTaiKhoanNV.AllowUserToAddRows = false; //Không cho người dùng thêm dữ liệu trực tiếp
            dgvQLTaiKhoanNV.EditMode = DataGridViewEditMode.EditProgrammatically; //Không cho sửa dữ liệu trực tiếp
        }

        private void dgvQLTaiKhoanNV_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }
            if (tblTKNV.Rows.Count == 0) //Nếu không có dữ liệu
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtTaiKhoan.Text = dgvQLTaiKhoanNV.CurrentRow.Cells["TenDangNhap"].Value.ToString();
            txtMatKhau.Text = dgvQLTaiKhoanNV.CurrentRow.Cells["MatKhau"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoQua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoQua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValue(); //Xoá trắng các textbox
            txtMatKhau.Enabled = true; //cho phép nhập mới
            txtTaiKhoan.Enabled = true;
        }
        private void ResetValue()
        {
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql; //Lưu lệnh sql
            if (txtTaiKhoan.Text.Trim().Length == 0) //Nếu chưa nhập mã chất liệu
            {
                MessageBox.Show("Bạn phải nhập Tên tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTaiKhoan.Focus();
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0) //Nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn phải nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatKhau.Focus();
                return;
            }
            sql = "Select TenDangNhap From tblQltkNhanVien where TenDangNhap=N'" + txtTaiKhoan.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Tên tài khoản bị trùng, bạn phải nhập tài khoản khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaiKhoan.Focus();
                return;
            }

            sql = "INSERT INTO tblQltkNhanVien VALUES(N'" +
                txtTaiKhoan.Text + "',N'" + txtMatKhau.Text + "')";
            Class.Functions.RunSQL(sql); //Thực hiện câu lệnh sql
            LoadDataGridView(); //Nạp lại DataGridView
            ResetValue();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoQua.Enabled = false;
            btnLuu.Enabled = false;
            txtTaiKhoan.Enabled = false;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql; //Lưu câu lệnh sql
            if (tblTKNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTaiKhoan.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatKhau.Text.Trim().Length == 0) //nếu chưa nhập tên chất liệu
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu mới", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            sql = "UPDATE tblQltkNhanVien SET MatKhau=N'" +
                txtMatKhau.Text.ToString() +
                "' WHERE TenDangNhap=N'" + txtTaiKhoan.Text + "'";
            Class.Functions.RunSQL(sql);
            LoadDataGridView();
            ResetValue();
            btnBoQua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblTKNV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTaiKhoan.Text == "") //nếu chưa chọn bản ghi nào
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xoá không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                sql = "DELETE tblQltkNhanVien WHERE TenDangNhap=N'" + txtTaiKhoan.Text + "'";
                Class.Functions.RunSQL(sql);
                LoadDataGridView();
                ResetValue();
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            ResetValue();
            btnBoQua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtTaiKhoan.Enabled = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
