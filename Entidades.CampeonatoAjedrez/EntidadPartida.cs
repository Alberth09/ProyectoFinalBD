namespace Entidades.TorneoAjedrez
{
    public class EntidadPartida
    {
        private int _iDPartida;
        private string _codigoPartida;
        private string _jornada;
        private int _fkIDArbitro;
        private int _fkIDSala;
        private int _entradas;

        public int IDPartida { get => _iDPartida; set => _iDPartida = value; }
        public string CodigoPartida { get => _codigoPartida; set => _codigoPartida = value; }
        public string Jornada { get => _jornada; set => _jornada = value; }
        public int FkIDArbitro { get => _fkIDArbitro; set => _fkIDArbitro = value; }
        public int FkIDSala { get => _fkIDSala; set => _fkIDSala = value; }
        public int Entradas { get => _entradas; set => _entradas = value; }
    }
}
