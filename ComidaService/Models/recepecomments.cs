//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ComidaService.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class recepecomments
    {
        public int ID { get; set; }
        public int RecepeID { get; set; }
        public int UserID { get; set; }
        public string Comment { get; set; }
        public Nullable<System.DateTime> Date { get; set; }
    
        public virtual recepe recepe { get; set; }
        public virtual user user { get; set; }
    }
}
