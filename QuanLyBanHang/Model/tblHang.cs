namespace QuanLyBanHang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblHang")]
    public partial class tblHang
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblHang()
        {
            tblChiTietHDBan = new HashSet<tblChiTietHDBan>();
        }

        [Key]
        [StringLength(50)]
        public string MaHang { get; set; }

        [Required]
        [StringLength(50)]
        public string TenHang { get; set; }

        [Required]
        [StringLength(50)]
        public string MaChatLieu { get; set; }

        public double SoLuong { get; set; }

        public double DonGiaNhap { get; set; }

        public double DonGiaBan { get; set; }

        [StringLength(200)]
        public string GhiChu { get; set; }

        public virtual tblChatLieu tblChatLieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblChiTietHDBan> tblChiTietHDBan { get; set; }
    }
}
