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
    
    public partial class FinancialPlanLines
    {
        public int ID { get; set; }
        public int FinancialPlanID { get; set; }
        public int TransactionTypeID { get; set; }
        public int FinancialGroupID { get; set; }
        public Nullable<double> OfferValue { get; set; }
        public Nullable<double> BudgetValue { get; set; }
        public Nullable<double> RealValue { get; set; }
        public Nullable<int> RelatedDocumentTransactionID { get; set; }
        public Nullable<double> ProfitPercent { get; set; }
    
        public virtual FinancialPlans FinancialPlans { get; set; }
        public virtual TransactionsType TransactionsType { get; set; }
        public virtual FinancialCategories FinancialCategories { get; set; }
    }
}
