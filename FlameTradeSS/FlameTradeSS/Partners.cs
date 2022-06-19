//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlameTradeSS
{
    using System;
    using System.Collections.Generic;
    
    public partial class Partners
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Partners()
        {
            this.Customers = new HashSet<Customers>();
            this.Documents = new HashSet<Documents>();
            this.PartnerPersons = new HashSet<PartnerPersons>();
            this.Suppliers = new HashSet<Suppliers>();
        }
    
        public int ID { get; set; }
        public string Partner_name { get; set; }
        public string VAT { get; set; }
        public string Email { get; set; }
        public string MRP { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public Nullable<int> GroupID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<int> StaticPriceGroupID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Customers> Customers { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Documents> Documents { get; set; }
        public virtual PartnerCategory PartnerCategory { get; set; }
        public virtual PartnerGroups PartnerGroups { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PartnerPersons> PartnerPersons { get; set; }
        public virtual PartnerStaticPriceGroup PartnerStaticPriceGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Suppliers> Suppliers { get; set; }
    }
}
