using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeVCarStore.Models
{
    public class SanPham
    {
        public int SanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public string MoTa { get; set; }
        public decimal Gia { get; set; }
        public string HinhAnh { get; set; }
        public int SoLuongTon { get; set; }
        public int DanhMucID { get; set; }

        public virtual DanhMuc DanhMuc { get; set; }
    }
}