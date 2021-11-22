namespace Entidades.TorneoAjedrez
{
    public class EntidadSala
    {
        private int _iDSala;
        private int _fkIDHotel;
        private string _codigoSala;
        private int _capacidad;
        private string _medios;

        public int IDSala { get => _iDSala; set => _iDSala = value; }
        public int FkIDHotel { get => _fkIDHotel; set => _fkIDHotel = value; }
        public string CodigoSala { get => _codigoSala; set => _codigoSala = value; }
        public int Capacidad { get => _capacidad; set => _capacidad = value; }
        public string Medios { get => _medios; set => _medios = value; }
    }
}
