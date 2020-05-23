using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class Venda 
    {
        public Venda(string dataVenda, string valorNegociado, string comissaoNegociada, Cliente comprador, CasaVendavel casaVendavel)
        {
            DataVenda = dataVenda;
            ValorNegociado = valorNegociado;
            ComissaoNegociada = comissaoNegociada;
            Comprador = comprador;
            CasaVendavel = casaVendavel;
        }

        public override string ToString()
        {
            return CasaVendavel.Numero + " " + CasaVendavel.Rua + " " + CasaVendavel.Localidade;
        }

    }
}
