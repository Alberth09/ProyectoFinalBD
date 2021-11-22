namespace Entidades.CampeonatoAjedrez
{
    public class EntidadPais
    {
        private int _iDPais;
        private string _nombre;
        private int _noClubes;
        private int _representa;

        public int IDPais { get => _iDPais; set => _iDPais = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int NoClubes { get => _noClubes; set => _noClubes = value; }
        public int Representa { get => _representa; set => _representa = value; }
    }
}
