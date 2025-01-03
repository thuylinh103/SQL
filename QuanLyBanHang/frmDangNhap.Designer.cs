
namespace QuanLyBanHang
{
    partial class frmDangNhap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTenDN = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.tbnDangNhap = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbLoaiTK = new System.Windows.Forms.ComboBox();
            this.picMo = new System.Windows.Forms.PictureBox();
            this.picDong = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDong)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(221, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(221, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mật khẩu";
            // 
            // txtTenDN
            // 
            this.txtTenDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtTenDN.Location = new System.Drawing.Point(411, 113);
            this.txtTenDN.Name = "txtTenDN";
            this.txtTenDN.Size = new System.Drawing.Size(234, 30);
            this.txtTenDN.TabIndex = 1;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtMatKhau.Location = new System.Drawing.Point(411, 188);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(234, 30);
            this.txtMatKhau.TabIndex = 2;
            // 
            // tbnDangNhap
            // 
            this.tbnDangNhap.BackColor = System.Drawing.Color.Transparent;
            this.tbnDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbnDangNhap.Location = new System.Drawing.Point(215, 279);
            this.tbnDangNhap.Name = "tbnDangNhap";
            this.tbnDangNhap.Size = new System.Drawing.Size(140, 49);
            this.tbnDangNhap.TabIndex = 4;
            this.tbnDangNhap.Text = "Đăng nhập";
            this.tbnDangNhap.UseVisualStyleBackColor = false;
            this.tbnDangNhap.Click += new System.EventHandler(this.tbnDangNhap_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Transparent;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnThoat.Location = new System.Drawing.Point(473, 279);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(119, 49);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::QuanLyBanHang.Properties.Resources._1;
            this.pictureBox1.Location = new System.Drawing.Point(30, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(230, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chọn loại ";
            // 
            // cmbLoaiTK
            // 
            this.cmbLoaiTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cmbLoaiTK.FormattingEnabled = true;
            this.cmbLoaiTK.Items.AddRange(new object[] {
            "Quản lý",
            "Nhân viên"});
            this.cmbLoaiTK.Location = new System.Drawing.Point(411, 45);
            this.cmbLoaiTK.Name = "cmbLoaiTK";
            this.cmbLoaiTK.Size = new System.Drawing.Size(234, 28);
            this.cmbLoaiTK.TabIndex = 0;
            // 
            // picMo
            // 
            this.picMo.BackColor = System.Drawing.Color.Transparent;
            this.picMo.Image = global::QuanLyBanHang.Properties.Resources.matdong;
            this.picMo.Location = new System.Drawing.Point(669, 188);
            this.picMo.Name = "picMo";
            this.picMo.Size = new System.Drawing.Size(34, 32);
            this.picMo.TabIndex = 6;
            this.picMo.TabStop = false;
            this.picMo.Click += new System.EventHandler(this.picMo_Click);
            // 
            // picDong
            // 
            this.picDong.BackColor = System.Drawing.Color.Transparent;
            this.picDong.Image = global::QuanLyBanHang.Properties.Resources.mat;
            this.picDong.Location = new System.Drawing.Point(669, 188);
            this.picDong.Name = "picDong";
            this.picDong.Size = new System.Drawing.Size(35, 32);
            this.picDong.TabIndex = 6;
            this.picDong.TabStop = false;
            this.picDong.Click += new System.EventHandler(this.picDong_Click);
            // 
            // frmDangNhap
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.hinh_nen_xam_khoi_anh_nen_xam_khoi_dep_nhat_020243071;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(713, 369);
            this.Controls.Add(this.picDong);
            this.Controls.Add(this.picMo);
            this.Controls.Add(this.cmbLoaiTK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.tbnDangNhap);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtTenDN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.DoubleBuffered = true;
            this.Name = "frmDangNhap";
            this.Text = "Đăng nhập tài khoản";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDangNhap_FormClosed);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmDangNhap_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenDN;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Button tbnDangNhap;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLoaiTK;
        private System.Windows.Forms.PictureBox picMo;
        private System.Windows.Forms.PictureBox picDong;
    }
}