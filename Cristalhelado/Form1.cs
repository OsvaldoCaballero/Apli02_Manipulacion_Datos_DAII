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
            this.menuStrip1.Enabled = false;
            frmventa formuhijo = new frmventa ();
            formuhijo.FormClosing += new FormClosingEventHandler(form_FormClosing);
            formuhijo.Show();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Enabled = false;
            frmconsulta formuhijo = new frmconsulta();
            formuhijo.FormClosing += new FormClosingEventHandler(form_FormClosing);
            formuhijo.Show();
        }

        private void form_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.menuStrip1.Enabled = true;
        }

        private void compraInsumosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.menuStrip1.Enabled = false;
            frminsumos formuhijo = new frminsumos();
            formuhijo.FormClosing += new FormClosingEventHandler(form_FormClosing);
            formuhijo.Show();
        }
    }//fin de clase
}