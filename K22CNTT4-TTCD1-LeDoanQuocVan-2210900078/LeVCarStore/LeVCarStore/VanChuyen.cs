//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LeVCarStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class VanChuyen
    {
        public int VanChuyenID { get; set; }
        public int DonHangID { get; set; }
        public string TrangThai { get; set; }
        public Nullable<System.DateTime> NgayGuiHang { get; set; }
        public Nullable<System.DateTime> NgayNhanHang { get; set; }
        public string MaVanChuyen { get; set; }
        public string DiaChiGiaoHang { get; set; }
    
        public virtual DonHang DonHang { get; set; }
    }
}
