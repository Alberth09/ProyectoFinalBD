namespace Entidades.CampeonatoAjedrez
{
    public class EntidadHospedaje
    {
        private int _iDHospedaje;
        private int _fkIDParticipante;
        private string _fkCampeonato;
        private int _fkIDHotel;
        private string _fechaEntrada;
        private string _fechaSalida;

        public int IDHospedaje { get => _iDHospedaje; set => _iDHospedaje = value; }
        public int FkIDParticipante { get => _fkIDParticipante; set => _fkIDParticipante = value; }
        public string FkCampeonato { get => _fkCampeonato; set => _fkCampeonato = value; }
        public int FkIDHotel { get => _fkIDHotel; set => _fkIDHotel = value; }
        public string FechaEntrada { get => _fechaEntrada; set => _fechaEntrada = value; }
        public string FechaSalida { get => _fechaSalida; set => _fechaSalida = value; }
    }
}
