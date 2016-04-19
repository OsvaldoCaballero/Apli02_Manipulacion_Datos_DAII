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
        int id1;
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
                cadena = "Select v.id, v.fecha, v.id_empleado, v.factura, v.total From venta v ";

                Datos.ObtenerTabla(cadena, dataGridView1);
                cmbusuario.Visible = false;
            }
            else
                if (cmbconsulta.SelectedIndex == 1)
                {
                    cadena = "Select * from venta v inner join tienev t on v.id = t.id_venta where v.factura = 'si' ";
                    Datos.ObtenerTabla(cadena, dataGridView1);
                    cmbusuario.Visible = false;
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
                            cmbusuario.Visible = false;
                        }
        }//fin del boton mostrar

        private void frmconsulta_Load(object sender, EventArgs e)
        {   
            string cad = "Select * From empleado";
            Datos.cargaCombo(cmbusuario, cad);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cadena3 = "";
            try
            {

                id1 = Convert.ToInt32(dataGridView1[0, e.RowIndex].Value);
                //label8.Text = id1.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecciona un registro valido");
            }

            try
            {
                cadena3 = "Select tv.id_venta, tv.id_prod, p.tipo, tv.cantidad, tv.precio_tot From tienev tv inner join producto p on tv.id_prod = p.id where id_venta = '" + id1 + "'";

                Datos.ObtenerTabla(cadena3, dataGridView2);
            }
            catch (Exception)
            {
                MessageBox.Show("no se puede mostrar");
            }
        }

    }//fin de clase
}
