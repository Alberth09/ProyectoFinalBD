using Entidades.CampeonatoAjedrez;
using AccesoDatos.CampeonatoAjedrez;
using System.Collections.Generic;

namespace Manejadores.CampeonatoAjedrez
{
    public class ManejadorParticipante
    {
        ConexionParticipante conexion = new ConexionParticipante();
        public void GuardarParticipante(EntidadParticipante participante)
        {
            conexion.GuardarParticipante(participante);
        }
        public void ActualizarParticipante(EntidadParticipante pais)
        {
            conexion.ActualizarParticipante(pais);
        }
        public void EliminarParticipante(int participante,string campeonato)
        {
            conexion.EliminarParticipante(participante,campeonato);
        }
        public List<EntidadParticipante> LeerParticipante()
        {
            return conexion.LeerParticipante();
        }
    }
}
