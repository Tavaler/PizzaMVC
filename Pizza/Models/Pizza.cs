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
    
    public partial class Pizza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Pizza()
        {
            this.Purchase = new HashSet<Purchase>();
        }
    
        public int Pizza_ID { get; set; }
        public string Pizza_Name { get; set; }
        public Nullable<int> Pizza_Price { get; set; }
        public Nullable<int> Pizza_Number { get; set; }
        public byte[] Pizza_Pic { get; set; }
        public Nullable<int> Pizza_DistrictID { get; set; }
        public Nullable<int> Pizza_TypeID { get; set; }
    
        public virtual District District { get; set; }
        public virtual PizzaType PizzaType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Purchase> Purchase { get; set; }
    }
}