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
    
    public partial class Limpeza
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Limpeza()
        {
            this.Servicoes = new HashSet<Servico>();
        }
    
        public int IdLimpeza { get; set; }
        public System.DateTime Data { get; set; }
        public int CasaIdCasa { get; set; }
        public bool Emitido_fatura { get; set; }
    
        public virtual Casa Casa { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Servico> Servicoes { get; set; }
    }
}
