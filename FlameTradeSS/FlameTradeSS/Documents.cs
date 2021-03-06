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
    
    public partial class Documents
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Documents()
        {
            this.DocumentsAttachments = new HashSet<DocumentsAttachments>();
            this.DocumentsProjects = new HashSet<DocumentsProjects>();
            this.DocumentTransactions = new HashSet<DocumentTransactions>();
            this.DocumentTransformation = new HashSet<DocumentTransformation>();
            this.DocumentTransformation1 = new HashSet<DocumentTransformation>();
            this.InvoiceNumbering = new HashSet<InvoiceNumbering>();
            this.DocumentsFinancialPlan = new HashSet<DocumentsFinancialPlan>();
            this.AutoStringDocuments = new HashSet<AutoStringDocuments>();
            this.TransactionNumbering = new HashSet<TransactionNumbering>();
            this.LogsEditRestrictedDocuments = new HashSet<LogsEditRestrictedDocuments>();
            this.AccountingEntries = new HashSet<AccountingEntries>();
        }
    
        public int ID { get; set; }
        public int DocumentSequenceID { get; set; }
        public Nullable<int> DocumentNumber { get; set; }
        public int PartnerID { get; set; }
        public int UserID { get; set; }
        public System.DateTime DocumentDate { get; set; }
        public Nullable<double> IncomeValue { get; set; }
        public Nullable<double> ExpenseValue { get; set; }
        public string Comment { get; set; }
        public int IsBlocked { get; set; }
        public Nullable<int> CostingModelID { get; set; }
        public Nullable<int> PricingModelID { get; set; }
        public int IsCanceled { get; set; }
        public int Issued { get; set; }
    
        public virtual DocumentSequences DocumentSequences { get; set; }
        public virtual Partners Partners { get; set; }
        public virtual Users Users { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsAttachments> DocumentsAttachments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsProjects> DocumentsProjects { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTransactions> DocumentTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTransformation> DocumentTransformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentTransformation> DocumentTransformation1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InvoiceNumbering> InvoiceNumbering { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DocumentsFinancialPlan> DocumentsFinancialPlan { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoStringDocuments> AutoStringDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionNumbering> TransactionNumbering { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LogsEditRestrictedDocuments> LogsEditRestrictedDocuments { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountingEntries> AccountingEntries { get; set; }
    }
}
