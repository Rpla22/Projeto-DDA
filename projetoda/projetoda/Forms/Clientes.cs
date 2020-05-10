using System;
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
        private Model1Container imoDA;
        private List<Cliente> lista_cliente;

        public Clientes()
        {
            
            InitializeComponent();
            imoDA = new Model1Container();
            lista_cliente = imoDA.ClienteSet.ToList();
            LerDados();
        }

        private void LerDados()
        {
            (from cliente in imoDA.ClienteSet
             orderby cliente.IdCliente
             select cliente).Load();
            clienteSetDataGridView.DataSource = imoDA.ClienteSet.Local.ToBindingList();
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(tb_nome.Text== "" || tb_nif.Text=="" || tb_morada.Text=="" || tb_contacto.Text=="")
            {
                MessageBox.Show("Todos os campos sao obrigatórios");
                return;
            }

            foreach (Cliente cliente in lista_cliente)
            {
                if(cliente.NIF == tb_nif.Text)
                {
                    DialogResult result = MessageBox.Show("Pretende alterar as informações do cliente com o NIF: " + cliente.NIF + "?", "O Cliente ja se encontra registado", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                    if (Convert.ToString(result) == "Yes")
                    {

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
        }

        private void clienteSetDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = clienteSetDataGridView.CurrentCell.RowIndex;
            
            if (index == -1)
            {
                return;
            }                       
            tb_nome.Text = lista_cliente[index].Nome;
            tb_nif.Text = lista_cliente[index].NIF;
            tb_morada.Text = lista_cliente[index].Morada;
            tb_contacto.Text = lista_cliente[index].Contacto;

            listBox1.DataSource = lista_cliente[index].Casas.ToList();
            listBox2.DataSource = lista_cliente[index].Arrendamentos.ToList();
            listBox3.DataSource = lista_cliente[index].Aquisicoes.ToList();
        }


        private void tb_nif_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void tb_contacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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
<<<<<<< HEAD

        private void Clientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            ImoDA imoda = new ImoDA();
            this.Hide();
            imoda.Show();
        }

        private void clienteSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    
=======
    }
>>>>>>> develop
}
