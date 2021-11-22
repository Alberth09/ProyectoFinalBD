using Entidades.TorneoAjedrez;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionHotel
    {
        ConexionAccesoDatos conexion;
        public ConexionHotel()
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
        public void GuardarHotel(EntidadHotel hotel)
        {
            try
            {
                string consulta = string.Format("INSERT INTO hotel VALUES({0},'{1}','{2}','{3}')", hotel.IDHotel,hotel.Nombre,hotel.Direccion,hotel.Telefono);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error");
            }
        }
        public void ActualizarHotel(EntidadHotel hotel)
        {
            try
            {
                string consulta = string.Format("UPDATE hotel SET nombre='{0}',direccion='{1}',telefono='{2}' WHERE idHotel={3}", hotel.Nombre, hotel.Direccion, hotel.Telefono, hotel.IDHotel);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar: " + ex.Message, "Error");
            }
        }
        public void EliminarHotel(int hotel)
        {
            try
            {
                string consulta = string.Format("DELETE FROM hotel WHERE idHotel={0}", hotel);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message, "Error");
            }
        }

        public List<EntidadHotel> LeerHotel()
        {
            var ListaResultados = new List<EntidadHotel>();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string consulta = string.Format("SELECT * FROM hotel");
                ds = conexion.ObtenerDatos(consulta, "hotel");
                dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    var entidad = new EntidadHotel
                    {
                        IDHotel = int.Parse(row["idHotel"].ToString()),
                        Nombre = row["nombre"].ToString(),
                        Direccion = row["direccion"].ToString(),
                        Telefono = row["telefono"].ToString()
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
