using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace QuanLyBanHang.Model
{
    public partial class QLBanHangContext : DbContext
    {
        public QLBanHangContext()
            : base("name=QLBanHangContext")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblChatLieu> tblChatLieu { get; set; }
        public virtual DbSet<tblChiTietHDBan> tblChiTietHDBan { get; set; }
        public virtual DbSet<tblHang> tblHang { get; set; }
        public virtual DbSet<tblHDBan> tblHDBan { get; set; }
        public virtual DbSet<tblKhach> tblKhach { get; set; }
        public virtual DbSet<tblNhanVien> tblNhanVien { get; set; }
        public virtual DbSet<tblTaiKhoan> tblTaiKhoan { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblChatLieu>()
                .HasMany(e => e.tblHang)
                .WithRequired(e => e.tblChatLieu)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblHang>()
                .HasMany(e => e.tblChiTietHDBan)
                .WithRequired(e => e.tblHang)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblKhach>()
                .HasMany(e => e.tblHDBan)
                .WithRequired(e => e.tblKhach)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<tblNhanVien>()
                .HasMany(e => e.tblHDBan)
                .WithRequired(e => e.tblNhanVien)
                .WillCascadeOnDelete(false);
        }
    }
}
