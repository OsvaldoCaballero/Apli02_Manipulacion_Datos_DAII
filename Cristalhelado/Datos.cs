using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;

namespace Cristalhelado
{
    static class Datos
    {
        private static MySqlConnection conectar;
        private static MySqlDataReader dr;
        public static double totalventa;

        static Datos()
        {
            //conectar = new MySqlConnection("Server=localhost;Database=c+ristal23;Uid=root"); //Conexión Local
            conectar = new MySqlConnection("Server=db4free.net; Database=cristalll; userid=osvaldoutp; pwd=proyectoarturo; port=3306;");
            try
            {
                conectar.Open();
                MessageBox.Show("Conectado a la base de datos remota");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos " + ex);
            }
        }

        public static void Insertar(string cadena)
        {
            MySqlCommand comando = new MySqlCommand(cadena, conectar);
            comando.ExecuteNonQuery();
        }

        public static void Update(string consulta)
        {
            MySqlCommand comando = new MySqlCommand(consulta, conectar);
            comando.ExecuteNonQuery();
        }

        public static void BuscarDato(string busqueda, DataGridView dg)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(busqueda, conectar);
            da.Fill(tabla);
            dg.DataSource = tabla;
        }

        public static void ObtenerTabla(string consulta, DataGridView dg)
        {
            try
            {
                DataTable tabla = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(consulta, conectar);
                da.Fill(tabla);
                dg.DataSource = tabla;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        public static MySqlDataAdapter construye_adapter(string cadena)
        {
            MySqlDataAdapter adapt = new MySqlDataAdapter(cadena, conectar);
            return (adapt);
        }

        public static DataRow extrae_registro(MySqlDataAdapter adapter, string tabla)
        {
            DataSet ds = new DataSet();
            DataRow fila;
            try
            {
                adapter.Fill(ds, tabla);
                DataTable miTabla = ds.Tables[tabla];

                fila = miTabla.Rows[0];
                return (fila);
            }

            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
                return (null);
            }
        }

        public static void cargaCombo(ComboBox cmb, string cadena)
        {
            cmb.Items.Clear();
            MySqlDataReader lector;
            
            lector = construye_reader(cadena);
           
            while (lector.Read())
            {
                cmb.Items.Add(lector.GetString(0).ToString());
            }
            dr.Close();

        }

        public static double TotalPagar(int cantidad, string color, int id)
        {
            string com;
            string com1;
            string com2;
            double total = 0;
            double iva = 0;
            double totalidad = 0;
            double pregan;
            double presfe;
            double precar;

            com = " Select * From insumo where nombre = '" + color + "'";
            com1 = " Select * From insumo where nombre = 'gancho' ";
            com2 = " Select * From insumo where nombre = 'carton' ";

            if (id == 1)
            {
                pregan = Convert.ToDouble(extrae(com1));
                presfe = Convert.ToDouble(extrae(com));
                total = ((presfe / 300) + (pregan / 700)) *cantidad;
                iva = total * .30;
                totalidad = total + iva;
                return totalidad;
            }
            else
                if (id == 2)
                {
                    pregan = Convert.ToDouble(extrae(com1));
                    presfe = Convert.ToDouble(extrae(com));
                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                    iva = total * .30;
                    totalidad = total + iva;
                    return totalidad;
                }
                else
                    if (id == 3)
                    {
                        pregan = Convert.ToDouble(extrae(com1));
                        presfe = Convert.ToDouble(extrae(com));
                        precar = Convert.ToDouble(extrae(com2));
                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                        iva = total * .30;
                        totalidad = total + iva;
                        return totalidad;
                    }
                    else
                        if (id == 4)
                        {
                            pregan = Convert.ToDouble(extrae(com1));
                            presfe = Convert.ToDouble(extrae(com));
                            precar = Convert.ToDouble(extrae(com2));
                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                            iva = total * .30;
                            totalidad = total + iva;
                            return totalidad;
                        }
                        else
                            if (id == 5)
                            {
                                pregan = Convert.ToDouble(extrae(com1));
                                presfe = Convert.ToDouble(extrae(com));
                                precar = Convert.ToDouble(extrae(com2));
                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                iva = total * .30;
                                totalidad = total + iva;
                                return totalidad;
                            }
                            else
                                if (id == 6)
                                {
                                    pregan = Convert.ToDouble(extrae(com1));
                                    presfe = Convert.ToDouble(extrae(com));
                                    precar = Convert.ToDouble(extrae(com2));
                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                    iva = total * .30;
                                    totalidad = total + iva;
                                    return totalidad;
                                }
                                else
                                    if (id == 7)
                                    {
                                        pregan = Convert.ToDouble(extrae(com1));
                                        presfe = Convert.ToDouble(extrae(com));
                                        precar = Convert.ToDouble(extrae(com2));
                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                        iva = total * .30;
                                        totalidad = total + iva;
                                        return totalidad;
                                    }
                                    else
                                        if (id == 8)
                                        {
                                            pregan = Convert.ToDouble(extrae(com1));
                                            presfe = Convert.ToDouble(extrae(com));
                                            precar = Convert.ToDouble(extrae(com2));
                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                            iva = total * .30;
                                            totalidad = total + iva;
                                            return totalidad;
                                        }
                                        else
                                            if (id == 9)
                                            {
                                                pregan = Convert.ToDouble(extrae(com1));
                                                presfe = Convert.ToDouble(extrae(com));
                                                total = ((presfe / 300) + (pregan / 700)) * cantidad;
                                                iva = total * .30;
                                                totalidad = total + iva;
                                                return totalidad;
                                            }
                                            else
                                                if (id == 10)
                                                {
                                                    pregan = Convert.ToDouble(extrae(com1));
                                                    presfe = Convert.ToDouble(extrae(com));
                                                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                                                    iva = total * .30;
                                                    totalidad = total + iva;
                                                    return totalidad;
                                                }
                                                else
                                                    if (id == 11)
                                                    {
                                                        pregan = Convert.ToDouble(extrae(com1));
                                                        presfe = Convert.ToDouble(extrae(com));
                                                        precar = Convert.ToDouble(extrae(com2));
                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                                                        iva = total * .30;
                                                        totalidad = total + iva;
                                                        return totalidad;
                                                    }
                                                    else
                                                        if (id == 12)
                                                        {
                                                            pregan = Convert.ToDouble(extrae(com1));
                                                            presfe = Convert.ToDouble(extrae(com));
                                                            precar = Convert.ToDouble(extrae(com2));
                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                                                            iva = total * .30;
                                                            totalidad = total + iva;
                                                            return totalidad;
                                                        }
                                                        else
                                                            if (id == 13)
                                                            {
                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                presfe = Convert.ToDouble(extrae(com));
                                                                precar = Convert.ToDouble(extrae(com2));
                                                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                iva = total * .30;
                                                                totalidad = total + iva;
                                                                return totalidad;
                                                            }
                                                            else
                                                                if (id == 14)
                                                                {
                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                    precar = Convert.ToDouble(extrae(com2));
                                                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                    iva = total * .30;
                                                                    totalidad = total + iva;
                                                                    return totalidad;
                                                                }
                                                                else
                                                                    if (id == 15)
                                                                    {
                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                        iva = total * .30;
                                                                        totalidad = total + iva;
                                                                        return totalidad;
                                                                    }
                                                                    else
                                                                        if (id == 16)
                                                                        {
                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                            iva = total * .30;
                                                                            totalidad = total + iva;
                                                                            return totalidad;
                                                                        }
                                                                            else
                                                                            if (id == 17)
                                                                            {
                                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                                presfe = Convert.ToDouble(extrae(com));
                                                                                total = ((presfe / 300) + (pregan / 700)) * cantidad;
                                                                                iva = total * .30;
                                                                                totalidad = total + iva;
                                                                                return totalidad;
                                                                            }
                                                                            else
                                                                                if (id == 18)
                                                                                {
                                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                                                                                    iva = total * .30;
                                                                                    totalidad = total + iva;
                                                                                    return totalidad;
                                                                                }
                                                                                else
                                                                                    if (id == 19)
                                                                                    {
                                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                                                                                        iva = total * .30;
                                                                                        totalidad = total + iva;
                                                                                        return totalidad;
                                                                                    }
                                                                                    else
                                                                                        if (id == 20)
                                                                                        {
                                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                                                                                            iva = total * .30;
                                                                                            totalidad = total + iva;
                                                                                            return totalidad;
                                                                                        }
                                                                                        else
                                                                                            if (id == 21)
                                                                                            {
                                                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                                                presfe = Convert.ToDouble(extrae(com));
                                                                                                precar = Convert.ToDouble(extrae(com2));
                                                                                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                                                iva = total * .30;
                                                                                                totalidad = total + iva;
                                                                                                return totalidad;
                                                                                            }
                                                                                            else
                                                                                                if (id == 22)
                                                                                                {
                                                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                                                    precar = Convert.ToDouble(extrae(com2));
                                                                                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                                                    iva = total * .30;
                                                                                                    totalidad = total + iva;
                                                                                                    return totalidad;
                                                                                                }
                                                                                                else
                                                                                                    if (id == 23)
                                                                                                    {
                                                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                                                        iva = total * .30;
                                                                                                        totalidad = total + iva;
                                                                                                        return totalidad;
                                                                                                    }
                                                                                                    else
                                                                                                        if (id == 24)
                                                                                                        {
                                                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                                                            iva = total * .30;
                                                                                                            totalidad = total + iva;
                                                                                                            return totalidad;
                                                                                                        }
            return totalidad;
        }
            
        public static double IVA(int cantidad, string color, int id)
        {
            string com;
            string com1;
            string com2;
            double total = 0;
            double iva = 0;
            double totalidad = 0;
            double pregan;
            double presfe;
            double precar;
        
            com = " Select * From insumo where nombre = '" + color + "'";
            com1 = " Select * From insumo where nombre = 'gancho' ";
            com2 = " Select * From insumo where nombre = 'carton' ";

            if (id == 1)
            {
                pregan = Convert.ToDouble(extrae(com1));
                presfe = Convert.ToDouble(extrae(com));
                total = ((presfe / 300) + (pregan / 700)) *cantidad;
                iva = total * .30;
                totalidad = total + iva;
                return iva;
            }
            else
                if (id == 2)
                {
                    pregan = Convert.ToDouble(extrae(com1));
                    presfe = Convert.ToDouble(extrae(com));
                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                    iva = total * .30;
                    totalidad = total + iva;
                    return iva;
                }
                else
                    if (id == 3)
                    {
                        pregan = Convert.ToDouble(extrae(com1));
                        presfe = Convert.ToDouble(extrae(com));
                        precar = Convert.ToDouble(extrae(com2));
                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                        iva = total * .30;
                        totalidad = total + iva;
                        return iva;
                    }
                    else
                        if (id == 4)
                        {
                            pregan = Convert.ToDouble(extrae(com1));
                            presfe = Convert.ToDouble(extrae(com));
                            precar = Convert.ToDouble(extrae(com2));
                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                            iva = total * .30;
                            totalidad = total + iva;
                            return iva;
                        }
                        else
                            if (id == 5)
                            {
                                pregan = Convert.ToDouble(extrae(com1));
                                presfe = Convert.ToDouble(extrae(com));
                                precar = Convert.ToDouble(extrae(com2));
                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                iva = total * .30;
                                totalidad = total + iva;
                                return iva;
                            }
                            else
                                if (id == 6)
                                {
                                    pregan = Convert.ToDouble(extrae(com1));
                                    presfe = Convert.ToDouble(extrae(com));
                                    precar = Convert.ToDouble(extrae(com2));
                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                    iva = total * .30;
                                    totalidad = total + iva;
                                    return iva;
                                }
                                else
                                    if (id == 7)
                                    {
                                        pregan = Convert.ToDouble(extrae(com1));
                                        presfe = Convert.ToDouble(extrae(com));
                                        precar = Convert.ToDouble(extrae(com2));
                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                        iva = total * .30;
                                        totalidad = total + iva;
                                        return iva;
                                    }
                                    else
                                        if (id == 8)
                                        {
                                            pregan = Convert.ToDouble(extrae(com1));
                                            presfe = Convert.ToDouble(extrae(com));
                                            precar = Convert.ToDouble(extrae(com2));
                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                            iva = total * .30;
                                            totalidad = total + iva;
                                            return iva;
                                        }
                                        else
                                            if (id == 9)
                                            {
                                                pregan = Convert.ToDouble(extrae(com1));
                                                presfe = Convert.ToDouble(extrae(com));
                                                total = ((presfe / 300) + (pregan / 700)) * cantidad;
                                                iva = total * .30;
                                                totalidad = total + iva;
                                                return iva;
                                            }
                                            else
                                                if (id == 10)
                                                {
                                                    pregan = Convert.ToDouble(extrae(com1));
                                                    presfe = Convert.ToDouble(extrae(com));
                                                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                                                    iva = total * .30;
                                                    totalidad = total + iva;
                                                    return iva;
                                                }
                                                else
                                                    if (id == 11)
                                                    {
                                                        pregan = Convert.ToDouble(extrae(com1));
                                                        presfe = Convert.ToDouble(extrae(com));
                                                        precar = Convert.ToDouble(extrae(com2));
                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                                                        iva = total * .30;
                                                        totalidad = total + iva;
                                                        return iva;
                                                    }
                                                    else
                                                        if (id == 12)
                                                        {
                                                            pregan = Convert.ToDouble(extrae(com1));
                                                            presfe = Convert.ToDouble(extrae(com));
                                                            precar = Convert.ToDouble(extrae(com2));
                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                                                            iva = total * .30;
                                                            totalidad = total + iva;
                                                            return iva;
                                                        }
                                                        else
                                                            if (id == 13)
                                                            {
                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                presfe = Convert.ToDouble(extrae(com));
                                                                precar = Convert.ToDouble(extrae(com2));
                                                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                iva = total * .30;
                                                                totalidad = total + iva;
                                                                return iva;
                                                            }
                                                            else
                                                                if (id == 14)
                                                                {
                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                    precar = Convert.ToDouble(extrae(com2));
                                                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                    iva = total * .30;
                                                                    totalidad = total + iva;
                                                                    return iva;
                                                                }
                                                                else
                                                                    if (id == 15)
                                                                    {
                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                        iva = total * .30;
                                                                        totalidad = total + iva;
                                                                        return iva;
                                                                    }
                                                                    else
                                                                        if (id == 16)
                                                                        {
                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                            iva = total * .30;
                                                                            totalidad = total + iva;
                                                                            return iva;
                                                                        }
                                                                            else
                                                                            if (id == 17)
                                                                            {
                                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                                presfe = Convert.ToDouble(extrae(com));
                                                                                total = ((presfe / 300) + (pregan / 700)) * cantidad;
                                                                                iva = total * .30;
                                                                                totalidad = total + iva;
                                                                                return iva;
                                                                            }
                                                                            else
                                                                                if (id == 18)
                                                                                {
                                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                                                                                    iva = total * .30;
                                                                                    totalidad = total + iva;
                                                                                    return iva;
                                                                                }
                                                                                else
                                                                                    if (id == 19)
                                                                                    {
                                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                                                                                        iva = total * .30;
                                                                                        totalidad = total + iva;
                                                                                        return iva;
                                                                                    }
                                                                                    else
                                                                                        if (id == 20)
                                                                                        {
                                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                                                                                            iva = total * .30;
                                                                                            totalidad = total + iva;
                                                                                            return iva;
                                                                                        }
                                                                                        else
                                                                                            if (id == 21)
                                                                                            {
                                                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                                                presfe = Convert.ToDouble(extrae(com));
                                                                                                precar = Convert.ToDouble(extrae(com2));
                                                                                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                                                iva = total * .30;
                                                                                                totalidad = total + iva;
                                                                                                return iva;
                                                                                            }
                                                                                            else
                                                                                                if (id == 22)
                                                                                                {
                                                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                                                    precar = Convert.ToDouble(extrae(com2));
                                                                                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                                                    iva = total * .30;
                                                                                                    totalidad = total + iva;
                                                                                                    return iva;
                                                                                                }
                                                                                                else
                                                                                                    if (id == 23)
                                                                                                    {
                                                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                                                        iva = total * .30;
                                                                                                        totalidad = total + iva;
                                                                                                        return iva;
                                                                                                    }
                                                                                                    else
                                                                                                        if (id == 24)
                                                                                                        {
                                                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                                                            iva = total * .30;
                                                                                                            totalidad = total + iva;
                                                                                                            return iva;
                                                                                                        }
            return iva;
        }
               
        public static double PRECIONORMAL(int cantidad, string color, int id)
        {
            string com;
            string com1;
            string com2;
            double total = 0;
            double iva = 0;
            double totalidad = 0;
            double pregan;
            double presfe;
            double precar;

            com = " Select * From insumo where nombre = '" + color + "'";
            com1 = " Select * From insumo where nombre = 'gancho' ";
            com2 = " Select * From insumo where nombre = 'carton' ";

            if (id == 1)
            {
                pregan = Convert.ToDouble(extrae(com1));
                presfe = Convert.ToDouble(extrae(com));
                total = ((presfe / 300) + (pregan / 700)) *cantidad;
                iva = total * .30;
                totalidad = total + iva;
                return total;
            }
            else
                if (id == 2)
                {
                    pregan = Convert.ToDouble(extrae(com1));
                    presfe = Convert.ToDouble(extrae(com));
                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                    iva = total * .30;
                    totalidad = total + iva;
                    return total;
                }
                else
                    if (id == 3)
                    {
                        pregan = Convert.ToDouble(extrae(com1));
                        presfe = Convert.ToDouble(extrae(com));
                        precar = Convert.ToDouble(extrae(com2));
                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                        iva = total * .30;
                        totalidad = total + iva;
                        return total;
                    }
                    else
                        if (id == 4)
                        {
                            pregan = Convert.ToDouble(extrae(com1));
                            presfe = Convert.ToDouble(extrae(com));
                            precar = Convert.ToDouble(extrae(com2));
                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                            iva = total * .30;
                            totalidad = total + iva;
                            return total;
                        }
                        else
                            if (id == 5)
                            {
                                pregan = Convert.ToDouble(extrae(com1));
                                presfe = Convert.ToDouble(extrae(com));
                                precar = Convert.ToDouble(extrae(com2));
                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                iva = total * .30;
                                totalidad = total + iva;
                                return total;
                            }
                            else
                                if (id == 6)
                                {
                                    pregan = Convert.ToDouble(extrae(com1));
                                    presfe = Convert.ToDouble(extrae(com));
                                    precar = Convert.ToDouble(extrae(com2));
                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                    iva = total * .30;
                                    totalidad = total + iva;
                                    return total;
                                }
                                else
                                    if (id == 7)
                                    {
                                        pregan = Convert.ToDouble(extrae(com1));
                                        presfe = Convert.ToDouble(extrae(com));
                                        precar = Convert.ToDouble(extrae(com2));
                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                        iva = total * .30;
                                        totalidad = total + iva;
                                        return total;
                                    }
                                    else
                                        if (id == 8)
                                        {
                                            pregan = Convert.ToDouble(extrae(com1));
                                            presfe = Convert.ToDouble(extrae(com));
                                            precar = Convert.ToDouble(extrae(com2));
                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                            iva = total * .30;
                                            totalidad = total + iva;
                                            return total;
                                        }
                                        else
                                            if (id == 9)
                                            {
                                                pregan = Convert.ToDouble(extrae(com1));
                                                presfe = Convert.ToDouble(extrae(com));
                                                total = ((presfe / 300) + (pregan / 700)) * cantidad;
                                                iva = total * .30;
                                                totalidad = total + iva;
                                                return total;
                                            }
                                            else
                                                if (id == 10)
                                                {
                                                    pregan = Convert.ToDouble(extrae(com1));
                                                    presfe = Convert.ToDouble(extrae(com));
                                                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                                                    iva = total * .30;
                                                    totalidad = total + iva;
                                                    return total;
                                                }
                                                else
                                                    if (id == 11)
                                                    {
                                                        pregan = Convert.ToDouble(extrae(com1));
                                                        presfe = Convert.ToDouble(extrae(com));
                                                        precar = Convert.ToDouble(extrae(com2));
                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                                                        iva = total * .30;
                                                        totalidad = total + iva;
                                                        return total;
                                                    }
                                                    else
                                                        if (id == 12)
                                                        {
                                                            pregan = Convert.ToDouble(extrae(com1));
                                                            presfe = Convert.ToDouble(extrae(com));
                                                            precar = Convert.ToDouble(extrae(com2));
                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                                                            iva = total * .30;
                                                            totalidad = total + iva;
                                                            return total;
                                                        }
                                                        else
                                                            if (id == 13)
                                                            {
                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                presfe = Convert.ToDouble(extrae(com));
                                                                precar = Convert.ToDouble(extrae(com2));
                                                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                iva = total * .30;
                                                                totalidad = total + iva;
                                                                return total;
                                                            }
                                                            else
                                                                if (id == 14)
                                                                {
                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                    precar = Convert.ToDouble(extrae(com2));
                                                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                    iva = total * .30;
                                                                    totalidad = total + iva;
                                                                    return total;
                                                                }
                                                                else
                                                                    if (id == 15)
                                                                    {
                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                        iva = total * .30;
                                                                        totalidad = total + iva;
                                                                        return total;
                                                                    }
                                                                    else
                                                                        if (id == 16)
                                                                        {
                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                            iva = total * .30;
                                                                            totalidad = total + iva;
                                                                            return total;
                                                                        }
                                                                            else
                                                                            if (id == 17)
                                                                            {
                                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                                presfe = Convert.ToDouble(extrae(com));
                                                                                total = ((presfe / 300) + (pregan / 700)) * cantidad;
                                                                                iva = total * .30;
                                                                                totalidad = total + iva;
                                                                                return total;
                                                                            }
                                                                            else
                                                                                if (id == 18)
                                                                                {
                                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                                    total = ((presfe / 255) + (pregan / 700)) * cantidad;
                                                                                    iva = total * .30;
                                                                                    totalidad = total + iva;
                                                                                    return total;
                                                                                }
                                                                                else
                                                                                    if (id == 19)
                                                                                    {
                                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 30)) * cantidad;
                                                                                        iva = total * .30;
                                                                                        totalidad = total + iva;
                                                                                        return total;
                                                                                    }
                                                                                    else
                                                                                        if (id == 20)
                                                                                        {
                                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 30)) * cantidad;
                                                                                            iva = total * .30;
                                                                                            totalidad = total + iva;
                                                                                            return total;
                                                                                        }
                                                                                        else
                                                                                            if (id == 21)
                                                                                            {
                                                                                                pregan = Convert.ToDouble(extrae(com1));
                                                                                                presfe = Convert.ToDouble(extrae(com));
                                                                                                precar = Convert.ToDouble(extrae(com2));
                                                                                                total = ((presfe / 300) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                                                iva = total * .30;
                                                                                                totalidad = total + iva;
                                                                                                return total;
                                                                                            }
                                                                                            else
                                                                                                if (id == 22)
                                                                                                {
                                                                                                    pregan = Convert.ToDouble(extrae(com1));
                                                                                                    presfe = Convert.ToDouble(extrae(com));
                                                                                                    precar = Convert.ToDouble(extrae(com2));
                                                                                                    total = ((presfe / 255) + (pregan / 700) + (precar / 20)) * cantidad;
                                                                                                    iva = total * .30;
                                                                                                    totalidad = total + iva;
                                                                                                    return total;
                                                                                                }
                                                                                                else
                                                                                                    if (id == 23)
                                                                                                    {
                                                                                                        pregan = Convert.ToDouble(extrae(com1));
                                                                                                        presfe = Convert.ToDouble(extrae(com));
                                                                                                        precar = Convert.ToDouble(extrae(com2));
                                                                                                        total = ((presfe / 300) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                                                        iva = total * .30;
                                                                                                        totalidad = total + iva;
                                                                                                        return total;
                                                                                                    }
                                                                                                    else
                                                                                                        if (id == 24)
                                                                                                        {
                                                                                                            pregan = Convert.ToDouble(extrae(com1));
                                                                                                            presfe = Convert.ToDouble(extrae(com));
                                                                                                            precar = Convert.ToDouble(extrae(com2));
                                                                                                            total = ((presfe / 255) + (pregan / 700) + (precar / 15)) * cantidad;
                                                                                                            iva = total * .30;
                                                                                                            totalidad = total + iva;
                                                                                                            return total;
                                                                                                        }
            return total;
        }
                
        public static string extrae(string cadena)
        {
            MySqlDataAdapter da = construye_adapter(cadena);

            DataRow dt = extrae_registro(da, "insumo");
            string idv1 = "";

            if (dt != null)
            {
                idv1 = dt["precio"].ToString();
            }
            return idv1;
        }

        public static MySqlDataReader construye_reader(string cadena)
        {
            MySqlCommand cadena_sql;

            cadena_sql = new MySqlCommand();
            cadena_sql.Connection = conectar;
            cadena_sql.CommandText = cadena;
            cadena_sql.CommandType = CommandType.Text;

            try
            {
                dr = cadena_sql.ExecuteReader();
                return dr;
            }
            catch (Exception oEx)
            {
                MessageBox.Show(oEx.Message);
                return null;
            }
        }
    }//fin de clase
}//fin de namespace