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
    public partial class frminsumos : Form
    {
        public frminsumos()
        {
            InitializeComponent();
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            if (txtnombre.Text != "" && txtprecio.Text != "" && txtcantidad.Text != "")
            {
                string cadena = "";
                
                if (MessageBox.Show("Deseas agregar un nuevo registro", "Cristal Helado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    try
                    {
                        cadena = "INSERT INTO insumo (nombre, fecha, precio, cantidad) values ('" + txtnombre.Text +
                            "', '" + dtpfechainsu.Text + "', '" + txtprecio.Text + "', '" + txtcantidad.Text + "')";

                        //cadena2 = "Insert into user values ('" + Convert.ToInt32(txtidusuario.Text) + "', '" + txtuser.Text + "', MD5('" + txtpassword.Text + "'))";

                        Datos.Insertar(cadena);
                        MessageBox.Show("Registro agregado");
                        txtnombre.Clear();
                        txtprecio.Clear();
                        txtcantidad.Clear();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al insertar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes llenar todos los campos");
            }


        }
    }//fin de clase
}
