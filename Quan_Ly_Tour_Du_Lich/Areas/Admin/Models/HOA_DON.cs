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
    
    public partial class HOA_DON
    {
        public int Ma_HD { get; set; }
        public Nullable<int> NguoiLon { get; set; }
        public Nullable<int> TreEm { get; set; }
        public Nullable<int> EmBe { get; set; }
        public Nullable<int> Gia { get; set; }
        public Nullable<System.DateTime> NgayTT { get; set; }
        public string PTTT { get; set; }
        public string LuuY { get; set; }
        public Nullable<int> Ma_Booking { get; set; }
    
        public virtual BOOKING BOOKING { get; set; }
    }
}
