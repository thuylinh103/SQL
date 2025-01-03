namespace QuanLyBanHang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHDBan")]
    public partial class tblHDBan
    {
        [Key]
        [StringLength(50)]
        public string MaHDBan { get; set; }

        [Required]
        [StringLength(50)]
        public string MaNhanVien { get; set; }

        public DateTime NgayBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaKhach { get; set; }

        public double TongTien { get; set; }

        public virtual tblKhach tblKhach { get; set; }

        public virtual tblNhanVien tblNhanVien { get; set; }
    }
}
