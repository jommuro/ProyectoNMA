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
    
    public partial class ACTIVIDAD
    {
        public ACTIVIDAD()
        {
            this.ACT_TRAB = new HashSet<ACT_TRAB>();
            this.DETALLE_FACTURA = new HashSet<DETALLE_FACTURA>();
            this.INTERACCION = new HashSet<INTERACCION>();
            this.MATERIAL = new HashSet<MATERIAL>();
        }
    
        public decimal ID_ACTIVIDAD { get; set; }
        public System.DateTime FECH_ACTIVIDAD { get; set; }
        public decimal HORA { get; set; }
        public decimal MINUTO { get; set; }
        public decimal ID_CLIENTE { get; set; }
        public decimal ID_SERVICIO { get; set; }
        public decimal ID_EST_ACT { get; set; }
        public Nullable<decimal> ID_PROFESIONAL { get; set; }
        public Nullable<decimal> ID_CHECK { get; set; }
    
        public virtual ICollection<ACT_TRAB> ACT_TRAB { get; set; }
        public virtual CHECKLIST CHECKLIST { get; set; }
        public virtual CLIENTE_EMPRESA CLIENTE_EMPRESA { get; set; }
        public virtual ESTADO_ACTIVIDAD ESTADO_ACTIVIDAD { get; set; }
        public virtual PROFESIONAL PROFESIONAL { get; set; }
        public virtual SERVICIO SERVICIO { get; set; }
        public virtual ICollection<DETALLE_FACTURA> DETALLE_FACTURA { get; set; }
        public virtual ICollection<INTERACCION> INTERACCION { get; set; }
        public virtual ICollection<MATERIAL> MATERIAL { get; set; }
    }
}