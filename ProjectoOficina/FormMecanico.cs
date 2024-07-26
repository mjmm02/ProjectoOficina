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
    public partial class FormMecanico : Form
    {

        List<Mecanico> listaMecanicos;
        public FormMecanico()
        {
            InitializeComponent();
            listaMecanicos = new List<Mecanico>();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nomeSelec = listBox1.SelectedItem.ToString();

            if (nomeSelec != null)
            {
                foreach (Mecanico mc in listaMecanicos)
                {
                    if (mc.NomeMecanico.Equals(nomeSelec))
                    {
                        FormEditarMecanico editarMec = new FormEditarMecanico(this, listaMecanicos, mc);

                        editarMec.Visible = true;

                        ActualizarLista();
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha um nome para editar!!", "Erro", MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }

            
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            string nomeMecSlect = listBox1.SelectedItem.ToString();

            if(nomeMecSlect != null)
            {
                foreach (Mecanico mec in listaMecanicos.ToList())
                {
                    if (mec.NomeMecanico == nomeMecSlect)
                    {
                        listaMecanicos.Remove(mec);
                        listBox1.Items.Remove(listBox1.SelectedItem);
                    }
                }
            }
            else
            {
                MessageBox.Show("Escolha um nome da lista para apagar!!", "Erro", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            

        }

        public void ActualizarLista()
        {
            listBox1.Items.Clear();

            foreach (Mecanico mc in listaMecanicos)
            {
                listBox1.Items.Add(mc.NomeMecanico);
            }
        }

        private void buttonCriarMec_Click(object sender, EventArgs e)
        {
            if(textBoxNomeMec.Text != "")
            {
                Mecanico novoMec = new Mecanico();

                novoMec.NomeMecanico = textBoxNomeMec.Text;
                listaMecanicos.Add(novoMec);

                listBox1.Items.Add(novoMec.NomeMecanico);

                textBoxNomeMec.Clear();

                //ActualizarLista();
            }
            else
            {
               MessageBox.Show("Insira um nome!!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            textBoxNomeMec.Text = "";
        }
    }
}
