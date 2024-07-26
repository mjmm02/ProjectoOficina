using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectoOficina
{
    public partial class FormEditarCliente : Form
    {

        Cliente cliente;
        public FormEditarCliente(Cliente cliente)
        {
            this.cliente = cliente;
            InitializeComponent();
            textBoxNome.Text = cliente.NomeCliente.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            cliente.NomeCliente = textBoxNvNome.Text;

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxNvNome.Clear();
        }

        private void textBoxNvNome_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
