//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Quan_Ly_Tour_Du_Lich.Areas.Admin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class NHAN_VIEN
    {
        public string Ma_NV { get; set; }
        public string Ten_NV { get; set; }
        public System.DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string CCCD { get; set; }
        public string ChucVu { get; set; }
        public string Email { get; set; }
        public string GioiTinh { get; set; }
    
        public virtual ACCOUNT ACCOUNT { get; set; }
    }
}
