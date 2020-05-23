<<<<<<< HEAD
﻿using Impressao_PrintDocument;
using ProjetoDA.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA.Forms
{
    public partial class Limpezas : Form
    {
        private int casa_id;
        private ModelImoDaContainer imoDA;
        private List<Casa> lista_casa;
        private List<Limpeza> lista_limpezas;
        private List<Servico> lista_servico;
        private Font printFont;
        private StreamReader streamToPrint;
        public Limpezas(int id_casa)
        {
            InitializeComponent();
            imoDA = new ModelImoDaContainer();
            casa_id = id_casa;
            LerDados();
            lista_casa = imoDA.CasaSet.ToList();
            //lista_limpezas = imoDA.LimpezaSet.ToList();
        }

        private void LerDados()
        {
            listBox_limpezas.Items.Clear();
            imoDA.Dispose();
            imoDA = new ModelImoDaContainer();
           
            lista_limpezas = (from Limpeza in imoDA.LimpezaSet
                              where Limpeza.CasaIdCasa == casa_id
                             orderby Limpeza.Data
                             select Limpeza).ToList();

            foreach (Limpeza limpeza in lista_limpezas)
            {
                int valor = Lerservicos(limpeza.IdLimpeza);
                listBox_limpezas.Items.Add(valor.ToString() + "€ a " + limpeza.Data);
            }
            }

        private int Lerservicos(int id_limpeza)
        {
            int total_limpeza;
            total_limpeza = 0;
            lista_servico = (from Servico in imoDA.ServicoSet
                             where Servico.LimpezaIdLimpeza == id_limpeza
                             select Servico).ToList();
            if (lista_servico.Count==0 )
            {
                return 0;
            }   
            foreach (Servico servico in lista_servico)
            {      
               total_limpeza = total_limpeza + servico.Valor_total;
            }
            return total_limpeza;      
            }     

        private void Listarservico(int id_limpeza)
        {
            lista_servico.Clear();
            lista_servico = (from Servico in imoDA.ServicoSet
                             where Servico.LimpezaIdLimpeza == id_limpeza
                             select Servico).ToList();
            if (lista_servico.Count==0)
            {
                listBox_servicos.DataSource = null;
                return;
            }
                listBox_servicos.DataSource = null;
                listBox_servicos.DataSource = lista_servico;
                listBox_servicos.SelectedIndex = 0;
        }
        private void Limpezas_Load(object sender, EventArgs e)
        {

            bt_emitir.Enabled = false;
            if (casa_id == 0)
            {
                bt_criar.Enabled = false;
                groupBox1.Enabled = false;
                return;
            }
            else
            {
                foreach (Casa casa in lista_casa)
                {
                    if (casa.IdCasa == casa_id)
                    {
                       if (casa is Casa)
                        {
                            label_casa.Text = "Casa " + casa.IdCasa+" - "+casa.Localidade;
                        }else if (casa is CasaArrendavel)
                        {
                            label_casa.Text = "Casa Arrendavel " + casa.IdCasa + " - " + casa.Localidade;
                        }else if (casa is CasaVendavel)
                        {
                            label_casa.Text = "Casa Vendavel " + casa.IdCasa + " - " + casa.Localidade;
                        }
                    }
                }
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int index1 = listBox_limpezas.SelectedIndex;
            int index = listBox_servicos.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            if (e.KeyCode == Keys.Delete)
            {
                Servico servico = lista_servico[index];
                imoDA.ServicoSet.Local.Remove(lista_servico[index]);
                imoDA.SaveChanges();
                lista_servico.RemoveAt(index);
                LerDados();
                Listarservico(lista_limpezas[index1].IdLimpeza);
                listBox_limpezas.SelectedIndex = index1;
            }
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                label_valor.Text = "10€";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                label_valor.Text = "20€";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                label_valor.Text = "30€";
            }
        }

        private void listBox2_Click(object sender, EventArgs e)
        {
            int index = listBox_limpezas.SelectedIndex;
            
            if (index==-1)
            {
                groupBox1.Enabled = false;
                bt_emitir.Enabled = false;
                return;
            }else
            {
                Limpeza limpeza = lista_limpezas[index];
                Listarservico(limpeza.IdLimpeza);

                if (limpeza.Emitido_fatura == true)
                {
                    groupBox1.Enabled = false;
                    bt_emitir.Enabled = false;
                    return;
                }  
                groupBox1.Enabled= true;
                bt_emitir.Enabled = true;
            }
        }

        private void bt_emitir_Click(object sender, EventArgs e)
        {
            int index = listBox_limpezas.SelectedIndex;
            List<Cliente> lista_cliente;

            lista_cliente = imoDA.ClienteSet.ToList();

            if (index == -1)
            {
                return;
            }    
            Limpeza limpeza = lista_limpezas[index];
            if (Lerservicos(limpeza.IdLimpeza) == 0)
            {
                DialogResult result = MessageBox.Show("Pretende apagar a limpeza. Esta não contem serviços ?", "Apagar Limpeza", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Convert.ToString(result) == "Yes")
                {
                    imoDA.LimpezaSet.Local.Remove(lista_limpezas[index]);
                    imoDA.SaveChanges();
                    LerDados();
                }
                return;
            }
            else {
                DialogResult result = MessageBox.Show("Pretende Emitir a fatura ?", "Emitir Fatura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (Convert.ToString(result) == "Yes")
                {
                    foreach (Casa casa in lista_casa)
                    {
                        if (casa.IdCasa == casa_id)
                        {
                            foreach (Cliente cliente in lista_cliente)
                            {
                                if (cliente.IdCliente == casa.ClienteIdCliente)
                                {
                                    SaveFileDialog  textDialog = new SaveFileDialog();
                                    textDialog.Filter = "Text Files | *.txt";
                                    textDialog.DefaultExt = "txt";
                                    textDialog.Title = "Invoice";
                                    if (textDialog.ShowDialog() == DialogResult.OK)
                                    {

                                        string path = textDialog.FileName;
                                        string message = "___________________________________________";
                                        message = "Protrietário :" + cliente.Nome;
                                        message += Environment.NewLine + "Nif:" + cliente.NIF;
                                        message += Environment.NewLine + "Morada:" + cliente.Morada;
                                        message += Environment.NewLine + "Contacto:" + cliente.Contacto;
                                        message += Environment.NewLine + "__________________________________";
                                        message += Environment.NewLine + "Casa :" + casa.Localidade;
                                        message += Environment.NewLine + "Morada :" + casa.Rua + " Nº" + casa.Numero + " Andar:" + casa.Andar;
                                        message += Environment.NewLine + "Area :" + casa.Area;
                                        message += Environment.NewLine + "Nº Assoalhadas :" + casa.Area;
                                        message += Environment.NewLine + "Nº Wc :" + casa.NumeroWc;
                                        message += Environment.NewLine + "Nº Pisos :" + casa.NumeroPisos;
                                        message += Environment.NewLine + "Tipo :" + casa.Tipo;
                                        message += Environment.NewLine + "__________________________________";
                                        message += Environment.NewLine + "Limpeza :" + limpeza.Data;
                                        message += Environment.NewLine + "      ______________";
                                        message += Environment.NewLine + "Serviços: ";
                                        lista_servico = (from Servico in imoDA.ServicoSet
                                                         where Servico.LimpezaIdLimpeza == limpeza.IdLimpeza
                                                         select Servico).ToList();
                                        foreach (Servico servico in lista_servico)
                                        {
                                            message += Environment.NewLine + servico.ToString(); ;
                                        }
                                        File.WriteAllText(path, message);

                                        DialogResult resulta = MessageBox.Show("Pretende Imprimir a fatura ?", "Emitir Fatura", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                        if (Convert.ToString(resulta) == "Yes")
                                        {
                                            try
                                            {
                                                 streamToPrint = new StreamReader
                                                       (path);
                                                try
                                                {
                                                    printFont = new Font("Arial", 10);
                                                    PrintDocument pd = new PrintDocument();

                                                    pd.PrintPage += new PrintPageEventHandler
                                                       (this.pd_PrintPage);
                                                    PrintDialog pdialog = new PrintDialog();
                                                    pdialog.Document = pd;
                                                    if (pdialog.ShowDialog() == DialogResult.OK)
                                                    {
                                                        pd.Print();
                                                        limpeza.Emitido_fatura = true;
                                                        groupBox1.Enabled = false;
                                                        imoDA.SaveChanges();
                                                        LerDados();
                                                        return;
                                                    }
                                                }
                                                finally
                                                {
                                                    streamToPrint.Close();
                                                }
                                            }
                                            catch (Exception ex)
                                            {
                                                MessageBox.Show(ex.Message);
                                            }
                                        }    
                                    }
                                }
                            }

                        }
                    }
                }
            }          
        }


    private void pd_PrintPage(object sender, PrintPageEventArgs ev)
    {
        float linesPerPage = 0;
        float yPos = 0;
        int count = 0;
        float leftMargin = ev.MarginBounds.Left;
        float topMargin = ev.MarginBounds.Top;
        string line = null;

        // Calculate the number of lines per page.
        linesPerPage = ev.MarginBounds.Height /
           printFont.GetHeight(ev.Graphics);

        // Print each line of the file.
        while (count < linesPerPage &&
           ((line = streamToPrint.ReadLine()) != null))
        {
            yPos = topMargin + (count *
               printFont.GetHeight(ev.Graphics));
            ev.Graphics.DrawString(line, printFont, Brushes.Black,
               leftMargin, yPos, new StringFormat());
            count++;
        }

        // If more lines exist, print another page.
        if (line != null)
            ev.HasMorePages = true;
        else
            ev.HasMorePages = false;
    }




    private void bt_inserir_Click(object sender, EventArgs e)
        {
            int index = listBox_limpezas.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("selecione uma Limpeza","Limpezas",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }else if (comboBox1.SelectedIndex==-1 || nud_quantidade.Value == 0)
            {
                MessageBox.Show("Preenche todos os campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int valor = 0;
            if (comboBox1.SelectedIndex == 0)
            {
                valor = 10;
            }else if (comboBox1.SelectedIndex == 1)
            {
                valor = 20;
            }else if (comboBox1.SelectedIndex==2)
            {
                valor = 30;
            }
            int valortotal = valor * Convert.ToInt32(nud_quantidade.Value);
            Limpeza limpeza_select = lista_limpezas[index];
            Servico novoservico = new Servico(comboBox1.SelectedItem.ToString(), valor, nud_quantidade.Value.ToString(), limpeza_select.IdLimpeza,valortotal);
            try
            {
                imoDA.ServicoSet.Add(novoservico);
                imoDA.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            LerDados();
            Listarservico(limpeza_select.IdLimpeza);
            listBox_limpezas.SelectedIndex = index;

            return;
        }
        private void bt_criar_Click(object sender, EventArgs e)
        {
            Limpeza limpeza = new Limpeza(dateTimePicker1.Value, casa_id, false);
            try
            {
                imoDA.LimpezaSet.Add(limpeza);
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
=======
﻿using System;
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
    public partial class Limpezas : Form
    {
        public Limpezas()
        {
            InitializeComponent();
        }

        private void limpezaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        private void Limpezas_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bt_inserir_Click(object sender, EventArgs e)
        {

        }
    }
}
>>>>>>> develop
