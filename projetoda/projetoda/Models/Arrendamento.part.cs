using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA.Models
{
    public partial class Arrendamento
    {
        //construtor da classe Arrendamento que cria o Arrendamento
        public Arrendamento(DateTime inicioContrato, int duracaoMeses, Boolean renovavel, int arrendatario, int casaarrendavel)
        {
            InicioContrato = inicioContrato;
            DuracaoMeses = duracaoMeses;
            Renovavel = renovavel;
            ClienteIdCliente = arrendatario;
            CasaArrendavelIdCasa = casaarrendavel;
        }

        //função que retorna os dados dos Arrendamentos
        public override string ToString()
        {
            return "Inicio: " + InicioContrato + " " + DuracaoMeses + " Renovável:" + Renovavel;
        }
    }
}
