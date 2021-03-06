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
    
    public partial class foodstoreitem
    {
        public int ID { get; set; }
        public int FoodStoreID { get; set; }
        public int ItemID { get; set; }
        public Nullable<double> Amount { get; set; }
        public string Unit { get; set; }
        public Nullable<System.DateTime> BoughtTime { get; set; }
        public Nullable<bool> Basic { get; set; }
        public Nullable<System.DateTime> ExpireDay { get; set; }
        public Nullable<bool> UseLess { get; set; }
    
        public virtual foodinfo foodinfo { get; set; }
        public virtual foodstore foodstore { get; set; }
    }
}
