using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace QLBanHang
{
    public partial class Form1 : Form
    {
        private List<SanPham> danhSachSanPham;

        public Form1()
        {
            InitializeComponent();
            danhSachSanPham = new List<SanPham>();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenSP = txtTenSanPham.Text;
            if (decimal.TryParse(txtGia.Text, out decimal gia) &&
                int.TryParse(txtSoLuongTon.Text, out int soLuongTon) &&
                !string.IsNullOrWhiteSpace(tenSP))
            {
                var sanPham = new SanPham { TenSanPham = tenSP, Gia = gia, SoLuongTon = soLuongTon };
                danhSachSanPham.Add(sanPham);
                CapNhatDanhSachSanPham();
                txtTenSanPham.Clear();
                txtGia.Clear();
                txtSoLuongTon.Clear();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập thông tin hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                int index = dgvSanPham.SelectedRows[0].Index;
                string tenSPMoi = txtTenSanPham.Text;
                if (decimal.TryParse(txtGia.Text, out decimal giaMoi) &&
                    int.TryParse(txtSoLuongTon.Text, out int soLuongTonMoi) &&
                    !string.IsNullOrWhiteSpace(tenSPMoi))
                {
                    danhSachSanPham[index].TenSanPham = tenSPMoi;
                    danhSachSanPham[index].Gia = giaMoi;
                    danhSachSanPham[index].SoLuongTon = soLuongTonMoi;
                    CapNhatDanhSachSanPham();
                    txtTenSanPham.Clear();
                    txtGia.Clear();
                    txtSoLuongTon.Clear();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập thông tin hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvSanPham.SelectedRows.Count > 0)
            {
                int index = dgvSanPham.SelectedRows[0].Index;
                danhSachSanPham.RemoveAt(index);
                CapNhatDanhSachSanPham();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string filePath = "danhSachSanPham.json";
            string json = JsonConvert.SerializeObject(danhSachSanPham, Formatting.Indented);
            File.WriteAllText(filePath, json);
            MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            string filePath = "danhSachSanPham.json";
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                danhSachSanPham = JsonConvert.DeserializeObject<List<SanPham>>(json) ?? new List<SanPham>();
                CapNhatDanhSachSanPham();
            }
            else
            {
                MessageBox.Show("Không tìm thấy file dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void CapNhatDanhSachSanPham()
        {
            dgvSanPham.Rows.Clear();
            foreach (var sp in danhSachSanPham)
            {
                dgvSanPham.Rows.Add(sp.TenSanPham, sp.Gia, sp.SoLuongTon);
            }
        }
    }

    public class SanPham
    {
        public string TenSanPham { get; set; }
        public decimal Gia { get; set; }
        public int SoLuongTon { get; set; }
    }
}
