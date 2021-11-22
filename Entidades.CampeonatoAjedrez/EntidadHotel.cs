namespace Entidades.TorneoAjedrez
{
    public class EntidadHotel
    {
        private int _iDHotel;
        private string _nombre;
        private string _direccion;
        private string _telefono;

        public int IDHotel { get => _iDHotel; set => _iDHotel = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
    }
}
