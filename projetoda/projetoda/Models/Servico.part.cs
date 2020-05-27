using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class Servico
    {
        //construtor da classe Serviço que cria o Serviço
        public Servico(string descricao, int valor, string unidades, int limpezaIdLimpeza,int valortotal)
        {
            Descricao = descricao;
            Valor = valor;
            Unidades = unidades;
            LimpezaIdLimpeza = limpezaIdLimpeza;
            Valor_total = valortotal;
        }

        //função que retorna os dados dos serviços
        public override string ToString()
        {
            return Valor_total+"€ "+ Unidades+"x ["+Valor+"€, "+Descricao+"]";
        }
    }
}
