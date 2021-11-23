namespace Entidades.CampeonatoAjedrez
{
    public class EntidadRol
    {
        private int _fkIDPartida;
        private string _fkJornada;
        private int _fkIDParticipante;
        private int _color;

        public int FkIDPartida { get => _fkIDPartida; set => _fkIDPartida = value; }
        public int FkIDParticipante { get => _fkIDParticipante; set => _fkIDParticipante = value; }
        public string FkJornada { get => _fkJornada; set => _fkJornada = value; }
        public int Color { get => _color; set => _color = value; }
    }
}
