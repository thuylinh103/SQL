namespace QuanLyBanHang.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblChatLieu")]
    public partial class tblChatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblChatLieu()
        {
            tblHang = new HashSet<tblHang>();
        }

        [Key]
        [StringLength(50)]
        public string MaChatLieu { get; set; }

        [StringLength(50)]
        public string TenChatLieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblHang> tblHang { get; set; }
    }
}
