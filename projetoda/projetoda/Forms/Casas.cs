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

        public Casas()
        {
            
            InitializeComponent();
            imoDA = new ModelImoDaContainer();
            lista_cliente = imoDA.ClienteSet.ToList();
            LerDados();
            
        }

        private void LerDados()
        {
            
            (from casas in imoDA.CasaSet
             orderby casas.IdCasa
             select casas).ToList();
            casaSetDataGridView.DataSource = imoDA.CasaSet.Local.ToBindingList();
            foreach (Cliente cliente in lista_cliente)
            {
                cb_proprietario.Items.Add(cliente.Nome + " (" + cliente.NIF + ")");
            }
            cb_tipo.Items.Add("Moradia Germinada");
            cb_tipo.Items.Add("Moradia");
            cb_tipo.Items.Add("Apartamento");
            cb_tipo.Items.Add("Barraco");
        }

        private void casaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.casaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.imo_DADataSet);

        }

        private void Casas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imo_DADataSet.CasaSet' table. You can move, or remove it, as needed.
            this.casaSetTableAdapter.Fill(this.imo_DADataSet.CasaSet);
            // TODO: This line of code loads data into the 'imo_DADataSet.CasaSet' table. You can move, or remove it, as needed.
            this.casaSetTableAdapter.Fill(this.imo_DADataSet.CasaSet);
            // TODO: This line of code loads data into the 'imo_DADataSet1.CasaSet' table. You can move, or remove it, as needed.
            this.casaSetTableAdapter.Fill(this.imo_DADataSet.CasaSet);

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Casas_FormClosed(object sender, FormClosedEventArgs e)
        {
            ImoDA imoda = new ImoDA();
            this.Hide();
            imoda.Show();
        }

        private void Casas_FormClosing(object sender, FormClosingEventArgs e)
        {
            ImoDA imoda = new ImoDA();
            this.Hide();
            imoda.Show();
        }

        private void casaSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cb_arrendavel_Click(object sender, EventArgs e)
        {

            if (groupBox2.Enabled == false)
            {
                groupBox2.Enabled = true;
            }
            else
            {
                groupBox2.Enabled = false;
            }

        }

        private void cb_vendavel_Click(object sender, EventArgs e)
        {
            if(groupBox3.Enabled == false)
            {
                groupBox3.Enabled = true;
            }
            else
            {
                groupBox3.Enabled = false;
            }
             
        }

        private void bt_limpezas_Click(object sender, EventArgs e)
        {
            Limpezas limpezas = new Limpezas();
            this.Hide();
            limpezas.Show();
        }

        private void casaSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.casaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.imo_DADataSet);

        }

        private void casaSetDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_guardar_Click(object sender, EventArgs e)
        {
            if (tb_localidade.Text == "" || tb_rua.Text == "" || tb_numero.Text == "" || tb_andar.Text == "" || nud_area.Text == "" || nud_assoalhadas.Text == "" || nud_wc.Text == "" || nud_pisos.Text == "" || cb_tipo.Text == "" || cb_proprietario.Text == "")
            {
                MessageBox.Show("Todos os campos sao obrigatórios");
                return;
            }

            if( cb_arrendavel.Checked==true && cb_vendavel.Checked == true)
            {
                MessageBox.Show("A casa nao pode ser Arrendada e Vendida ao mesmo tempo");
                return;
            }

            if (cb_arrendavel.Checked == true)
            {
                
                int index = cb_proprietario.SelectedIndex;
                Cliente cliente = lista_cliente[index];
                Casa novaCasa = new Casa(tb_localidade.Text, tb_rua.Text, tb_numero.Text, tb_andar.Text, nud_area.Text, nud_assoalhadas.Text, nud_wc.Text, nud_pisos.Text, cb_tipo.Text, cliente);
                try
                {
                    imoDA.CasaSet.Add(novaCasa);
                    imoDA.SaveChanges();
                }catch(Exception ex)
                {
                    MessageBox.Show(Convert.ToString(ex));
                }
                
            }

        }

        private void tb_numero_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_numero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tb_andar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_andar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void casaSetBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
            this.Validate();
            this.casaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.imo_DADataSet);

        }
    }
    
}
