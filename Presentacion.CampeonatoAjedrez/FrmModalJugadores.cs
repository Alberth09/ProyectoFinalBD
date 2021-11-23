using System;
using System.Windows.Forms;
using Entidades.CampeonatoAjedrez;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmModalJugadores : Form
    {
        public FrmModalJugadores(bool upd)
        {
            InitializeComponent();
            manejador = new ManejadorParticipante();
            entidad = new EntidadParticipante();
            tipo = "";
            actualizar = upd;
        }

        ManejadorParticipante manejador;
        EntidadParticipante entidad;
        string tipo; //Almacena el tipo de participante (si es jugador o árbitro)
        bool actualizar; //Bandera que indica si se intenta actualizar

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                ActualizarParticipante();
            }
            else
            {
                GuardarParticipante();
            }
        }

        void GuardarParticipante()
        {
            entidad = new EntidadParticipante
            {
                IDParticipante = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Campeonato = txtCampeonato.Text,
                Tipo = tipo,
                Nivel = cbNivel.SelectedItem.ToString(),
                FkIDPais = int.Parse(txtPais.Text)
            };

            manejador.GuardarParticipante(entidad);
            Limpiar();
        }

        void ActualizarParticipante()
        {
            entidad = new EntidadParticipante
            {
                IDParticipante = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Campeonato = txtCampeonato.Text,
                Tipo = tipo,
                Nivel = cbNivel.SelectedItem.ToString(),
                FkIDPais = int.Parse(txtPais.Text)
            };

            manejador.ActualizarParticipante(entidad);
            Limpiar();
        }

        private void rbArbitro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbArbitro.Checked)
            {
                cbNivel.SelectedIndex = 0;
                cbNivel.Enabled = false;
                tipo = 2.ToString();
            }
        }

        private void rbJugador_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJugador.Checked)
            {
                cbNivel.SelectedIndex = 1;
                cbNivel.Enabled = true;
                tipo = 1.ToString();
            }
        }

        void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtCampeonato.Clear();
            rbJugador.Checked = false;
            rbArbitro.Checked = false;
            cbNivel.ResetText();
            txtPais.Clear();
        }
    }
}
