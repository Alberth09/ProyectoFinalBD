using AccesoDatos.CampeonatoAjedrez;
using Entidades.CampeonatoAjedrez;
using System.Collections.Generic;

namespace Manejadores.CampeonatoAjedrez
{
    public class ManejadorPais
    {
        ConexionPais conexion = new ConexionPais();
        public void GuardarPais(EntidadPais pais)
        {
            conexion.GuardarPais(pais);
        }
        public void ActualizarPais(EntidadPais pais)
        {
            conexion.ActualizarPais(pais);
        }
        public void EliminarPais(int pais)
        {
            conexion.EliminarPais(pais);
        }
        public List<EntidadPais> LeerPais()
        {
            return conexion.LeerPais();
        }
    }
}
