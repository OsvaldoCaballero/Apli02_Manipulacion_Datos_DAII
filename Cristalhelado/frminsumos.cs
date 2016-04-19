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
            if (cmbInsumos.Text != "" && txtprecio.Text != "" && txtcantidad.Text != "")
            {
                string cadena = "";
                
                if (MessageBox.Show("Deseas agregar un nuevo registro", "Cristal Helado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    try
                    {
                        cadena = "INSERT INTO insumo (nombre, fecha, precio, cantidad) values ('" + cmbInsumos.Text +
                            "', '" + dtpfechainsu.Text + "', '" + txtprecio.Text + "', '" + txtcantidad.Text + "')";

                        Datos.Insertar(cadena);
                        MessageBox.Show("Registro agregado");
                        cmbInsumos.ResetText();
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

        private void frminsumos_Load(object sender, EventArgs e)
        {

        }

        private void btnINSUMOACTUALIZAR_Click(object sender, EventArgs e)
        {
            if (cmbInsumos.Text != "")
            {
                string cadena = "";

                if (MessageBox.Show("¿Estás seguro de querer eliminar este registro?", "Cristal Helado", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                    DialogResult.Yes)
                {
                    try
                    {
                        if (cmbInsumos.SelectedIndex == 0)
                        {
                            cadena = "DELETE FROM insumo where nombre = 'Dorada'";

                            Datos.Insertar(cadena);
                            MessageBox.Show("Eliminación exitosa");
                            cmbInsumos.ResetText();
                        }
                        else
                            if (cmbInsumos.SelectedIndex == 1)
                            {
                                cadena = "DELETE FROM insumo where nombre = 'Plateada'";

                                Datos.Insertar(cadena);
                                MessageBox.Show("Eliminación exitosa");
                                cmbInsumos.ResetText();
                            }
                            else
                                if (cmbInsumos.SelectedIndex == 2)
                                {
                                    cadena = "DELETE FROM insumo where nombre = 'Roja'";

                                    Datos.Insertar(cadena);
                                    MessageBox.Show("Eliminación exitosa");
                                    cmbInsumos.ResetText();
                                }
                                else
                                    if (cmbInsumos.SelectedIndex == 3)
                                    {
                                        cadena = "DELETE FROM insumo where nombre = 'Gancho'";

                                        Datos.Insertar(cadena);
                                        MessageBox.Show("Eliminación exitosa");
                                        cmbInsumos.ResetText();
                                    }
                                    else
                                        if (cmbInsumos.SelectedIndex == 4)
                                        {
                                            cadena = "DELETE FROM insumo where nombre = 'Cartón'";

                                            Datos.Insertar(cadena);
                                            MessageBox.Show("Eliminación exitosa");
                                            cmbInsumos.ResetText();
                                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al eliminar el registro");
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