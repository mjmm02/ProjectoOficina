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
    public partial class FormCliente : Form
    {
        List<Cliente> listClientes;
        Carro carro;
        int contLista;

        public FormCliente()
        {
            InitializeComponent();
            listClientes = new List<Cliente>();
            contLista = listClientes.Count;
        }

        private void ActualizarLista()
        {
            //listBoxClientes.Items.Clear();
            //listBoxClientes.Items. = listClientes;
            listBoxClientes.Refresh();

        }

        private void buttonCriarRegisto_Click(object sender, EventArgs e)
        {
            Cliente novoCliente;
            contLista++;

            novoCliente = new Cliente
            {
                NumCliente = contLista,
                NomeCliente = textBoxNome.Text,
            };

            listClientes.Add(novoCliente);
            listBoxClientes.Items.Add(novoCliente.NumCliente + " - " + novoCliente.NomeCliente);

            ActualizarLista();

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            listBoxClientes.Text = "";
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            string novoCliente = (string)listBoxClientes.SelectedItem;
            string[] novoCliente2 = novoCliente.Split();
            string novoClienteNome = novoCliente2[2];
            Cliente nvCliente = new Cliente();

            if(novoCliente == null)
            {
                MessageBox.Show("Escolha um cliente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach(Cliente clt in listClientes)
                {
                    if (clt.NomeCliente.Equals(novoClienteNome))
                    {
                        nvCliente = clt;
                    }
                }
                FormEditarCliente frmEdCliente = new FormEditarCliente(nvCliente);

            }

        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Cliente clienteARemover = (Cliente)listBoxClientes.SelectedItem;

            if(clienteARemover != null)
            {
                foreach (Cliente cliente in listClientes)
                {
                    if (cliente.NumCliente == clienteARemover.NumCliente)
                    {
                        listClientes.Remove(cliente);
                    }
                }
            }
            else
            {
                MessageBox.Show("Insira um nome por favor!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            

            ActualizarLista();

        }
    }
}
