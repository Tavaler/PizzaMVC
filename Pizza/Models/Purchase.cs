//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Pizza.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Purchase
    {
        public int Purchase_ID { get; set; }
        public Nullable<int> Purchase_UserID { get; set; }
        public Nullable<int> Purchase_DistrictID { get; set; }
        public Nullable<int> Purchase_PizzaID { get; set; }
        public Nullable<int> Purchase_OrderID { get; set; }
        public Nullable<int> Purchase_Number { get; set; }
        public Nullable<int> Purchase_Price { get; set; }
        public string Purchase_Date { get; set; }
        public Nullable<int> Purchase_No { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Pizza Pizza { get; set; }
    }
}