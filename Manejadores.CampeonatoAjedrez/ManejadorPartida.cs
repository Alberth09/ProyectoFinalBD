using AccesoDatos.CampeonatoAjedrez;
using Entidades.CampeonatoAjedrez;
using System.Collections.Generic;

namespace Manejadores.CampeonatoAjedrez
{
    public class ManejadorPartida
    {
        ConexionPartida conexion = new ConexionPartida();
        public void GuardarPartida(EntidadPartida partida)
        {
            conexion.GuardarPartida(partida);
        }
        public void ActualizarPartida(EntidadPartida partida)
        {
            conexion.ActualizarPartida(partida);
        }
        public void EliminarPartida(int partida,string jornada)
        {
            conexion.EliminarPartida(partida,jornada);
        }
        public List<EntidadPartida> LeerPartida()
        {
            return conexion.LeerPartida();
        }

    }
}
