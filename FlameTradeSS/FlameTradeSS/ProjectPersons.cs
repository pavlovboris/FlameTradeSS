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
    
    public partial class ProjectPersons
    {
        public int ID { get; set; }
        public int ProjectID { get; set; }
        public int PersonsID { get; set; }
        public int ResponsibilityID { get; set; }
    
        public virtual Persons Persons { get; set; }
        public virtual Project Project { get; set; }
    }
}