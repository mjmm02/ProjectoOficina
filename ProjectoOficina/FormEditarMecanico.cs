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
    public partial class FormEditarMecanico : Form
    {
        List<Mecanico> listaMecanicos;
        FormMecanico frmMec;
        Mecanico mec;
        public FormEditarMecanico(FormMecanico frmMec, List<Mecanico> listaMecanicos, Mecanico mec)
        {
            InitializeComponent();
            this.frmMec = frmMec;
            this.mec = mec;
            this.listaMecanicos = listaMecanicos;
            labelNomeMc.Text = mec.NomeMecanico;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            foreach (Mecanico mc in listaMecanicos)
            {
                if (mc.NomeMecanico.Equals(mec.NomeMecanico))
                {
                    mec.NomeMecanico = textBox1.Text;
                }
            }

            frmMec.ActualizarLista();

            this.Close();

        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
