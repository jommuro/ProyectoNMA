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
    
    public partial class REP_PROFESIONAL
    {
        public decimal ID_REP_PRO { get; set; }
        public decimal CANT_CAP_PRO { get; set; }
        public decimal NUM_ACC_POST_CAP { get; set; }
        public decimal NUM_ACT_ATRASADA { get; set; }
        public decimal NUM_ACT_CANCEL { get; set; }
        public decimal NUM_ACT_TERMIN { get; set; }
        public decimal ID_PROFESIONAL { get; set; }
    
        public virtual PROFESIONAL PROFESIONAL { get; set; }
    }
}
