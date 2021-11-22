using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;
using Entidades.TorneoAjedrez;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionPais
    {
        ConexionAccesoDatos conexion;
        public ConexionPais()
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
        public void GuardarPais(EntidadPais pais)
        {
            try
            {
                string consulta = string.Format("INSERT INTO pais VALUES({0},'{1}',{2},{3})", pais.IDPais, pais.Nombre, pais.NoClubes, pais.Representa);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error");
            }
        }
        public void ActualizarPais(EntidadPais pais)
        {
            try
            {
                string consulta = string.Format("UPDATE pais SET nombre='{0}',noClubes={1},representa={2} WHERE idPais={3}", pais.Nombre, pais.NoClubes, pais.Representa, pais.IDPais);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar: " + ex.Message, "Error");
            }
        }
        public void EliminarPais(int pais)
        {
            try
            {
                string consulta = string.Format("DELETE FROM pais WHERE idPais={0}", pais);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message, "Error");
            }
        }

        public List<EntidadPais> LeerPais()
        {
            var ListaResultados = new List<EntidadPais>();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string consulta = string.Format("SELECT * FROM pais");
                ds = conexion.ObtenerDatos(consulta,"pais");
                dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    var entidad = new EntidadPais
                    {
                        IDPais = int.Parse(row["idPais"].ToString()),
                        Nombre = row["nombre"].ToString(),
                        NoClubes = int.Parse(row["noClubes"].ToString()),
                        Representa = int.Parse(row["representa"].ToString())
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
