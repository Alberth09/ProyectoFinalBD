using Entidades.CampeonatoAjedrez;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AccesoDatos.CampeonatoAjedrez
{
    public class ConexionParticipante
    {
        ConexionAccesoDatos conexion;
        public ConexionParticipante()
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
        public void GuardarParticipante(EntidadParticipante participante)
        {
            try
            {
                string consulta = string.Format("INSERT INTO participante VALUES({0},'{1}','{2}','{3}','{4}',{5},'{6}',{7})",participante.IDParticipante,participante.Nombre,participante.Direccion,participante.Telefono,participante.Campeonato,participante.Tipo,participante.Nivel,participante.FkIDPais);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo guardar: " + ex.Message, "Error");
            }
        }
        public void ActualizarParticipante(EntidadParticipante participante)
        {
            try
            {
                string consulta = string.Format("UPDATE participante SET nombre='{0}',direccion='{1}',telefono='{2}',tipo={3},nivel='{4}',fkIDPais={5} WHERE idParticipante={6} AND campeonato='{7}'", participante.Nombre, participante.Direccion, participante.Telefono,participante.Tipo,participante.Nivel,participante.FkIDPais,participante.IDParticipante, participante.Campeonato);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo actualizar: " + ex.Message, "Error");
            }
        }
        public void EliminarParticipante(int participante,string campeonato)
        {
            try
            {
                string consulta = string.Format("DELETE FROM participante WHERE idParticipante={0} AND campeonato='{1}'", participante,campeonato);
                conexion.EjecutarConsulta(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar: " + ex.Message, "Error");
            }
        }

        public List<EntidadParticipante> LeerParticipante()
        {
            var ListaResultados = new List<EntidadParticipante>();
            var ds = new DataSet();
            var dt = new DataTable();
            try
            {
                string consulta = string.Format("SELECT * FROM participante");
                ds = conexion.ObtenerDatos(consulta, "participante");
                dt = ds.Tables[0];

                foreach (DataRow row in dt.Rows)
                {
                    var entidad = new EntidadParticipante
                    {
                        IDParticipante = int.Parse(row["idParticipante"].ToString()),
                        Nombre = row["nombre"].ToString(),
                        Direccion = row["direccion"].ToString(),
                        Telefono = row["telefono"].ToString(),
                        Campeonato = row["campeonato"].ToString(),
                        Tipo = row["tipo"].ToString(),
                        Nivel = row["nivel"].ToString(),
                        FkIDPais = int.Parse(row["fkIDPais"].ToString())
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
