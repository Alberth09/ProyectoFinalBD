using Entidades.CampeonatoAjedrez;
using AccesoDatos.CampeonatoAjedrez;
using System.Collections.Generic;

namespace Manejadores.CampeonatoAjedrez
{
    public class ManejadorSala
    {
        ConexionSala conexion = new ConexionSala();
        public void GuardarSala(EntidadSala sala)
        {
            conexion.GuardarSala(sala);
        }
        public void ActualizarSala(EntidadSala sala)
        {
            conexion.ActualizarSala(sala);
        }
        public void EliminarSala(int sala)
        {
            conexion.EliminarSala(sala);
        }
        public List<EntidadSala> LeerSala()
        {
            return conexion.LeerSala();
        }
    }
}
