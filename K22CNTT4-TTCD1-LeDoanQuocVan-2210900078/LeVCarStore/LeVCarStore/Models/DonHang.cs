using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeVCarStore.Models
{
    public class DonHang
    {
        public int DonHangID { get; set; } 
        public int KhachHangID { get; set; } 
        public DateTime NgayDat { get; set; } = DateTime.Now; 
        public decimal TongTien { get; set; } 

       
        public virtual KhachHang KhachHang { get; set; }

       
        public virtual ICollection<ChiTietDonHang> ChiTietDonHangs { get; set; }
    }
}