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
    
    public partial class ItemsConfiguration
    {
        public int ID { get; set; }
        public int ItemID { get; set; }
        public int ItemOfOrigin { get; set; }
    
        public virtual Items Items { get; set; }
        public virtual Items Items1 { get; set; }
    }
}
