﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class Casa
    {
        //construtor da classe Casa que cria a Casa
        public Casa(string localidade, string rua, string numero, string andar, string area, string numeroAssoalhadas, string numeroWc, string numeroPisos, string tipo, int cliente)
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
            ClienteIdCliente = cliente;
        }

        //função que retorna os dados dos serviços
        public override string ToString()
        {
            return Tipo + ": " + Rua + " " + Numero;
        }
    }
}
