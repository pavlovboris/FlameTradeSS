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
    
    public partial class TransactionsTransformations
    {
        public int ID { get; set; }
        public int TransactionID { get; set; }
        public int OriginTransactionID { get; set; }
    
        public virtual DocumentTransactions DocumentTransactions { get; set; }
        public virtual DocumentTransactions DocumentTransactions1 { get; set; }
    }
}