using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class Arrendamento
    {
        public Arrendamento(string inicioContrato, string duracaoMeses, string renovavel, Cliente arrendatario, CasaArrendavel casaArrendavel)
        {
            InicioContrato = inicioContrato;
            DuracaoMeses = duracaoMeses;
            Renovavel = renovavel;
            Arrendatario = arrendatario;
            CasaArrendavel = casaArrendavel;
        }

        public override string ToString()
        {
            return "Inicio: " + InicioContrato + " " + DuracaoMeses + " Renovável:" + Renovavel + " a " + Arrendatario.Nome;
        }
    }
}
