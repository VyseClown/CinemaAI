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
    
    public partial class Sessoes
    {
        public Sessoes()
        {
            this.Ingressos = new HashSet<Ingressos>();
        }
    
        public int ses_id { get; set; }
        public Nullable<int> ses_num { get; set; }
        public Nullable<System.TimeSpan> ses_horario { get; set; }
        public Nullable<System.DateTime> ses_data { get; set; }
        public Nullable<int> ses_qtdLugares { get; set; }
        public Nullable<int> ses_idFilme { get; set; }
    
        public virtual ICollection<Ingressos> Ingressos { get; set; }
    }
}
