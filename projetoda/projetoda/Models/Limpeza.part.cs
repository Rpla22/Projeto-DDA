using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
  public partial class Limpeza
    {
        //construtor da classe Limpeza que cria a Limpeza
        public Limpeza(DateTime data, int casaIdCasa, bool emitido_fatura)
        {
            Data = data;
            CasaIdCasa = casaIdCasa;
            Emitido_fatura = emitido_fatura;
        }
    }
}
