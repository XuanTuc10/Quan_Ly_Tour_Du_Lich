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
    
    public partial class KHUYEN_MAI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KHUYEN_MAI()
        {
            this.TOUR = new HashSet<TOUR>();
        }
    
        public string Ma_KM { get; set; }
        public System.DateTime Ngay_KM { get; set; }
        public System.DateTime Ngay_KTKM { get; set; }
        public string KhuyenMai { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TOUR> TOUR { get; set; }
    }
}