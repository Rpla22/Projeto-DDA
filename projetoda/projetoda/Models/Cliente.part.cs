using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class Cliente 
    {
        public Cliente(string nome, string nif, string morada, string contacto)
        {
            Nome = nome;
            NIF = nif;
            Morada = morada;
            Contacto = contacto;
        }

    }
}
