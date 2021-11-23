using Entidades.CampeonatoAjedrez;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionPartida
    {
        ConexionAccesoDatos conexion;
        public ConexionPartida()
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
        public void GuardarPartida(EntidadPartida partida)
        {
            try
            {
                string consulta = string.Format("INSERT INTO partida VALUES({0},'{1}','{2}',{3},{4},{5})",partida.IDPartida,partida.CodigoPartida,partida.Jornada,partida.FkIDArbitro,partida.FkIDSala,partida.Entradas);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error");
            }
        }
        public void ActualizarPartida(EntidadPartida partida)
        {
            try
            {
                string consulta = string.Format("UPDATE partida SET codigoPartida='{0}',fkIDArbitro={1},fkIDSala={2},entradas={3} WHERE idPartida={4} AND jornada='{5}'", partida.CodigoPartida,partida.FkIDArbitro,partida.FkIDSala,partida.Entradas,partida.IDPartida, partida.Jornada);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar: " + ex.Message, "Error");
            }
        }
        public void EliminarPartida(int partida,string jornada)
        {
            try
            {
                string consulta = string.Format("DELETE FROM partida WHERE idPartida={0} AND jornada='{1}'", partida,jornada);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message, "Error");
            }
        }

        public List<EntidadPartida> LeerPartida()
        {
            var ListaResultados = new List<EntidadPartida>();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string consulta = string.Format("SELECT *, DATE_FORMAT(jornada,'%Y/%m/%d') as fecha FROM partida");
                ds = conexion.ObtenerDatos(consulta, "partida");
                dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    var entidad = new EntidadPartida
                    {
                        IDPartida = int.Parse(row["idPartida"].ToString()),
                        CodigoPartida = row["codigoPartida"].ToString(),
                        Jornada = (row["fecha"].ToString()),
                        FkIDArbitro = int.Parse(row["fkIDArbitro"].ToString()),
                        FkIDSala = int.Parse(row["fkIDSala"].ToString())
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
