//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dominio
{
    using System;
    using System.Collections.Generic;
    
    public partial class Salas
    {
        public Salas()
        {
            this.Ingressos = new HashSet<Ingressos>();
        }
    
        public int sal_id { get; set; }
        public Nullable<int> sal_qtdcadeira { get; set; }
        public string sal_desc { get; set; }
    
        public virtual ICollection<Ingressos> Ingressos { get; set; }
    }
}
