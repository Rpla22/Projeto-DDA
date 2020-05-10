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
        private Model1Container imoDA;
        private List<Cliente> lista_cliente;

        public Casas()
        {
            
            InitializeComponent();
            imoDA = new Model1Container();
            LerDados();
        }

        private void LerDados()
        {
            (from casas in imoDA.CasaSet
             orderby casas.IdCasa
             select casas).Load();
            casaSetDataGridView.DataSource = imoDA.ClienteSet.Local.ToBindingList();
        }

        private void casaSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.casaSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.imo_DADataSet1);

        }

        private void Casas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'imo_DADataSet1.CasaSet' table. You can move, or remove it, as needed.
            this.casaSetTableAdapter.Fill(this.imo_DADataSet1.CasaSet);

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
    }
    
}
