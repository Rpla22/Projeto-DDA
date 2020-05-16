using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class Casa
    {
        public Casa(string localidade, string rua, string numero, string andar, string area, string numeroAssoalhadas, string numeroWc, string numeroPisos, string tipo, Cliente cliente)
        {
            Localidade = localidade;
            Rua = rua;
            Numero = numero;
            Andar = andar;
            Area = area;
            NumeroAssoalhadas = numeroAssoalhadas;
            NumeroWc = numeroWc;
            NumeroPisos = numeroPisos;
            Tipo = tipo;
            Cliente = cliente;
        }

        public override string ToString()
        {
            return Tipo + ": " + Rua + " " + Numero;
        }
    }
}
