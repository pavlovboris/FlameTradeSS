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
    
    public partial class Surfaces
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Surfaces()
        {
            this.Items = new HashSet<Items>();
            this.DocumentTransactions = new HashSet<DocumentTransactions>();
        }
    
        public int ID { get; set; }
        public string SurfaceCode { get; set; }
        public string SurfaceName { get; set; }
        public string SurfaceDescription { get; set; }
        public int SurfaceTypeID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Items> Items { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTransactions> DocumentTransactions { get; set; }
        public virtual SurfaceTypes SurfaceTypes { get; set; }
    }
}
