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
    
    public partial class CREDENCIAL
    {
        public decimal ID_CREDENCIAL { get; set; }
        public string USER_CRED { get; set; }
        public string PASSWORD { get; set; }
        public decimal ID_ROL { get; set; }
        public decimal ID_EST_CREDEN { get; set; }
        public Nullable<decimal> ID_PROFESIONAL { get; set; }
        public Nullable<decimal> ID_CLIENTE { get; set; }
    
        public virtual CLIENTE_EMPRESA CLIENTE_EMPRESA { get; set; }
        public virtual ESTADO_CREDENCIAL ESTADO_CREDENCIAL { get; set; }
        public virtual PROFESIONAL PROFESIONAL { get; set; }
        public virtual ROL ROL { get; set; }
    }
}
