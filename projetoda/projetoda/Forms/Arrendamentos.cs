using ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations.Design;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA.Forms
{
    public partial class Arrendamentos : Form
    {
        // variaveis de utilização do projeto
        private int casa_id;
        private ModelImoDaContainer imoDA;
        // Listas de valores das casas, clientes e arrendamento
        private List<Casa> lista_casa;
        private List<Arrendamento> lista_arrendamento;
        private List<Cliente> lista_cliente;
        private bool soleitura;

        public Arrendamentos(int id_casa,bool visual)
        {
            //inicialização do form
            InitializeComponent();
            imoDA = new ModelImoDaContainer();
            casa_id = id_casa;
            LerDados();
            // carregamento dos dados na base de dados para as listas
            lista_casa = imoDA.CasaSet.ToList();
            lista_cliente = imoDA.ClienteSet.ToList();
            LerDados_cliente();
            soleitura = visual;
        }

        //função que desativa as caixas de texto se o form for só de leitura
        private void desativa()
        {  
            dateTimePicker1.Enabled = false;
            comboBox1.Enabled = false;
            numericUpDown1.Enabled = false;
            checkBox1.Enabled = false;
        }

        //função que lê os dados da base de dados 
        private void LerDados()
        {
            imoDA.Dispose();
            imoDA = new ModelImoDaContainer();

            // carrega os dados para a lista de arrendamentos
            lista_arrendamento = (from Arrendamento in imoDA.ArrendamentoSet
                              where Arrendamento.CasaArrendavelIdCasa == casa_id
                              orderby Arrendamento.InicioContrato
                              select Arrendamento).ToList();

            listBox_arrendamentos.DataSource = null;
            listBox_arrendamentos.DataSource = imoDA.ArrendamentoSet.Local.ToBindingList();
        }

        //função que lê os dados dos clientes e os lista na combobox
        private void LerDados_cliente()
        {
            foreach (Cliente cliente in lista_cliente)
            {
                comboBox1.Items.Add(cliente.Nome + " (" + cliente.NIF + ")");
            }
        }
        
        //função que remove o arrendamento selecionado se o form não for de leitura
        private void bt_remover_Click(object sender, EventArgs e)
        {
          if (soleitura == true)
            {
                return;
            }
            int index = listBox_arrendamentos.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            else
            {
                Arrendamento arrendamento = lista_arrendamento[index];
                imoDA.ArrendamentoSet.Local.Remove(lista_arrendamento[index]);
                imoDA.SaveChanges();
                LerDados();
                
            }
        }

        //função que excuta quando o form é iniciado
        // esta função escreve o tipo de casa e o cliente nos campos para mostrar ao utlizador no formulário
        private void Arrendamentos_Load(object sender, EventArgs e)
        {
            if (soleitura == true)
            {
                desativa();
            }

            if (casa_id == 0)
            {
                bt_inserir.Enabled = false;
                bt_remover.Enabled = false;
                return;
            }else
            {
                bt_inserir.Enabled = true;
                bt_remover.Enabled = true;
                foreach (Casa casa in lista_casa)
                {
                    if (casa.IdCasa == casa_id)
                    {
                       if (casa is CasaArrendavel)
                        {
                            label_casa.Text = "Casa Arrendavel:";
                        }else if (casa is CasaVendavel)
                        {
                            label_casa.Text = "Casa Vendavel:";
                        }else if (casa is Casa)
                        {
                            label_casa.Text = "Casa:";
                        }
                            label_id.Text = casa.IdCasa.ToString();
                            label_localidade.Text = casa.Rua + " " + casa.Localidade + " " + casa.Numero;
                            foreach(Cliente cliente in lista_cliente)
                            {
                                if (cliente.IdCliente == casa.ClienteIdCliente)
                                {
                                    label_proprietario.Text = cliente.Nome + "(" + cliente.NIF + ")";
                                    return;
                                }
                            }
                       
                    }
                }

            }
        }

        //função que excuta quando existe o click na list_box
        // esta função carrega os dados do campo selecionado para as caixas de texto para mostrar a informação mais detalahda
        private void listBox_arrendamentos_Click(object sender, EventArgs e)
        {
            int index = listBox_arrendamentos.SelectedIndex;
            if (index == -1)
            {
                bt_inserir.Enabled = false;
                bt_remover.Enabled = false;
                return;
               
            }
            else
            {
                bt_inserir.Enabled = true;
                bt_remover.Enabled = true;
                Arrendamento arrendamento = lista_arrendamento[index];
                dateTimePicker1.Value = arrendamento.InicioContrato;
                numericUpDown1.Value = arrendamento.DuracaoMeses;
                checkBox1.Checked = arrendamento.Renovavel;
               foreach(Cliente cliente in lista_cliente)
                {
                    if (cliente.IdCliente == arrendamento.ClienteIdCliente)
                    {
                        comboBox1.Text = cliente.Nome + " (" + cliente.NIF + ")";
                    }
                }
                
            }
        }

        //função do botão de inserir arrendamento
        // esta função insere o arrendamento da casa selecionada para o arrendatário definido
        private void bt_inserir_Click(object sender, EventArgs e)
        {
            if (soleitura == true)
            {
                return;
            }
            int index = comboBox1.SelectedIndex;
            if (comboBox1.Text=="" || index == -1)
            {
                MessageBox.Show("Preencha todos os campos", "Dados Incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }  
            
            Cliente cliente = lista_cliente[index];
            
            Arrendamento arrendamento = new Arrendamento(dateTimePicker1.Value,Convert.ToInt32(numericUpDown1.Value), checkBox1.Checked, cliente.IdCliente, casa_id);
            try
            {
                imoDA.ArrendamentoSet.Add(arrendamento);
                imoDA.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LerDados();
        }
    }
}
