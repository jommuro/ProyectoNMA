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
    
    public partial class ESTADO_CHECK
    {
        public ESTADO_CHECK()
        {
            this.CHECKLIST = new HashSet<CHECKLIST>();
        }
    
        public decimal ID_EST_CHECK { get; set; }
        public string DESCRIPCION { get; set; }
    
        public virtual ICollection<CHECKLIST> CHECKLIST { get; set; }
    }
}