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
    
    public partial class INTERACCION
    {
        public decimal ID_INTERACCION { get; set; }
        public System.DateTime FEC_INTERACCION { get; set; }
        public decimal HORA { get; set; }
        public decimal MINUTO { get; set; }
        public string OBSERVACION { get; set; }
        public decimal ID_TIP_INTER { get; set; }
        public decimal ID_ACTIVIDAD { get; set; }
    
        public virtual ACTIVIDAD ACTIVIDAD { get; set; }
        public virtual TIPO_INTERACCION TIPO_INTERACCION { get; set; }
    }
}
