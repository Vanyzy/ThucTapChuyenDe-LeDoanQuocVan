using LeVCarStore.Models;
using System.Data.Entity;

public class LeVCarStoreContext : DbContext
{
    public LeVCarStoreContext() : base("LeVCarStoreContext") { }

    public DbSet<SanPham> SanPhams { get; set; }
    public DbSet<DanhMuc> DanhMucs { get; set; }
    public DbSet<KhachHang> KhachHangs { get; set; }
    public DbSet<DonHang> DonHangs { get; set; }
    public DbSet<ChiTietDonHang> ChiTietDonHangs { get; set; }
}
