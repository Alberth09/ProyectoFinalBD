using AccesoDatos.CampeonatoAjedrez;
using Entidades.CampeonatoAjedrez;
using System.Collections.Generic;

namespace Manejadores.CampeonatoAjedrez
{
    public class ManejadorHospedaje
    {
        ConexionHospedaje conexion = new ConexionHospedaje();
        public void GuardarHospedaje(EntidadHospedaje hospedaje)
        {
            conexion.GuardarHospedaje(hospedaje);
        }
        public void EliminarHospedaje(int hospedaje)
        {
            conexion.EliminarHospedaje(hospedaje);
        }
        public List<EntidadHospedaje> LeerHospedaje()
        {
            return conexion.LeerHospedaje();
        }
    }
}
