using Entidades.CampeonatoAjedrez;
using AccesoDatos.CampeonatoAjedrez;
using System.Collections.Generic;

namespace Manejadores.CampeonatoAjedrez
{
    public class ManejadorMovimiento
    {
        ConexionMovimiento conexion = new ConexionMovimiento();
        public void GuardarMovimiento(EntidadMovimiento movimiento)
        {
            conexion.GuardarMovimiento(movimiento);
        }
        public void ActualizarMovimiento(EntidadMovimiento movimiento)
        {
            conexion.ActualizarMovimiento(movimiento);
        }
        public void EliminarMovimiento(int movimiento)
        {
            conexion.EliminarMovimiento(movimiento);
        }
        public List<EntidadMovimiento> LeerMovimiento()
        {
            return conexion.LeerMovimiento();
        }
    }
}
