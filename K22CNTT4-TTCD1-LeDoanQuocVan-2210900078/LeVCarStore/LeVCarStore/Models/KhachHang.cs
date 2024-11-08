﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeVCarStore.Models
{
    public class KhachHang
    {
        public int KhachHangID { get; set; } 
        public string HoTen { get; set; } 
        public string Email { get; set; } 
        public string MatKhau { get; set; } 
        public string SoDienThoai { get; set; } 
        public string DiaChi { get; set; } 
        public DateTime NgayDangKy { get; set; } = DateTime.Now; 

       
        public virtual ICollection<DonHang> DonHangs { get; set; }
    }
}