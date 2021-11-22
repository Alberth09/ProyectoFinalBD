using Entidades.TorneoAjedrez;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionHospedaje
    {
        ConexionAccesoDatos conexion;
        public ConexionHospedaje()
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
        public void GuardarHospedaje(EntidadHospedaje hospedaje)
        {
            try
            {
                string consulta = string.Format("INSERT INTO hospedaje VALUES({0},{1},{2},'{3}','{4}')",hospedaje.IDHospedaje,hospedaje.FkIDParticipante,hospedaje.FkIDHotel,hospedaje.FechaEntrada,hospedaje.FechaSalida);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error");
            }
        }
        public void ActualizarHospedaje(EntidadHospedaje hospedaje)
        {
            try
            {
                string consulta = string.Format("UPDATE hospedaje SET fkIDParticipante={0},fkIDHotel={1},fechaEntrada='{2}',fechaSalida='{3}' WHERE idHospedaje={4}", hospedaje.FkIDParticipante, hospedaje.FkIDHotel, hospedaje.FechaEntrada,hospedaje.FechaSalida,hospedaje.IDHospedaje);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar: " + ex.Message, "Error");
            }
        }
        public void EliminarHospedaje(int hospedaje)
        {
            try
            {
                string consulta = string.Format("DELETE FROM hospedaje WHERE idHospedaje={0}", hospedaje);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message, "Error");
            }
        }

        public List<EntidadHospedaje> LeerHospedaje()
        {
            var ListaResultados = new List<EntidadHospedaje>();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string consulta = string.Format("SELECT * FROM hospedaje");
                ds = conexion.ObtenerDatos(consulta, "hospedaje");
                dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    var entidad = new EntidadHospedaje
                    {
                        IDHospedaje = int.Parse(row["idHospedaje"].ToString()),
                        FkIDParticipante = int.Parse(row["fkIDParticipante"].ToString()),
                        FkIDHotel = int.Parse(row["fkIDHotel"].ToString()),
                        FechaEntrada = row["fechaEntrada"].ToString(),
                        FechaSalida = row["fechaSalida"].ToString()
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
