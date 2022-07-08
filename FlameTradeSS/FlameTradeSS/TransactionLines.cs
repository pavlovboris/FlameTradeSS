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
    
    public partial class TransactionLines
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionLines()
        {
            this.Inventory = new HashSet<Inventory>();
            this.MachinesInventory = new HashSet<MachinesInventory>();
            this.TransactionLinesTransformation = new HashSet<TransactionLinesTransformation>();
            this.TransactionLinesTransformation1 = new HashSet<TransactionLinesTransformation>();
            this.TransactionLinesComments = new HashSet<TransactionLinesComments>();
            this.TransactionRowsDependancy = new HashSet<TransactionRowsDependancy>();
            this.TransactionRowsDependancy1 = new HashSet<TransactionRowsDependancy>();
        }
    
        public int ID { get; set; }
        public int TransactionsID { get; set; }
        public Nullable<int> ItemID { get; set; }
        public Nullable<int> MachineID { get; set; }
        public Nullable<int> ServiceID { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<double> DurationHours { get; set; }
        public Nullable<int> Cycles { get; set; }
        public Nullable<int> Ordering { get; set; }
        public Nullable<int> ReceiptID { get; set; }
        public Nullable<int> MuID { get; set; }
        public Nullable<int> PartitionID { get; set; }
        public Nullable<int> SecondPartitionID { get; set; }
        public Nullable<double> Qty { get; set; }
        public Nullable<double> AdditionExpense { get; set; }
        public Nullable<double> SalePrice1 { get; set; }
        public Nullable<double> SalePrice2 { get; set; }
        public Nullable<double> SalePrice3 { get; set; }
        public Nullable<double> RemainingQTY { get; set; }
        public Nullable<double> RemainingInvoiceQTY { get; set; }
        public Nullable<double> RemainingProductionQTY { get; set; }
        public Nullable<double> RemainingPackagingQTY { get; set; }
        public Nullable<double> RemainingDeliveryQTY { get; set; }
        public Nullable<System.DateTime> ExpectedMatDate { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public Nullable<double> CostPrice1 { get; set; }
        public Nullable<double> CostPrice2 { get; set; }
        public Nullable<double> CostPrice3 { get; set; }
        public int IsCanceled { get; set; }
        public Nullable<int> SurfaceID { get; set; }
        public string Comment { get; set; }
        public Nullable<int> FinancialCategoryID { get; set; }
        public Nullable<int> OriginLine { get; set; }
        public int WH { get; set; }
    
        public virtual DocumentTransactions DocumentTransactions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventory> Inventory { get; set; }
        public virtual Items Items { get; set; }
        public virtual Machines Machines { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachinesInventory> MachinesInventory { get; set; }
        public virtual Mu Mu { get; set; }
        public virtual Partitions Partitions { get; set; }
        public virtual Partitions Partitions1 { get; set; }
        public virtual Services Services { get; set; }
        public virtual TransactionReceipt TransactionReceipt { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionLinesTransformation> TransactionLinesTransformation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionLinesTransformation> TransactionLinesTransformation1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionLinesComments> TransactionLinesComments { get; set; }
        public virtual FinancialCategories FinancialCategories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionRowsDependancy> TransactionRowsDependancy { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransactionRowsDependancy> TransactionRowsDependancy1 { get; set; }
    }
}
