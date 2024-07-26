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
    public partial class FormMarcacoes : Form
    {
        List<Marcacao> listaMarcacoes;
        List<Cliente> listaClientes;
        List<Mecanico> listaMecanicos;
        List<Carro> listaCarros;
        public FormMarcacoes(List<Cliente> listaClientes,  List<Carro> listaCarros, List<Mecanico> listaMecanicos)
        {
            InitializeComponent();
            this.listaClientes = listaClientes;
            this.listaCarros = listaCarros;
            this.listaMecanicos = listaMecanicos;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            Marcacao novaMarc = new Marcacao();

            novaMarc.Data = textBox1.Text;

            foreach (Cliente client in listaClientes)
            {
                if (client.NomeCliente == textBox2.Text)
                {
                    novaMarc.Cliente = client;
                }
            }

            foreach (Mecanico mec in listaMecanicos)
            {
                if (mec.NomeMecanico == textBox3.Text)
                {
                    novaMarc.Mecanico = mec;
                }
            }

            foreach (Carro carro in listaCarros)
            {
                if (novaMarc.Carro.Equals(carro))
                {
                    novaMarc.Carro = carro;
                }
            }

            listaMarcacoes.Add(novaMarc);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Marcacao marcacaoAEditar = (Marcacao)listBoxMarcacoes.SelectedItem;

            foreach (Marcacao marc in listaMarcacoes)
            {
                if (marc.Equals(marcacaoAEditar))
                {
                    FormEditarMarcacao formEdMarc = new FormEditarMarcacao();
                }
            }
        }

        private void buttonRemover_Click(object sender, EventArgs e)
        {
            Marcacao marcARemover = (Marcacao)listBoxMarcacoes.SelectedItem;

            foreach(Marcacao marc in listaMarcacoes)
            {
                if(marc.Equals(marcARemover))
                {
                    listaMarcacoes.Remove(marc);
                    listBoxMarcacoes.Items.Remove(marc);
                }
            }

        }
    }
}
