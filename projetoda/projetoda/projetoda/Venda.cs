//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace projetoda
{
    using System;
    using System.Collections.Generic;
    
    public partial class Venda
    {
        public int IdVenda { get; set; }
        public string DataVenda { get; set; }
        public string ValorNegociado { get; set; }
        public string ComissaoNegociada { get; set; }
    
        public virtual CasaVendavel CasaVendavel { get; set; }
        public virtual Cliente Comprador { get; set; }
    }
}
