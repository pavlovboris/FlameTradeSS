﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FlameTradeDbEntities : DbContext
    {
        public FlameTradeDbEntities()
            : base("name=FlameTradeDbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Colors> Colors { get; set; }
        public virtual DbSet<CostingModels> CostingModels { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Documents> Documents { get; set; }
        public virtual DbSet<DocumentsAttachments> DocumentsAttachments { get; set; }
        public virtual DbSet<DocumentSequences> DocumentSequences { get; set; }
        public virtual DbSet<DocumentsProjects> DocumentsProjects { get; set; }
        public virtual DbSet<DocumentTransactions> DocumentTransactions { get; set; }
        public virtual DbSet<DocumentTransformation> DocumentTransformation { get; set; }
        public virtual DbSet<FunctionRoles> FunctionRoles { get; set; }
        public virtual DbSet<Functions> Functions { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<InvoiceNumbering> InvoiceNumbering { get; set; }
        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
        public virtual DbSet<Items> Items { get; set; }
        public virtual DbSet<ItemsConfiguration> ItemsConfiguration { get; set; }
        public virtual DbSet<ItemsGroups> ItemsGroups { get; set; }
        public virtual DbSet<LinesType> LinesType { get; set; }
        public virtual DbSet<Machines> Machines { get; set; }
        public virtual DbSet<MachinesInventory> MachinesInventory { get; set; }
        public virtual DbSet<MachineType> MachineType { get; set; }
        public virtual DbSet<Mu> Mu { get; set; }
        public virtual DbSet<Numbering> Numbering { get; set; }
        public virtual DbSet<Partitions> Partitions { get; set; }
        public virtual DbSet<PartitionType> PartitionType { get; set; }
        public virtual DbSet<PartnerCategory> PartnerCategory { get; set; }
        public virtual DbSet<PartnerGroups> PartnerGroups { get; set; }
        public virtual DbSet<PartnerPersons> PartnerPersons { get; set; }
        public virtual DbSet<Partners> Partners { get; set; }
        public virtual DbSet<PartnerStaticPriceGroup> PartnerStaticPriceGroup { get; set; }
        public virtual DbSet<Persons> Persons { get; set; }
        public virtual DbSet<PersonsRolesOfPersons> PersonsRolesOfPersons { get; set; }
        public virtual DbSet<Project> Project { get; set; }
        public virtual DbSet<ProjectPersons> ProjectPersons { get; set; }
        public virtual DbSet<ReceiptLines> ReceiptLines { get; set; }
        public virtual DbSet<RoleOfPersons> RoleOfPersons { get; set; }
        public virtual DbSet<Roles> Roles { get; set; }
        public virtual DbSet<SequencesTransactions> SequencesTransactions { get; set; }
        public virtual DbSet<SequenceType> SequenceType { get; set; }
        public virtual DbSet<Services> Services { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<TransactionAttachments> TransactionAttachments { get; set; }
        public virtual DbSet<TransactionLines> TransactionLines { get; set; }
        public virtual DbSet<TransactionLinesTransformation> TransactionLinesTransformation { get; set; }
        public virtual DbSet<TransactionPersons> TransactionPersons { get; set; }
        public virtual DbSet<TransactionReceipt> TransactionReceipt { get; set; }
        public virtual DbSet<TransactionsTransformations> TransactionsTransformations { get; set; }
        public virtual DbSet<TransactionsType> TransactionsType { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersLogInLogs> UsersLogInLogs { get; set; }
        public virtual DbSet<CurrentlyLoggedUsers> CurrentlyLoggedUsers { get; set; }
        public virtual DbSet<PersonsFullNameView> PersonsFullNameView { get; set; }
        public virtual DbSet<Surfaces> Surfaces { get; set; }
        public virtual DbSet<PersonsType> PersonsType { get; set; }
        public virtual DbSet<Tasks> Tasks { get; set; }
        public virtual DbSet<TaskStatuses> TaskStatuses { get; set; }
        public virtual DbSet<DgvFields> DgvFields { get; set; }
        public virtual DbSet<DocumentSequencesProperties> DocumentSequencesProperties { get; set; }
        public virtual DbSet<ReceiptModels> ReceiptModels { get; set; }
        public virtual DbSet<ReceiptModelsItemCategories> ReceiptModelsItemCategories { get; set; }
        public virtual DbSet<DocumentTransactionsComments> DocumentTransactionsComments { get; set; }
        public virtual DbSet<TransactionLinesComments> TransactionLinesComments { get; set; }
        public virtual DbSet<FinancialPlanLines> FinancialPlanLines { get; set; }
        public virtual DbSet<FinancialPlans> FinancialPlans { get; set; }
        public virtual DbSet<DocumentsFinancialPlan> DocumentsFinancialPlan { get; set; }
        public virtual DbSet<FinancialPlanColors> FinancialPlanColors { get; set; }
        public virtual DbSet<FinancialCategories> FinancialCategories { get; set; }
        public virtual DbSet<PossibleFinancialCategoryTransactionsType> PossibleFinancialCategoryTransactionsType { get; set; }
        public virtual DbSet<PossibleSequenceTransformationsProperties> PossibleSequenceTransformationsProperties { get; set; }
        public virtual DbSet<PossibleSequenceTransofrmation> PossibleSequenceTransofrmation { get; set; }
        public virtual DbSet<ProjectAttachments> ProjectAttachments { get; set; }
        public virtual DbSet<SurfaceTypes> SurfaceTypes { get; set; }
        public virtual DbSet<TransactionRowsDependancy> TransactionRowsDependancy { get; set; }
        public virtual DbSet<AutoStringDocuments> AutoStringDocuments { get; set; }
        public virtual DbSet<DocumentsStrings> DocumentsStrings { get; set; }
        public virtual DbSet<DocumentStringLines> DocumentStringLines { get; set; }
        public virtual DbSet<ItemsParameters> ItemsParameters { get; set; }
        public virtual DbSet<ItemsParametersItems> ItemsParametersItems { get; set; }
        public virtual DbSet<ReceiptModelsItemsParameters> ReceiptModelsItemsParameters { get; set; }
        public virtual DbSet<TransactionNumbering> TransactionNumbering { get; set; }
        public virtual DbSet<Warehouses> Warehouses { get; set; }
        public virtual DbSet<LogsEditRestrictedDocuments> LogsEditRestrictedDocuments { get; set; }
        public virtual DbSet<DocumentsRolesRestrictions> DocumentsRolesRestrictions { get; set; }
        public virtual DbSet<AccountingCatalogs> AccountingCatalogs { get; set; }
        public virtual DbSet<AccountingEntries> AccountingEntries { get; set; }
        public virtual DbSet<AccountingEntriesModel> AccountingEntriesModel { get; set; }
        public virtual DbSet<AccountingEntriesModelDetails> AccountingEntriesModelDetails { get; set; }
        public virtual DbSet<Accounts> Accounts { get; set; }
        public virtual DbSet<AccountsGroups> AccountsGroups { get; set; }
        public virtual DbSet<AccountsType> AccountsType { get; set; }
        public virtual DbSet<PaymentsType> PaymentsType { get; set; }
    }
}
