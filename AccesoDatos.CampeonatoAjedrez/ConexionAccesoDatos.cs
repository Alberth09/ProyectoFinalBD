using MySqlConnector;
using System.Data;
using System;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionAccesoDatos
    {
        private MySqlConnection conn;

        public ConexionAccesoDatos(string server, string user, string password, string database, uint port)
        {
            MySqlConnectionStringBuilder cadenaConexion = new MySqlConnectionStringBuilder();
            cadenaConexion.Server = server;
            cadenaConexion.UserID = user;
            cadenaConexion.Password = password;
            cadenaConexion.Database = database;
            cadenaConexion.Port = port;

            conn = new MySqlConnection(cadenaConexion.ToString());
        }

        public void EjecutarConsulta(string consulta)
        {
            try
            {
                conn.Open();

                var command = new MySqlCommand(consulta, conn);
                command.ExecuteNonQuery();

                conn.Close();
            }
            catch (Exception)
            {
                if (conn != null && conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
                
            }
        }
        public DataSet ObtenerDatos(string consulta, string tabla)
        {
            var ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter(consulta, conn);
            da.Fill(ds, tabla);
            return ds;
        }
    }
}
