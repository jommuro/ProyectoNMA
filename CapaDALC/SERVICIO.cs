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
    
    public partial class SERVICIO
    {
        public SERVICIO()
        {
            this.ACTIVIDAD = new HashSet<ACTIVIDAD>();
            this.CONTRATO_SERVICIO = new HashSet<CONTRATO_SERVICIO>();
            this.PLAN_SERVICIO = new HashSet<PLAN_SERVICIO>();
        }
    
        public decimal ID_SERVICIO { get; set; }
        public string NOMBRE { get; set; }
        public decimal PRECIO { get; set; }
        public string REGLA { get; set; }
    
        public virtual ICollection<ACTIVIDAD> ACTIVIDAD { get; set; }
        public virtual ICollection<CONTRATO_SERVICIO> CONTRATO_SERVICIO { get; set; }
        public virtual ICollection<PLAN_SERVICIO> PLAN_SERVICIO { get; set; }
    }
}
