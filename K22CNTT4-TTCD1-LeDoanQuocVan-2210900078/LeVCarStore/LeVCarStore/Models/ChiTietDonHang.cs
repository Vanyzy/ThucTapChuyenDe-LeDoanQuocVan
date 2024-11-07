using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeVCarStore.Models
{
    public class ChiTietDonHang
    {
        public int ChiTietDonHangID { get; set; } 
        public int DonHangID { get; set; } 
        public int SanPhamID { get; set; } 
        public int SoLuong { get; set; } 
        public decimal Gia { get; set; } 

        
        public virtual DonHang DonHang { get; set; }

        
        public virtual SanPham SanPham { get; set; }
    }
}