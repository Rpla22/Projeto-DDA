//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjetoDA.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Arrendamento
    {
        public int IdArrendamento { get; set; }
        public string InicioContrato { get; set; }
        public string DuracaoMeses { get; set; }
        public string Renovavel { get; set; }
    
        public virtual Cliente Arrendatario { get; set; }
        public virtual CasaArrendavel CasaArrendavel { get; set; }
    }
}
