using ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA.Forms
{
    public partial class Vendas : Form
    {
        // inicialização das variáveis que são utilizadas durante o projeto
        private int casa_id;
        private bool soleitura;
        private ModelImoDaContainer imoDA;
        // Listas de casas,vendas e clientes
        private List<Casa> lista_casa;
        private List<Venda> lista_vendas;
        private List<Cliente> lista_cliente;


        public Vendas(int id_casa, bool leitura,int id_venda)
        {
            //inicialização do formulário
          InitializeComponent();
          imoDA = new ModelImoDaContainer();
          casa_id = id_casa;
            // carregar os dados da base de dados para as listas
            lista_casa = imoDA.CasaSet.ToList();
            lista_cliente = imoDA.ClienteSet.ToList();
            LerDados_cliente();
            LerDados(id_venda);
           
            soleitura = leitura;

        }


        //função que desativa as textbox, datetime e combobox para ficarem só em leitura
        private void desativa()
        {
            dateTimePicker1.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            comboBox1.Enabled = false;    
        }

        //função que lê os dados das vendas
        private void LerDados(int id_venda)
        {
            imoDA.Dispose();
            imoDA = new ModelImoDaContainer();
            // carrega para a lista os valores das vendas
            lista_vendas = (from Venda in imoDA.VendaSet
                                where Venda.CasaVendavelIdCasa == casa_id
                                orderby Venda.DataVenda
                                select Venda).ToList();
            if (id_venda != 0)
            {
                foreach(Venda venda in lista_vendas)
                {
                    if (venda.IdVenda == id_venda)
                    {
                        // carrega os dados para a vista se o id da venda for igual ao que foi enviado quando é chamado o from
                        dateTimePicker1.Value = venda.DataVenda;
                        textBox1.Text = venda.ValorNegociado.ToString();
                        textBox2.Text = venda.ComissaoNegociada.ToString();
                        foreach (Cliente cliente in lista_cliente)
                        {
                            if (cliente.IdCliente == venda.ClienteIdCliente)
                            {
                                comboBox1.Text = cliente.Nome + " (" + cliente.NIF + ")";
                            }
                        }
                    }
                }
            }
        }

        private void LerDados_cliente()
        {
            foreach (Casa casa in lista_casa)
            {
                if (casa.IdCasa == casa_id)
                {
                    foreach (Cliente cliente in lista_cliente)
                    {
                        if (cliente.IdCliente == casa.ClienteIdCliente)
                        {
                            lb_proprietario.Text = cliente.Nome + " (" + cliente.NIF + ")";
                            return;
                        }

                    }
                }
            }
        }

      
        //função que é excutada quando o form é inicializado
        private void Vendas_Load(object sender, EventArgs e)
        {
            if (soleitura == true)
            {
                desativa();

            }
            if (casa_id == 0)
            {
                bt_efetivar.Enabled = false;
                return;
            }
            else
            {
                bt_efetivar.Enabled = true;
            }
            foreach (Casa casa in lista_casa)
            {
                if (casa.IdCasa == casa_id)
                {
                    if (casa is CasaVendavel)
                    {
                        // carrega os dados da casa para a vista
                        CasaVendavel casaVendavel = (CasaVendavel)casa;
                        lb_valor.Text = casaVendavel.ValorBaseVenda;
                        lb_comissao.Text = casaVendavel.ValorComissao;
                    }
                }                 
            }
            foreach (Cliente cliente in lista_cliente)
            {
                comboBox1.Items.Add(cliente.Nome + " (" + cliente.NIF + ")");
            }

        }

        //função do botão de efetivar a venda
        private void bt_efetivar_Click(object sender, EventArgs e)
        {
            //verifica se o form não é só de leitura
            if (soleitura == true)
            {
                return;
            }
            int index = comboBox1.SelectedIndex;
            if (textBox1.Text=="" || textBox2.Text=="" || index == -1)
            {
                MessageBox.Show("Preencha todos os campos", "Dados Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToDecimal(textBox1.Text) <  Convert.ToDecimal(lb_valor.Text) || Convert.ToDecimal(textBox2.Text) < Convert.ToDecimal(lb_comissao.Text))
            {
                MessageBox.Show("Valor Base ou valor da comissão não podem ser menor que os valores definidos", "Erro de dados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = lista_cliente[index];
            //cria a venda
            Venda venda = new Venda(dateTimePicker1.Value, Convert.ToDecimal(textBox1.Text), Convert.ToDecimal(textBox2.Text), casa_id, cliente.IdCliente);
            try
            {
                imoDA.VendaSet.Add(venda);
                imoDA.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            MessageBox.Show("Venda efetuada com sucesso", "Venda", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            desativa();
            bt_efetivar.Enabled = false;
        }
    }
}
