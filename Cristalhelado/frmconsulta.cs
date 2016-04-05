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
    public partial class frmconsulta : Form
    {
        public frmconsulta()
        {
            InitializeComponent();
        }

        private void cmbconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            string cadena;

            if (cmbconsulta.SelectedIndex == 0)
            {
                cadena = "Select * from venta v inner join tienev t on v.id = t.id_venta";

                Datos.ObtenerTabla(cadena, dataGridView1);
            }
            else
                if (cmbconsulta.SelectedIndex == 1)
                {
                    cadena = "Select * from venta v inner join tienev t on v.id = t.id_venta where v.factura = 'si' ";
                    Datos.ObtenerTabla(cadena, dataGridView1);
                }
                else
                    if (cmbconsulta.SelectedIndex == 2)
                    {
                        lbusuario.Visible = true;
                        cmbusuario.Visible = true;
                        cadena = "Select * from venta v inner join tienev t on v.id = t.id_venta where v.id_empleado = '" + cmbusuario.Text + "' ";
                        Datos.ObtenerTabla(cadena, dataGridView1);
                    }
                    else
                        if (cmbconsulta.SelectedIndex == 3)
                        {
                            cadena = "Select * from insumo";
                            Datos.ObtenerTabla(cadena, dataGridView1);
                        }
        }//fin del boton mostrar

        private void frmconsulta_Load(object sender, EventArgs e)
        {
            string cad = "Select * From empleado";
            Datos.cargaCombo(cmbusuario, cad);

        }

    }//fin de clase
}
