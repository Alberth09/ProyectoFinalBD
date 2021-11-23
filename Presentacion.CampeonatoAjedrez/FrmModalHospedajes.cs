using System;
using System.Windows.Forms;
using Entidades.CampeonatoAjedrez;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmModalHospedajes : Form
    {
        public FrmModalHospedajes()
        {
            InitializeComponent();
            manejador = new ManejadorHospedaje();
            entidad = new EntidadHospedaje();
        }
        ManejadorHospedaje manejador;
        EntidadHospedaje entidad;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarHospedaje();
        }

        void GuardarHospedaje()
        {
            entidad = new EntidadHospedaje
            {
                IDHospedaje = int.Parse(txtID.Text),
                FkIDParticipante = int.Parse(txtParticipante.Text),
                FkCampeonato = txtCampeonato.Text,
                FkIDHotel = int.Parse(txtHotel.Text),
                FechaEntrada = txtEntrada.Text,
                FechaSalida = txtSalida.Text
            };

            manejador.GuardarHospedaje(entidad);
            Limpiar();
        }

        void Limpiar()
        {
            txtEntrada.Clear();
            txtSalida.Clear();
            txtID.Clear();
            txtHotel.Clear();
            txtParticipante.Clear();
            txtCampeonato.Clear();
        }
    }
}
