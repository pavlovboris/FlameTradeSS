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
    
    public partial class RoleOfPersons
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RoleOfPersons()
        {
            this.PersonsRolesOfPersons = new HashSet<PersonsRolesOfPersons>();
        }
    
        public int ID { get; set; }
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PersonsRolesOfPersons> PersonsRolesOfPersons { get; set; }
    }
}
