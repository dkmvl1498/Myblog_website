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
    
    public partial class tblBV_comment
    {
        public int id_Cmt { get; set; }
        public Nullable<int> id_BaiViet { get; set; }
        public string text_cmt { get; set; }
        public Nullable<int> cmt_like { get; set; }
        public Nullable<int> cmt_dislike { get; set; }
        public Nullable<System.DateTime> time_cmt { get; set; }
    
        public virtual tblBaiViet tblBaiViet { get; set; }
    }
}
