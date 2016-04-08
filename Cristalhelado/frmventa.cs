using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using MySql.Data.MySqlClient;

namespace Cristalhelado
{
    public partial class frmventa : Form
    {
        Queue producto = new Queue();
        Queue cantidad = new Queue();

        private double acumuladorTotal = 0.0;

        int idv;
        string idv1;

        public frmventa()
        {
            InitializeComponent();
        }

        private void frmventa_Load(object sender, EventArgs e)
        {
            string cad = "Select * From empleado";
            Datos.cargaCombo(cmbempleado, cad);

            string cad1 = "Select * From producto";
            Datos.cargaCombo(cmbproducto, cad1);

            MySqlDataAdapter da = Datos.construye_adapter("SELECT MAX(id) AS id FROM venta");

            DataRow dt = Datos.extrae_registro(da, "venta");

            if (dt != null)
            {
                idv1= dt["id"].ToString();
            }

            idv = Convert.ToInt32(idv1) + 1;
            MessageBox.Show("Número de venta  "+idv.ToString());
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            double total = Datos.TotalPagar(Convert.ToInt32(txtcantidad.Text), cmbcolor.Text, Convert.ToInt32(cmbproducto.Text));
            acumuladorTotal += total;
            lbprecio.Text = total.ToString();
            lblMontoTotal.Text = acumuladorTotal.ToString();
            try 
            {
                producto.Enqueue(cmbproducto.Text);
                cantidad.Enqueue(txtcantidad.Text);
                lstproductos.Items.Add("  " + cmbproducto.Text.ToString() + "                         " + txtcantidad.Text.ToString() + "           " + lbventa.Text + "       " + cmbcolor.Text.ToString() + "         " + total.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Error intenta de nuevo");
            }
            //txtcantidad.Clear();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (cmbempleado.SelectedIndex != -1 && cmbfactura.SelectedIndex != -1)
            {
                string cadena = "";
                string cadena2 = "";

                if (MessageBox.Show("¿Deseas agregar un nuevo registro?", "Cristal Helado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    try
                    {
                        cadena = "INSERT INTO venta (fecha, id_empleado, factura) values ('" + dtpfechav.Text +
                            "', '" + cmbempleado.Text + "', '" + cmbfactura.Text + "')";

                        Datos.Insertar(cadena);
                        MessageBox.Show("Registro agregado");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar");
                    }

                    try
                    {
                        int tot = producto.Count;

                        for (int x = 0; x < tot; x++)
                        {
                            cadena2 = " Insert into tienev values ('" + producto.Dequeue().ToString() + "', '"+idv+"', '" + cantidad.Dequeue().ToString() + "')";
                            Datos.Insertar(cadena2);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar productos");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos");
            }
        }

        private void cmbproducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter da = Datos.construye_adapter("select * from producto where id ='" + cmbproducto.Text + "'");

            DataRow dt = Datos.extrae_registro(da, "producto");

            if (dt != null)
            {
                lbventa.Text = dt["tipo"].ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FACTURA fact = new FACTURA();
            fact.lblEmpleado.Text = cmbempleado.Text;
            fact.lblFecha.Text = dtpfechav.Text;
            fact.lblTOTALPAGAR.Text = lblMontoTotal.Text;
            fact.lbNombreEmpleado.Text = lbNombre.Text;

            for (int i = 0; i <= lstproductos.Items.Count -1; i++)
            {
                fact.listBox1.Items.Insert(i, lstproductos.Items[i]);
            }
                
                fact.ShowDialog();
            
        }

        private void cmbempleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            MySqlDataAdapter de = Datos.construye_adapter("select * from empleado where id ='" + cmbempleado.Text + "'");
            DataRow dte = Datos.extrae_registro(de, "empleado");

            if (dte != null)
            {
                lbNombre.Text = dte["nombre"].ToString();
            }
        }
    }//fin de clase
}