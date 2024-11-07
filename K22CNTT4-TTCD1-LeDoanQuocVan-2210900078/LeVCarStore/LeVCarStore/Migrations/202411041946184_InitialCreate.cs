namespace LeVCarStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChiTietDonHangs",
                c => new
                    {
                        ChiTietDonHangID = c.Int(nullable: false, identity: true),
                        DonHangID = c.Int(nullable: false),
                        SanPhamID = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        Gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ChiTietDonHangID)
                .ForeignKey("dbo.DonHangs", t => t.DonHangID, cascadeDelete: true)
                .ForeignKey("dbo.SanPhams", t => t.SanPhamID, cascadeDelete: true)
                .Index(t => t.DonHangID)
                .Index(t => t.SanPhamID);
            
            CreateTable(
                "dbo.DonHangs",
                c => new
                    {
                        DonHangID = c.Int(nullable: false, identity: true),
                        KhachHangID = c.Int(nullable: false),
                        NgayDat = c.DateTime(nullable: false),
                        TongTien = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.DonHangID)
                .ForeignKey("dbo.KhachHangs", t => t.KhachHangID, cascadeDelete: true)
                .Index(t => t.KhachHangID);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        KhachHangID = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        Email = c.String(),
                        MatKhau = c.String(),
                        SoDienThoai = c.String(),
                        DiaChi = c.String(),
                        NgayDangKy = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.KhachHangID);
            
            CreateTable(
                "dbo.SanPhams",
                c => new
                    {
                        SanPhamID = c.Int(nullable: false, identity: true),
                        TenSanPham = c.String(),
                        MoTa = c.String(),
                        Gia = c.Decimal(nullable: false, precision: 18, scale: 2),
                        HinhAnh = c.String(),
                        SoLuongTon = c.Int(nullable: false),
                        DanhMucID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SanPhamID)
                .ForeignKey("dbo.DanhMucs", t => t.DanhMucID, cascadeDelete: true)
                .Index(t => t.DanhMucID);
            
            CreateTable(
                "dbo.DanhMucs",
                c => new
                    {
                        DanhMucID = c.Int(nullable: false, identity: true),
                        TenDanhMuc = c.String(),
                    })
                .PrimaryKey(t => t.DanhMucID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ChiTietDonHangs", "SanPhamID", "dbo.SanPhams");
            DropForeignKey("dbo.SanPhams", "DanhMucID", "dbo.DanhMucs");
            DropForeignKey("dbo.DonHangs", "KhachHangID", "dbo.KhachHangs");
            DropForeignKey("dbo.ChiTietDonHangs", "DonHangID", "dbo.DonHangs");
            DropIndex("dbo.SanPhams", new[] { "DanhMucID" });
            DropIndex("dbo.DonHangs", new[] { "KhachHangID" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "SanPhamID" });
            DropIndex("dbo.ChiTietDonHangs", new[] { "DonHangID" });
            DropTable("dbo.DanhMucs");
            DropTable("dbo.SanPhams");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.DonHangs");
            DropTable("dbo.ChiTietDonHangs");
        }
    }
}
