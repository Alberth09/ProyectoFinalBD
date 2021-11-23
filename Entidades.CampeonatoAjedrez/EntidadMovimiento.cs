namespace Entidades.CampeonatoAjedrez
{
    public class EntidadMovimiento
    {
        private int _iDMovimiento;
        private int _fkIDPartida;
        private string _fkJornada;
        private string _movimiento;
        private string _jugada;
        private string _comentario;

        public int IDMovimiento { get => _iDMovimiento; set => _iDMovimiento = value; }
        public int FkIDPartida { get => _fkIDPartida; set => _fkIDPartida = value; }
        public string FkJornada { get => _fkJornada; set => _fkJornada = value; }
        public string Movimiento { get => _movimiento; set => _movimiento = value; }
        public string Jugada { get => _jugada; set => _jugada = value; }
        public string Comentario { get => _comentario; set => _comentario = value; }
    }
}
