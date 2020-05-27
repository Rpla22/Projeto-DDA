﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using ProjetoDA.Models;

namespace ProjetoDA.Forms
{
    public partial class Clientes : Form
    {
        private ModelImoDaContainer imoDA;
        //lista com os clientes que estão na base de dados
        private List<Cliente> lista_cliente;

        public Clientes()
        {
            //inicialização do form clientes 
            imoDA = new ModelImoDaContainer();
            InitializeComponent();
            LerDados();
        }

        //funçao que lê os dados dos clientes
        private void LerDados()
        {
            imoDA.Dispose();
            imoDA = new ModelImoDaContainer();
            (from cliente in imoDA.ClienteSet
             orderby cliente.Nome
             select cliente).ToList();
            clienteSetDataGridView.DataSource = null;
            clienteSetDataGridView.DataSource = imoDA.ClienteSet.Local.ToBindingList();
            lista_cliente = (from cliente in imoDA.ClienteSet
                             orderby cliente.Nome
                             select cliente).ToList();            
        }
       
        //função qu guarda o cliente na base de dados
        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text== "" || tb_nif.Text=="" || tb_morada.Text=="" || tb_contacto.Text=="")
            {
                MessageBox.Show("Todos os campos sao obrigatórios");
                return;
            }

            foreach (Cliente cliente in lista_cliente)
            {
                //se o cliente que pretende guardar já existir na base de dados pergunta se pretende alterar os dados
                if(cliente.NIF == tb_nif.Text)
                {
                    DialogResult result = MessageBox.Show("Pretende alterar as informações do cliente com o NIF: " + cliente.NIF + "?", "O Cliente ja se encontra registado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (Convert.ToString(result) == "Yes")
                    {
                        cliente.Nome = tb_nome.Text;
                        cliente.Morada = tb_morada.Text;
                        cliente.Contacto = tb_contacto.Text;                      
                        imoDA.SaveChanges();
                        LerDados();
                    }
                    return;
                }
            }
            if (tb_nif.TextLength != 9)
            {
                MessageBox.Show("O NIF encontra-se inválido");
                return;
            }
            else if(!IsValidContrib(tb_nif.Text)){
                MessageBox.Show("O NIF encontra-se inválido 2");
                return;
            }

            //guarda o cliente
            Cliente novoCliente = new Cliente(tb_nome.Text, tb_nif.Text, tb_morada.Text, tb_contacto.Text);
            try
            {
                imoDA.ClienteSet.Add(novoCliente);
                imoDA.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            LerDados();
        }

        //se o dado na textbox_nif for diferente de numero não deixa introduzir
        private void tb_nif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        //se o dado na textbox_contato for diferente de numero não deixa introduzir
        private void tb_contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // verifica se o contribuinte é valido
        public bool IsValidContrib(string Contrib)
        {
            bool functionReturnValue = false;
            functionReturnValue = false;
            string[] s = new string[9];
            string Ss = null;
            string C = null;
            int i = 0;
            long checkDigit = 0;

            s[0] = Convert.ToString(Contrib[0]);
            s[1] = Convert.ToString(Contrib[1]);
            s[2] = Convert.ToString(Contrib[2]);
            s[3] = Convert.ToString(Contrib[3]);
            s[4] = Convert.ToString(Contrib[4]);
            s[5] = Convert.ToString(Contrib[5]);
            s[6] = Convert.ToString(Contrib[6]);
            s[7] = Convert.ToString(Contrib[7]);
            s[8] = Convert.ToString(Contrib[8]);

            if (Contrib.Length == 9)
            {
                C = s[0];
                if (s[0] == "1" || s[0] == "2" || s[0] == "5" || s[0] == "6" || s[0] == "9")
                {
                    checkDigit = Convert.ToInt32(C) * 9;
                    for (i = 2; i <= 8; i++)
                    {
                        checkDigit = checkDigit + (Convert.ToInt32(s[i - 1]) * (10 - i));
                    }
                    checkDigit = 11 - (checkDigit % 11);
                    if ((checkDigit >= 10))
                        checkDigit = 0;
                    Ss = s[0] + s[1] + s[2] + s[3] + s[4] + s[5] + s[6] + s[7] + s[8];
                    if ((checkDigit == Convert.ToInt32(s[8])))
                        functionReturnValue = true;
                }
            }
            return functionReturnValue;
        }

        //funçao de click da datagridview
        private void clienteSetDataGridView_Click(object sender, EventArgs e)
        {
            if (lista_cliente.Count == 0)
            {
                return;
            }
            //lista os dados do cliente nas textbox e nas listbox 
            int index = clienteSetDataGridView.CurrentCell.RowIndex;

            if (index == -1)
            {
                return;
            }
            tb_nome.Text = lista_cliente[index].Nome;
            tb_nif.Text = lista_cliente[index].NIF;
            tb_morada.Text = lista_cliente[index].Morada;
            tb_contacto.Text = lista_cliente[index].Contacto;

            try
            {
                listBox1.DataSource = lista_cliente[index].Casas.ToList();
                listBox2.DataSource = lista_cliente[index].Arrendamentos.ToList();
                listBox3.DataSource = lista_cliente[index].Vendas.ToList();
            }catch(Exception)
            {
            }
            
        }

        //função que limpa as caixas de texto
        private void bt_novo_Click(object sender, EventArgs e)
        {
            tb_nome.Text = "";
            tb_nif.Text = "";
            tb_morada.Text = "";
            tb_contacto.Text = "";
        }

        //função que filtra eprocura os dados na base de dados 
        private void bt_filtrar_Click(object sender, EventArgs e)
        {
            imoDA.Dispose();
            imoDA = new ModelImoDaContainer();
            if (tb_filtrar.Text == "")
            {
                LerDados();
                return;
            }
            
            if (cb_filtrar.Text !="")
            {
                switch (cb_filtrar.Text)
                {
                    case "Contacto":
                        foreach (Cliente local_cliente in lista_cliente)
                        {
                            if (tb_filtrar.Text == local_cliente.Contacto)
                            {
                                (from cliente in imoDA.ClienteSet
                                 where cliente.Contacto.Contains(tb_filtrar.Text)
                                 select cliente).ToList();

                                clienteSetDataGridView.DataSource = null;
                                clienteSetDataGridView.DataSource = imoDA.ClienteSet.Local.ToBindingList();
                                return;
                            }
                        }

                        MessageBox.Show("Não foram encontrados dados correspondentes à pesquisa");
                        break;

                    case "Nome":
                        foreach (Cliente local_cliente in lista_cliente)
                        {
                            if (local_cliente.Nome.ToString().ToUpper().Contains(tb_filtrar.Text.ToUpper()))
                            {
                                (from cliente in imoDA.ClienteSet
                                 where cliente.Nome.ToString().Contains(tb_filtrar.Text)
                                 select cliente).ToList();
                                clienteSetDataGridView.DataSource = null;
                                clienteSetDataGridView.DataSource = imoDA.ClienteSet.Local.ToBindingList();
                                return;
                            }
                        }

                        MessageBox.Show("Não foram encontrados dados correspondentes à pesquisa");
                        break;

                    case "NIF":

                        foreach (Cliente local_cliente in lista_cliente)
                        {
                            if (tb_filtrar.Text == local_cliente.NIF)
                            {
                                (from cliente in imoDA.ClienteSet
                                 where cliente.NIF.ToString().Contains(tb_filtrar.Text)
                                 select cliente).ToList();

                                clienteSetDataGridView.DataSource = null;
                                clienteSetDataGridView.DataSource = imoDA.ClienteSet.Local.ToBindingList();
                                return;
                            }
                        }

                        MessageBox.Show("Não foram encontrados dados correspondentes à pesquisa");

                        break;

                }

            }
            else
            {
                MessageBox.Show("Campos Vazios");
                LerDados();

            }
        }

        // função que apaga o cliente da base de dados se não exixtir nenhum relacionamento
        private void bt_apagar_Click(object sender, EventArgs e)
        {
            if (lista_cliente.Count == 0)
            {
                return;
            }
            int index = clienteSetDataGridView.CurrentCell.RowIndex;
            Cliente cliente = lista_cliente[index];

            List<Casa> lista_casa_id;
            List<Arrendamento> lista_arrendamento_id;
            List<Venda> lista_venda_id;
            lista_casa_id= (from Casa in imoDA.CasaSet
                            where Casa.ClienteIdCliente == cliente.IdCliente
                            select Casa).ToList();

            lista_arrendamento_id = (from Arrendamento in imoDA.ArrendamentoSet
                                     where Arrendamento.ClienteIdCliente == cliente.IdCliente
                                     select Arrendamento).ToList();

            lista_venda_id = (from Venda in imoDA.VendaSet
                              where Venda.ClienteIdCliente == cliente.IdCliente
                              select Venda).ToList();

            if (lista_casa_id.Count!=0 ||lista_arrendamento_id.Count!=0 || lista_venda_id.Count != 0)
            {
                MessageBox.Show("Não é possivel apagar cliente. O cliente tem algo acosiado ","Apagar cliente",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            } 
            DialogResult result = MessageBox.Show("Pretende apagar o cliente " + lista_cliente[index].Nome + "?","Apagar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Convert.ToString(result) == "Yes")
            {   
                imoDA.ClienteSet.Local.Remove(lista_cliente[index]);
                imoDA.SaveChanges();
                LerDados();
            }
            return;


            

        }

        //função que abre o form casa quando selecionada 
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int index1 = clienteSetDataGridView.CurrentCell.RowIndex;
            int index = listBox1.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            
           List <Casa> lista_casa;
            lista_casa = lista_cliente[index1].Casas.ToList();

            Casa casa = (Casa)lista_casa.ElementAt(index);

            Casas formcasa = new Casas(casa.IdCasa);
            formcasa.FormClosed += Formcasa_FormClosed;
            this.Hide();
            formcasa.Show();

        }

        private void Formcasa_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Formarrendamento_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        // função que abre o form arrendamento quando selecionada
        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            int index1 = clienteSetDataGridView.CurrentCell.RowIndex;
            int index = listBox2.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            List<Arrendamento> lista_arrendamento;
            lista_arrendamento = lista_cliente[index1].Arrendamentos.ToList();

            Arrendamento arrenda = (Arrendamento)lista_arrendamento.ElementAt(index);

            Arrendamentos formarrendamento = new Arrendamentos(arrenda.CasaArrendavelIdCasa,true);
            formarrendamento.FormClosed += Formarrendamento_FormClosed;
            this.Hide();
            formarrendamento.Show();
        }

        // função que abre o from vendas quando selecinada
        private void listBox3_DoubleClick(object sender, EventArgs e)
        {
            int index1 = clienteSetDataGridView.CurrentCell.RowIndex;
            int index = listBox3.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            List<Venda> lista_vendas;
            lista_vendas = lista_cliente[index1].Vendas.ToList();

            Venda vendas = (Venda)lista_vendas.ElementAt(index);

            Vendas formvendas = new Vendas(vendas.CasaVendavelIdCasa,true,vendas.IdVenda);
            formvendas.FormClosed += Formvendas_FormClosed;
            this.Hide();
            formvendas.Show();

            }

        private void Formvendas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
