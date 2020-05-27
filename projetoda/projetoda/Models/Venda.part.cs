using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class Venda 
    {
        //construtor da classe Venda que cria as vendas
        public Venda(DateTime dataVenda, decimal valorNegociado, decimal comissaoNegociada, int casa_vendal, int cliente_id)
        {
            DataVenda = dataVenda;
            ValorNegociado = valorNegociado;
            ComissaoNegociada = comissaoNegociada;
            CasaVendavelIdCasa = casa_vendal;
            ClienteIdCliente = cliente_id;
        }

        //função que retorna os dados da venda
        public override string ToString()
        {
            return CasaVendavel.Numero + " " + CasaVendavel.Rua + " " + CasaVendavel.Localidade;
        }

    }
}
