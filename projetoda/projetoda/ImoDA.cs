﻿using System;
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
        public ImoDA()
        {
            InitializeComponent();
        }

        private void bt_clientes_Click(object sender, EventArgs e)
        {
            Clientes clientes = new Clientes();
            this.Hide();
            clientes.Show();
        }

        private void bt_casas_Click(object sender, EventArgs e)
        {
            Casas casas = new Casas();
            this.Hide();
            casas.Show();
        }
    }
}
