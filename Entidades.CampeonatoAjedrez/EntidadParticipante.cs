namespace Entidades.CampeonatoAjedrez
{
    public class EntidadParticipante
    {
        private int _iDParticipante;
        private string _nombre;
        private string _direccion;
        private string _telefono;
        private string _campeonato;
        private int _tipo;
        private string _nivel;
        private int _fkIDPais;

        public int IDParticipante { get => _iDParticipante; set => _iDParticipante = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Direccion { get => _direccion; set => _direccion = value; }
        public string Telefono { get => _telefono; set => _telefono = value; }
        public string Campeonato { get => _campeonato; set => _campeonato = value; }
        public int Tipo { get => _tipo; set => _tipo = value; }
        public string Nivel { get => _nivel; set => _nivel = value; }
        public int FkIDPais { get => _fkIDPais; set => _fkIDPais = value; }
    }
}
