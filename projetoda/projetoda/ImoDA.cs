using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDA.Forms;


namespace ProjetoDA
{
    public partial class ImoDA : Form
    {
        //inicialização do form inicial
        public ImoDA()
        {
            InitializeComponent();
        }

        //botão que abre o formulário clientes
        private void bt_clientes_Click(object sender, EventArgs e)
        {
           //cria o form clientes
            Clientes clientes = new Clientes();
            //quando o form clientes fechar excuta a funão Clientes_FormClosed
            clientes.FormClosed += Clientes_FormClosed;

            //esconde o formulário atual e abre o form clientes
            this.Hide();
            clientes.Show();
        }

        //função que é excutada quando o form de clientes é fechado
        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //botão que abre o formulário casas
        private void bt_casas_Click(object sender, EventArgs e)
        {
            //cria o form casas
            Casas casas = new Casas(0);
            //quando o form casas fechar excuta a funão Casas_FormClosed
            casas.FormClosed += Casas_FormClosed;

            //esconde o formulário atual e abre o form casas
            this.Hide();
            casas.Show();
        }

        //função que é excutada quando o form de casas é fechado
        private void Casas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
 
    }
}
