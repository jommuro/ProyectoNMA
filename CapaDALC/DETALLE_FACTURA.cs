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
    
    public partial class DETALLE_FACTURA
    {
        public decimal ID_DET_FACTURA { get; set; }
        public string NOMBRE_SERVICIO { get; set; }
        public decimal COSTO_ASOCIADO { get; set; }
        public decimal NUM_FACTURA { get; set; }
        public decimal ID_ACTIVIDAD { get; set; }
    
        public virtual ACTIVIDAD ACTIVIDAD { get; set; }
        public virtual FACTURA FACTURA { get; set; }
    }
}
