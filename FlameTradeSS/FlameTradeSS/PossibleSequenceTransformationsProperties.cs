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
    
    public partial class PossibleSequenceTransformationsProperties
    {
        public int ID { get; set; }
        public int PossibleSqequenceTransformationID { get; set; }
        public int UseReceipt { get; set; }
        public int RemainQTYAction { get; set; }
        public int RemainProductionQTYAction { get; set; }
        public int RemainPackagingQTYAction { get; set; }
        public int RemainDeliveryQTYAction { get; set; }
        public int RemainInvoiceQTYAction { get; set; }
        public int TransactionTypeID { get; set; }
        public int TransactionTypeIDTo { get; set; }
    
        public virtual PossibleSequenceTransofrmation PossibleSequenceTransofrmation { get; set; }
        public virtual TransactionsType TransactionsType { get; set; }
        public virtual TransactionsType TransactionsType1 { get; set; }
    }
}
