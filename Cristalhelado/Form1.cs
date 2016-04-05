using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cristalhelado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MostrarFormulario(Form Formulario)
        {
            Formulario.MdiParent = this;
            Formulario.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new frmventa());
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new frmconsulta());
        }

        private void compraInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MostrarFormulario(new frminsumos());
        }
    }//fin de clase
}
