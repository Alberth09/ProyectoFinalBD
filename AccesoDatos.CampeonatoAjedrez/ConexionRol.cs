using Entidades.CampeonatoAjedrez;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionRol
    {
        ConexionAccesoDatos conexion;
        public ConexionRol()
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

        public void GuardarRol(EntidadRol rol)
        {
            try
            {
                string consulta = string.Format("INSERT INTO rol VALUES({0},'{1}',{2},{3})", rol.FkIDPartida, rol.FkJornada, rol.FkIDParticipante,rol.Color);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error");
            }
        }

        public void EliminarRol(int id,string jornada,string color)
        {
            try
            {
                string consulta = string.Format("DELETE FROM rol WHERE fkidPartida={0} AND jornada={1} AND color='{2}'",id,jornada,color);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message, "Error");
            }
        }

        public List<EntidadRol> LeerRol()
        {
            var ListaResultados = new List<EntidadRol>();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string consulta = string.Format("SELECT *, DATE_FORMAT(fkjornada,'%Y/%m/%d') as andoHorny FROM rol");
                ds = conexion.ObtenerDatos(consulta, "rol");
                dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    var entidad = new EntidadRol
                    {
                        FkIDPartida = int.Parse(row["fkIDPartida"].ToString()),
                        FkJornada = row["andoHorny"].ToString(),
                        FkIDParticipante = int.Parse(row["fkIDParticipante"].ToString()),
                        Color = row["color"].ToString()
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
