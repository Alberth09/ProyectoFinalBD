using System;
using System.Windows.Forms;
using Manejadores.CampeonatoAjedrez;
using Entidades.CampeonatoAjedrez;


namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmModalMovimientos : Form
    {
        public FrmModalMovimientos()
        {
            InitializeComponent();
            manejador = new ManejadorMovimiento();
            entidad = new EntidadMovimiento();
        }
        ManejadorMovimiento manejador;
        EntidadMovimiento entidad;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarMovimiento();
        }

        void GuardarMovimiento()
        {
            entidad = new EntidadMovimiento
            {
                IDMovimiento = int.Parse(txtID.Text),
                FkIDPartida = int.Parse(txtPartida.Text),
                FkJornada = txtJornada.Text,
                Movimiento = txtMovimiento.Text,
                Jugada = txtJugada.Text,
                Comentario = txtJugada.Text
            };

            manejador.GuardarMovimiento(entidad);
            Limpiar();
        }

        void Limpiar()
        {
            txtJugada.Clear();
            txtComentario.Clear();
            txtID.Clear();
            txtJornada.Clear();
            txtMovimiento.Clear();
            txtPartida.Clear();
        }
    }
}
