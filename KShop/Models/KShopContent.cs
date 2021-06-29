using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace KShop.Models
{
    public partial class KShopContent : DbContext
    {
        public KShopContent()
            : base("name=KShopContent")
        {
        }

        public virtual DbSet<CHITIETDONTHANG> CHITIETDONTHANG { get; set; }
        public virtual DbSet<DONDATHANG> DONDATHANG { get; set; }
        public virtual DbSet<SANPHAM> SANPHAM { get; set; }
        public virtual DbSet<THELOAI> THELOAI { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHITIETDONTHANG>()
                .Property(e => e.Dongia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.Giaban)
                .HasPrecision(18, 3);

            modelBuilder.Entity<SANPHAM>()
                .Property(e => e.Anhbia)
                .IsUnicode(false);
        }
    }
}
