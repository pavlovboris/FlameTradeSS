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
    
    public partial class DocumentsRolesRestrictions
    {
        public int ID { get; set; }
        public int RolesID { get; set; }
        public int DocumentSequenceID { get; set; }
        public int AllowEdits { get; set; }
        public int AllowCreate { get; set; }
        public int AllowDelete { get; set; }
    
        public virtual DocumentSequences DocumentSequences { get; set; }
        public virtual Roles Roles { get; set; }
    }
}
