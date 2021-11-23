using System.Collections.Generic;
using AccesoDatos.CampeonatoAjedrez;
using Entidades.CampeonatoAjedrez;

namespace Manejadores.CampeonatoAjedrez
{
    public class ManejadorRol
    {
        ConexionRol conexion = new ConexionRol();
        public void GuardarRol(EntidadRol rol)
        {
            conexion.GuardarRol(rol);
        }

        //public void ActualizarRol(EntidadRol rol)
        //{
        //    conexion.ActualizarRol(rol);
        //}

        public void EliminarRol(int id,string jornada,string color)
        {
            conexion.EliminarRol(id,jornada,color);
        }
        public List<EntidadRol> LeerRol()
        {
            return conexion.LeerRol();
        }
    }
}
