//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapaDALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class PLAN_SERVICIO
    {
        public decimal ID_PLAN { get; set; }
        public decimal ID_SERVICIO { get; set; }
        public decimal CANTIDAD { get; set; }
    
        public virtual PLAN PLAN { get; set; }
        public virtual SERVICIO SERVICIO { get; set; }
    }
}
