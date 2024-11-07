using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LeVCarStore.Models
{
    public class DanhMuc
    {
        public int DanhMucID { get; set; } 
        public string TenDanhMuc { get; set; } 

       
        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}