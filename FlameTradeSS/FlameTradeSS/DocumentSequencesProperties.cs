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
    
    public partial class DocumentSequencesProperties
    {
        public int ID { get; set; }
        public int DocumentSequenceID { get; set; }
        public int DgvFieldsID { get; set; }
        public int InVisible { get; set; }
        public int ReadOnly { get; set; }
        public int Disabled { get; set; }
        public Nullable<int> TransactonTypeID { get; set; }
    
        public virtual DgvFields DgvFields { get; set; }
        public virtual DocumentSequences DocumentSequences { get; set; }
        public virtual TransactionsType TransactionsType { get; set; }
    }
}