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
    
    public partial class CONTRATO_SERVICIO
    {
        public decimal ID_DET_SERV { get; set; }
        public System.DateTime FEC_CONTRATO { get; set; }
        public string COD_CONTRATO { get; set; }
        public decimal ID_SERVICIO { get; set; }
    
        public virtual CONTRATO CONTRATO { get; set; }
        public virtual SERVICIO SERVICIO { get; set; }
    }
}