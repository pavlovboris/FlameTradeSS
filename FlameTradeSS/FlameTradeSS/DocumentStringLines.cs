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
    
    public partial class DocumentStringLines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DocumentStringLines()
        {
            this.AutoStringDocuments = new HashSet<AutoStringDocuments>();
        }
    
        public int ID { get; set; }
        public int DocumentStringID { get; set; }
        public int DocumentSequenceID { get; set; }
        public int SequencePosition { get; set; }
        public int AttachFinancialPlan { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoStringDocuments> AutoStringDocuments { get; set; }
        public virtual DocumentSequences DocumentSequences { get; set; }
        public virtual DocumentsStrings DocumentsStrings { get; set; }
    }
}
