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
        public static string user;
        public static string pass;

        static Datos()
        {
            //conectar = new MySqlConnection("Server=localhost;Database=cristal;Uid=root"); //Conexión Local
            conectar = new MySqlConnection("Server=db4free.net; Database=cristall; userid=osvaldo; pwd=proyectofinal; port=3306;");
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

        public static bool Login(string nombre, string password)
        {
            string consulta = "SELECT count(*) FROM user WHERE user = @Nombre AND password = MD5(@Password)";
            MySqlCommand comando = new MySqlCommand(consulta, conectar);
            comando.Parameters.Add("@Nombre", MySqlDbType.VarChar);
            comando.Parameters["@Nombre"].Value = nombre;
            comando.Parameters.Add("@Password", MySqlDbType.VarChar);
            comando.Parameters["@Password"].Value = password;
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            if (resultado == 1)
                return true;
            else
                return false;
        }

        public static string Privilegios()
        {
            string consulta = "SELECT us.tipo FROM user u inner join usuario us on u.id_usuario = us.id_usuario WHERE u.user = '" + user + "' AND u.password = MD5('" + pass + "')";
            MySqlCommand comando = new MySqlCommand(consulta, conectar);
            string resp = comando.ExecuteScalar().ToString();
            return resp;
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

        public static void Delete(string consulta)
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

        public static bool Validar(int id, string password)
        {
            string consulta = "SELECT count(*) FROM user WHERE id_usuario = @Id AND password = MD5(@Password)";
            MySqlCommand comando = new MySqlCommand(consulta, conectar);
            comando.Parameters.Add("@Id", MySqlDbType.Int32);
            comando.Parameters["@Id"].Value = id;
            comando.Parameters.Add("@Password", MySqlDbType.VarChar);
            comando.Parameters["@Password"].Value = password;
            int resultado = Convert.ToInt32(comando.ExecuteScalar());

            if (resultado == 1)
                return true;
            else
                return false;
        }

        public static void ObtenerTabla(string consulta, DataGridView dg)
        {
            DataTable tabla = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conectar);
            da.Fill(tabla);
            dg.DataSource = tabla;
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
