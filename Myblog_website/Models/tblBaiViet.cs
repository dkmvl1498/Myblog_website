//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Myblog_website.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblBaiViet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBaiViet()
        {
            this.tblBV_comment = new HashSet<tblBV_comment>();
            this.tblTag_BaiViet = new HashSet<tblTag_BaiViet>();
            this.tblUser_Baiviet = new HashSet<tblUser_Baiviet>();
        }
    
        public int id_BaiViet { get; set; }
        public Nullable<int> id_theLoai { get; set; }
        public string titleBaiViet { get; set; }
        public string img_Title { get; set; }
        public Nullable<int> danhGia { get; set; }
        public Nullable<int> view_BaiViet { get; set; }
    
        public virtual tblTHeLoai tblTHeLoai { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblBV_comment> tblBV_comment { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblTag_BaiViet> tblTag_BaiViet { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblUser_Baiviet> tblUser_Baiviet { get; set; }
    }
}