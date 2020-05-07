using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoda
{
    public partial class ImoDA : Form
    {
        public ImoDA()
        {
            InitializeComponent();
        }

        private void ImoDA_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Casas casas = new Casas();
            this.Hide();
            casas.Show();
        }
    }
}
