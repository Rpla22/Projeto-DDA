using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoDA;
using System.Data.Entity;
using ProjetoDA.Models;

namespace ProjetoDA.Forms
{
    public partial class Casas : Form
    {
        private ModelImoDaContainer imoDA;
        private List<Cliente> lista_cliente;
        private List<Casa> lista_casa;
        private int casa_id = 0;

        public Casas(int id_casa)
        {
            
            InitializeComponent();
            imoDA = new ModelImoDaContainer();
            lista_cliente = imoDA.ClienteSet.ToList();
            LerDados_cliente();
            LerDados();
            casa_id = id_casa;
 }
        private void LerDados_cliente()
        {
            foreach (Cliente cliente in lista_cliente)
            {
                cb_proprietario.Items.Add(cliente.Nome + " (" + cliente.NIF + ")");
            }
        }

        private void LerDados()
        {
            imoDA.Dispose();
            imoDA = new ModelImoDaContainer();
            (from casas in imoDA.CasaSet
             orderby casas.IdCasa
             select casas).ToList();
            casaSetDataGridView.DataSource = null;
            casaSetDataGridView.DataSource = imoDA.CasaSet.ToList();
            lista_casa = imoDA.CasaSet.ToList();
        }



        private void cb_arrendavel_Click(object sender, EventArgs e)
        {
            if (cb_arrendavel.Checked == true)
            {
                cb_vendavel.Checked = false;
                groupBox2.Enabled = true;
                groupBox3.Enabled = false;
            }
            else
            {
                groupBox2.Enabled = false;
            }
        }

        private void cb_vendavel_Click(object sender, EventArgs e)
        {
            if (cb_vendavel.Checked == true)
            {
                cb_arrendavel.Checked = false;
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
            }
            else
            {
                groupBox3.Enabled = false;
            }
             
        }


        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (tb_localidade.Text == "" || tb_rua.Text == "" || tb_numero.Text == "" || tb_andar.Text == "" || nud_area.Text == "" || nud_assoalhadas.Text == "" || nud_wc.Text == "" || nud_pisos.Text == "" || cb_tipo.Text == "" || cb_proprietario.Text == "")
            {
                MessageBox.Show("Todos os campos sao obrigatórios");
                return;
            }
             int index = cb_proprietario.SelectedIndex;
             Cliente cliente = lista_cliente[index];



            foreach (Casa casas in lista_casa)
            {
                if (casas.IdCasa == Convert.ToInt32(lb_id.Text))
                {
                    DialogResult result = MessageBox.Show("Pretende alterar as informações da casa com o ID: " + casas.IdCasa + "?", "A casa ja se encontra registado", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (Convert.ToString(result) == "Yes")
                    {
                        casas.Localidade = tb_localidade.Text;
                        casas.Rua = tb_rua.Text;
                        casas.Numero = tb_numero.Text;
                        casas.Andar = tb_andar.Text;
                        casas.Area = nud_area.Text;
                        casas.NumeroAssoalhadas = nud_assoalhadas.Text;
                        casas.NumeroWc = nud_wc.Text;
                        casas.NumeroPisos = nud_pisos.Text;
                        casas.Tipo = cb_tipo.Text;
                        casas.ClienteIdCliente = cliente.IdCliente;
                        if (casas is CasaVendavel)
                        {
                            CasaVendavel casavendavel = (CasaVendavel)casas;
                            casavendavel.ValorBaseVenda = tb_valor_venda.Text;
                            casavendavel.ValorComissao = tb_comissao_venda.Text;
                            
                        }
                        else if (casas is CasaArrendavel) 
                        {
                            CasaArrendavel casaArrendavel = (CasaArrendavel)casas;
                            casaArrendavel.ValorBaseMes = tb_valor_arrendamento.Text;
                            casaArrendavel.Comissao = tb_comissao_arrendamento.Text;
                        }
                            imoDA.SaveChanges();
                            LerDados();
                        casaSetDataGridView_Click(sender, e);
                        return;
                    }
                }
            }

            if ( cb_arrendavel.Checked==false && cb_vendavel.Checked == false)
            {
                Casa novaCasa = new Casa(tb_localidade.Text, tb_rua.Text, tb_numero.Text, tb_andar.Text, nud_area.Text, nud_assoalhadas.Text, nud_wc.Text, nud_pisos.Text, cb_tipo.Text, cliente.IdCliente);
                try
                {
                    imoDA.CasaSet.Add(novaCasa);
                    imoDA.SaveChanges();
                }
                catch (Exception ex)
                {
                   MessageBox.Show(Convert.ToString(ex));
                }
                LerDados();
                casaSetDataGridView_Click(sender, e);
                return;
            }
           
            if (cb_arrendavel.Checked == true)
            {
 
                CasaArrendavel novaCasa = new CasaArrendavel(tb_localidade.Text, tb_rua.Text, tb_numero.Text, tb_andar.Text, nud_area.Text, nud_assoalhadas.Text, nud_wc.Text, nud_pisos.Text, cb_tipo.Text, cliente.IdCliente,tb_valor_arrendamento.Text,tb_comissao_arrendamento.Text);
                try
                {
                    imoDA.CasaSet.Add(novaCasa);
                    imoDA.SaveChanges();
                    LerDados();
                    casaSetDataGridView_Click(sender, e);
                    return;
                }catch(Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
                
            }else if (cb_vendavel.Checked == true)
            {
                CasaVendavel novaCasa = new CasaVendavel(tb_localidade.Text, tb_rua.Text, tb_numero.Text, tb_andar.Text, nud_area.Text, nud_assoalhadas.Text, nud_wc.Text, nud_pisos.Text, cb_tipo.Text, cliente.IdCliente, tb_valor_venda.Text, tb_comissao_venda.Text);
                try
                {
                    imoDA.CasaSet.Add(novaCasa);
                    imoDA.SaveChanges();
                    LerDados();
                    casaSetDataGridView_Click(sender, e);
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
            }
            casaSetDataGridView_Click(sender, e);

        }

     
        private void tb_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

      
        private void tb_andar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        private void bt_nova_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            bt_guardar.Enabled = true;
            cb_vendavel.Enabled = true;
            cb_arrendavel.Enabled = true;
            if (lista_casa.Count==0)
            {
                lb_id.Text = "1";
            }
            else
            {
                Casa casa = lista_casa.Last();
                lb_id.Text = Convert.ToString(casa.IdCasa + 1);
            }

            tb_localidade.Text = "";
            tb_rua.Text = "";
            tb_numero.Text = "";
            tb_andar.Text = "";
            nud_area.Value = 0;
            nud_assoalhadas.Value = 0;
            nud_pisos.Value =0;
            nud_wc.Value =0;
            cb_tipo.Text = "";
            cb_proprietario.Text = "";
        } 
   

    //funçoes para espera de formulários segintes fecharem e abrir os formulários
        private void bt_arrendamento_ver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Arrendamentos arrendamentos = new Arrendamentos(0);
            arrendamentos.FormClosed += Arrendamentos_FormClosed;
            arrendamentos.Show();
        }

        private void bt_venda_ver_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendas venda = new Vendas(0);
            venda.FormClosed += Venda_FormClosed;
            venda.Show();
        }

        private void bt_limpezas_Click(object sender, EventArgs e)
        {
            int index = casaSetDataGridView.CurrentCell.RowIndex;
            if (index == -1){
                return;
            }
            Casa casa = imoDA.CasaSet.Local[index];
            this.Hide();
            Limpezas limpezas = new Limpezas(casa.IdCasa);
            limpezas.FormClosed += Limpezas_FormClosed;
            limpezas.Show();
        }

        private void Limpezas_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
            int index = casaSetDataGridView.CurrentCell.RowIndex;
            casaSetDataGridView_Click(sender, e);   
        }

        private void Venda_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void Arrendamentos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void bt_apagar_Click(object sender, EventArgs e)
        {
            int index = casaSetDataGridView.CurrentCell.RowIndex;
            if (lista_casa[index].Limpezas.ToList() != null)
            {
                MessageBox.Show("Não é possivel apagar a casa. A casa tem algo acosiado ", "Apagar Casa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            Casa casa = lista_casa[index];
            if (casa is CasaVendavel)
            {
                CasaVendavel casaVendavel = (CasaVendavel)casa;
                if (casaVendavel.Vendas.ToList() != null)
                {
                    MessageBox.Show("Não é possivel apagar a casa. A casa tem algo acosiado ", "Apagar Casa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            if (casa is CasaArrendavel)
            {
                CasaArrendavel casaArrendavel = (CasaArrendavel)casa;
                if (casaArrendavel.Arrendamento.ToList() != null)
                {
                    MessageBox.Show("Não é possivel apagar a casa. A casa tem algo acosiado ", "Apagar Casa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Pretende apagar a casa de " + lista_casa[index].Localidade + "?", "Apagar casa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (Convert.ToString(result) == "Yes")
            {
                imoDA.CasaSet.Local.Remove(lista_casa[index]);
                imoDA.SaveChanges();
                LerDados();
                casaSetDataGridView_Click(sender,e);
            }
            return;
        }

        private void casaSetDataGridView_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            bt_guardar.Enabled = true;
            groupBox2.Enabled = false;
            groupBox3.Enabled = false;
            cb_arrendavel.Enabled = false;
            cb_vendavel.Enabled = false;

            int index = casaSetDataGridView.CurrentCell.RowIndex;

            if (index == -1)
            {
                return;
            }

             Casa casa = imoDA.CasaSet.Local[index];
            // Casa casa = lista_casa.ElementAt(index);
            Valor_Limpeza(casa.IdCasa);
            if (casa is CasaVendavel)
            {
                groupBox3.Enabled = false;
                CasaVendavel casaVendavel = (CasaVendavel)casa;
                lb_id.Text = casaVendavel.IdCasa.ToString();
                cb_vendavel.Checked = true;
                cb_arrendavel.Checked = false;
                groupBox3.Enabled = true;
                groupBox2.Enabled = false;
                tb_valor_arrendamento.Text = "";
                tb_comissao_arrendamento.Text = "";
                tb_valor_venda.Text = casaVendavel.ValorBaseVenda;
                tb_comissao_venda.Text = casaVendavel.ValorComissao;
                Escreve_valores(casa);
                return;
            }
            else if (casa is CasaArrendavel)
            {
                groupBox2.Enabled = true;
                CasaArrendavel casaArrendavel = (CasaArrendavel)casa;
                lb_id.Text = casaArrendavel.IdCasa.ToString();
                cb_arrendavel.Checked = true;
                groupBox3.Enabled = false;
                groupBox2.Enabled = true;
                tb_valor_venda.Text = "";
                tb_comissao_venda.Text = "";
                tb_valor_arrendamento.Text = casaArrendavel.ValorBaseMes;
                tb_comissao_arrendamento.Text = casaArrendavel.Comissao;
                Escreve_valores(casa);
                return;
            }
            else if (casa is Casa)
            {    
                lb_id.Text = casa.IdCasa.ToString();
                cb_arrendavel.Checked = false;
                cb_vendavel.Checked = false;
                tb_valor_arrendamento.Text = "";
                tb_comissao_arrendamento.Text = "";
                tb_valor_venda.Text = "";
                tb_comissao_venda.Text = "";
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                Escreve_valores(casa);
                return;
            }

        }

        private void Escreve_valores (Casa casa)
        {
            tb_localidade.Text = casa.Localidade;
            tb_rua.Text = casa.Rua;
            tb_numero.Text = casa.Numero;
            tb_andar.Text = casa.Andar;
            nud_area.Value =Convert.ToInt32(casa.Area);
            nud_assoalhadas.Value = Convert.ToInt32(casa.NumeroAssoalhadas);
            nud_pisos.Value = Convert.ToInt32(casa.NumeroAssoalhadas);
            nud_wc.Value = Convert.ToInt32(casa.NumeroWc);
            cb_tipo.Text = casa.Tipo;
            int count = 0;
            foreach(Cliente cliente in lista_cliente)
            {
                
                if (casa.ClienteIdCliente == cliente.IdCliente)
                {
                    cb_proprietario.SelectedIndex=count;
                    return;
                }
                count++;
            }
            
        }

        private void Casas_Load(object sender, EventArgs e)
        {
            if (casa_id == 0)
            {
                return;
            }
            else
            {
                int index = 0;
                foreach (Casa casa in lista_casa)
                {
                    if (casa.IdCasa == casa_id)
                    {
                        casaSetDataGridView.Rows[index].Selected = true;
                        casaSetDataGridView_Click(sender, e);
                    }
                    index++;
                }
            }
        }
    
        private void Valor_Limpeza(int casa_id)
        {
            List<Servico> lista_servico;
            List<Limpeza> lista_limpezas;
            int total_limpeza=0;

            lista_limpezas = (from Limpeza in imoDA.LimpezaSet
                              where Limpeza.CasaIdCasa == casa_id
                              orderby Limpeza.Data
                              select Limpeza).ToList();

            foreach (Limpeza limpeza in lista_limpezas)
            {
                lista_servico = (from Servico in imoDA.ServicoSet
                                 where Servico.LimpezaIdLimpeza == limpeza.IdLimpeza
                                 select Servico).ToList();

                if (lista_servico.Count != 0)
                {
                    foreach (Servico servico in lista_servico)
                    {
                        total_limpeza = total_limpeza + servico.Valor_total;
                    }
                }   
            }
            bt_limpezas.Text = "Gerir Limpezas (Total: "+total_limpeza+")";
        }
    
    }
}
