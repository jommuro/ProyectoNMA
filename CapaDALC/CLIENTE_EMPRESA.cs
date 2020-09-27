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
    
    public partial class CLIENTE_EMPRESA
    {
        public CLIENTE_EMPRESA()
        {
            this.ACTIVIDAD = new HashSet<ACTIVIDAD>();
            this.ASISTENTE = new HashSet<ASISTENTE>();
            this.CHECKLIST = new HashSet<CHECKLIST>();
            this.CONTRATO = new HashSet<CONTRATO>();
            this.CREDENCIAL = new HashSet<CREDENCIAL>();
            this.FACTURA = new HashSet<FACTURA>();
            this.REP_CLI_EMP = new HashSet<REP_CLI_EMP>();
            this.RUBRO = new HashSet<RUBRO>();
        }
    
        public decimal ID_CLIENTE { get; set; }
        public string RUT_EMPRESA { get; set; }
        public string NOMBRE_EMPRESA { get; set; }
        public decimal TELEFONO { get; set; }
        public string MAIL_EMPRESA { get; set; }
        public string DIRECCION { get; set; }
        public decimal ID_COMUNA { get; set; }
        public decimal ID_EST_CLIENT { get; set; }
    
        public virtual ICollection<ACTIVIDAD> ACTIVIDAD { get; set; }
        public virtual ICollection<ASISTENTE> ASISTENTE { get; set; }
        public virtual ICollection<CHECKLIST> CHECKLIST { get; set; }
        public virtual ESTADO_CLIENTE ESTADO_CLIENTE { get; set; }
        public virtual COMUNA COMUNA { get; set; }
        public virtual ICollection<CONTRATO> CONTRATO { get; set; }
        public virtual ICollection<CREDENCIAL> CREDENCIAL { get; set; }
        public virtual ICollection<FACTURA> FACTURA { get; set; }
        public virtual ICollection<REP_CLI_EMP> REP_CLI_EMP { get; set; }
        public virtual ICollection<RUBRO> RUBRO { get; set; }
    }
}
