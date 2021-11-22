using Entidades.CampeonatoAjedrez;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionMovimiento
    {
        ConexionAccesoDatos conexion;
        public ConexionMovimiento()
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
        public void GuardarMovimiento(EntidadMovimiento movimiento)
        {
            try
            {
                string consulta = string.Format("INSERT INTO movimiento VALUES({0},{1},'{2}','{3}','{4}')",movimiento.IDMovimiento,movimiento.FkIDPartida,movimiento.Movimiento,movimiento.Jugada,movimiento.Comentario);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error");
            }
        }
        public void ActualizarMovimiento(EntidadMovimiento movimiento)
        {
            try
            {
                string consulta = string.Format("UPDATE movimiento SET fkIDPartida={0},movimiento='{1}',jugada='{2}',comentario='{3}' WHERE idMovimiento={4}",movimiento.FkIDPartida,movimiento.Movimiento,movimiento.Jugada,movimiento.Comentario,movimiento.IDMovimiento);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar: " + ex.Message, "Error");
            }
        }
        public void EliminarMovimiento(int movimiento)
        {
            try
            {
                string consulta = string.Format("DELETE FROM movimiento WHERE idMovimiento={0}", movimiento);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message, "Error");
            }
        }

        public List<EntidadMovimiento> LeerMovimiento()
        {
            var ListaResultados = new List<EntidadMovimiento>();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string consulta = string.Format("SELECT * FROM movimiento");
                ds = conexion.ObtenerDatos(consulta, "movimiento");
                dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    var entidad = new EntidadMovimiento
                    {
                        IDMovimiento = int.Parse(row["idMovimiento"].ToString()),
                        FkIDPartida = int.Parse(row["fkIDPartida"].ToString()),
                        Movimiento = row["movimiento"].ToString(),
                        Jugada = row["jugada"].ToString(),
                        Comentario = row["comentario"].ToString()
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
