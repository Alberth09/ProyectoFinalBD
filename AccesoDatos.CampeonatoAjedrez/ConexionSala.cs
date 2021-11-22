using Entidades.CampeonatoAjedrez;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionSala
    {
        ConexionAccesoDatos conexion;
        public ConexionSala()
        {
            try
            {
                conexion = new ConexionAccesoDatos("localhost", "root", "", "clubAjedrez", 3306);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión: " + ex.Message, "Error.");
            }
        }
        public void GuardarSala(EntidadSala sala)
        {
            try
            {
                string consulta = string.Format("INSERT INTO sala VALUES({0},{1},'{2}',{3},'{4}')",sala.IDSala,sala.FkIDHotel,sala.CodigoSala,sala.Capacidad,sala.Medios);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error");
            }
        }
        public void ActualizarSala(EntidadSala sala)
        {
            try
            {
                string consulta = string.Format("UPDATE sala SET fkIDHotel={0},codigoSala='{1}',capacidad={2},medios='{3}' WHERE idSala={4}",sala.FkIDHotel,sala.CodigoSala,sala.Capacidad,sala.Medios,sala.IDSala);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar: " + ex.Message, "Error");
            }
        }
        public void EliminarSala(int sala)
        {
            try
            {
                string consulta = string.Format("DELETE FROM sala WHERE idSala={0}", sala);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message, "Error");
            }
        }

        public List<EntidadSala> LeerSala()
        {
            var ListaResultados = new List<EntidadSala>();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string consulta = string.Format("SELECT * FROM sala");
                ds = conexion.ObtenerDatos(consulta, "sala");
                dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    var entidad = new EntidadSala
                    {
                        IDSala = int.Parse(row["idSala"].ToString()),
                        FkIDHotel = int.Parse(row["fkIDHotel"].ToString()),
                        CodigoSala = row["codigoSala"].ToString(),
                        Capacidad = int.Parse(row["capacidad"].ToString()),
                        Medios = row["medios"].ToString()
                    };
                    ListaResultados.Add(entidad);
                }
                return ListaResultados;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo obtener los datos: " + ex.Message, "Error.");
                return ListaResultados;
            }
        }
    }
}
