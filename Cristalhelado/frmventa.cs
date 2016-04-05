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
            //dataGridView2.DataSource = dt;

            if (dt != null)
            {
                idv1= dt["id"].ToString();
                /*txtnombre.Text = dt["nombre"].ToString();
                txtapp.Text = dt["Ap_paterno"].ToString();
                txtapm.Text = dt["Ap_materno"].ToString();
                txttelefono.Text = dt["celular"].ToString();*/
            }

            
            idv = Convert.ToInt32(idv1) + 1;
            MessageBox.Show(idv.ToString());
        }

        private void btnproducto_Click(object sender, EventArgs e)
        {
            
            try
            {

                producto.Enqueue(cmbproducto.Text);
                cantidad.Enqueue(txtcantidad.Text);

                lstproductos.Items.Add(cmbproducto.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Error intenta de nuevo");
            }

            txtcantidad.Clear();

        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (cmbempleado.SelectedIndex != -1 && cmbfactura.SelectedIndex != -1)
            {
                string cadena = "";
                string cadena2 = "";

                if (MessageBox.Show("Deseas agregar un nuevo registro", "Cristal Helado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    try
                    {
                        cadena = "INSERT INTO venta (fecha, id_empleado, factura) values ('" + dtpfechav.Text +
                            "', '" + cmbempleado.Text + "', '" + cmbfactura.Text + "')";

                        //cadena2 = "Insert into user values ('" + Convert.ToInt32(txtidusuario.Text) + "', '" + txtuser.Text + "', MD5('" + txtpassword.Text + "'))";

                        Datos.Insertar(cadena);
                        MessageBox.Show("Registro agregado");
                        //txtnombre.Clear();
                        //txtprecio.Clear();
                        //txtcantidad.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar");
                    }

                    try
                    {
                        //string bla = producto.Dequeue().ToString();
                        int tot = producto.Count;
                        /*string cade = "";

                        MessageBox.Show(tot.ToString());

                        for (int y = 0; y < tot; y++)
                        {
                            cade = cade + producto.Dequeue().ToString() + "\n";
                        }
                        MessageBox.Show(cade);*/


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
            //dataGridView2.DataSource = dt;

            if (dt != null)
            {
                //lbtam.Text = dt["tamaño"].ToString();
                lbventa.Text = dt["tipo"].ToString();
            }
        }
    }//fin de clase
}
