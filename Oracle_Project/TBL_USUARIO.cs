//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oracle_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_USUARIO
    {
        public TBL_USUARIO()
        {
            this.TBL_LOG = new HashSet<TBL_LOG>();
        }
    
        public decimal ID_USUARIO { get; set; }
        public string CEDULA { get; set; }
        public string NOMBRE { get; set; }
        public string APELLIDO { get; set; }
        public string DIRECCION { get; set; }
        public Nullable<decimal> CELULAR { get; set; }
        public Nullable<decimal> ID_LIBRO { get; set; }
    
        public virtual TBL_LIBRO TBL_LIBRO { get; set; }
        public virtual ICollection<TBL_LOG> TBL_LOG { get; set; }
    }
}
