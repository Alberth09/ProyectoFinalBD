using System.Collections.Generic;
using AccesoDatos.CampeonatoAjedrez;
using Entidades.CampeonatoAjedrez;

namespace Manejadores.CampeonatoAjedrez
{
    public class ManejadorHotel
    {
        ConexionHotel conexion = new ConexionHotel();
        public void GuardarHotel(EntidadHotel hotel)
        {
            conexion.GuardarHotel(hotel);
        }
        public void ActualizarHotel(EntidadHotel hotel)
        {
            conexion.ActualizarHotel(hotel);
        }
        public void EliminarHotel(int hotel)
        {
            conexion.EliminarHotel(hotel);
        }
        public List<EntidadHotel> LeerHotel()
        {
            return conexion.LeerHotel();
        }
    }
}
