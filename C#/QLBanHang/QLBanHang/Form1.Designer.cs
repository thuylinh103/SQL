namespace QLBanHang
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.txtSoLuongTon = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnDoc = new System.Windows.Forms.Button();
            this.lblTenSanPham = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.colTenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoLuongTon = new System.Windows.Forms.DataGridViewTextBoxColumn();

            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvSanPham
            // 
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colTenSanPham,
                this.colGia,
                this.colSoLuongTon
            });
            this.dgvSanPham.Location = new System.Drawing.Point(12, 150);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSanPham.Size = new System.Drawing.Size(500, 200);

            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(120, 20);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(200, 20);

            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(120, 50);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(200, 20);

            // 
            // txtSoLuongTon
            // 
            this.txtSoLuongTon.Location = new System.Drawing.Point(120, 80);
            this.txtSoLuongTon.Name = "txtSoLuongTon";
            this.txtSoLuongTon.Size = new System.Drawing.Size(200, 20);

            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(350, 20);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);

            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(350, 50);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);

            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(350, 80);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);

            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(450, 20);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);

            // 
            // btnDoc
            // 
            this.btnDoc.Location = new System.Drawing.Point(450, 50);
            this.btnDoc.Name = "btnDoc";
            this.btnDoc.Size = new System.Drawing.Size(75, 23);
            this.btnDoc.Text = "Đọc";
            this.btnDoc.Click += new System.EventHandler(this.btnDoc_Click);

            // 
            // lblTenSanPham
            // 
            this.lblTenSanPham.Location = new System.Drawing.Point(12, 20);
            this.lblTenSanPham.Name = "lblTenSanPham";
            this.lblTenSanPham.Size = new System.Drawing.Size(100, 20);
            this.lblTenSanPham.Text = "Tên sản phẩm";

            // 
            // lblGia
            // 
            this.lblGia.Location = new System.Drawing.Point(12, 50);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(100, 20);
            this.lblGia.Text = "Giá";

            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.Location = new System.Drawing.Point(12, 80);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(100, 20);
            this.lblSoLuongTon.Text = "Số lượng tồn";

            // 
            // colTenSanPham
            // 
            this.colTenSanPham.HeaderText = "Tên sản phẩm";
            this.colTenSanPham.Name = "colTenSanPham";

            // 
            // colGia
            // 
            this.colGia.HeaderText = "Giá";
            this.colGia.Name = "colGia";

            // 
            // colSoLuongTon
            // 
            this.colSoLuongTon.HeaderText = "Số lượng tồn";
            this.colSoLuongTon.Name = "colSoLuongTon";

            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.dgvSanPham);
            this.Controls.Add(this.txtTenSanPham);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.txtSoLuongTon);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnDoc);
            this.Controls.Add(this.lblTenSanPham);
            this.Controls.Add(this.lblGia);
            this.Controls.Add(this.lblSoLuongTon);
            this.Name = "Form1";
            this.Text = "Quản Lý Bán Hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.TextBox txtSoLuongTon;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnDoc;
        private System.Windows.Forms.Label lblTenSanPham;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoLuongTon;
    }
}
