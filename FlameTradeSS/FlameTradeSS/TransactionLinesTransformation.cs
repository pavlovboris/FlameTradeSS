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
    
    public partial class TransactionLinesTransformation
    {
        public int ID { get; set; }
        public int TransactionLineID { get; set; }
        public int OriginTransactionLineID { get; set; }
    
        public virtual TransactionLines TransactionLines { get; set; }
        public virtual TransactionLines TransactionLines1 { get; set; }
    }
}
