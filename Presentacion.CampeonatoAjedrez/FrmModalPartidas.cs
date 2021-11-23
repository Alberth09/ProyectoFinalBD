using System;
using System.Windows.Forms;
using Entidades.CampeonatoAjedrez;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmModalPartidas : Form
    {
        public FrmModalPartidas(bool upd)
        {
            InitializeComponent();
            entidad = new EntidadPartida();
            manejador = new ManejadorPartida();
            actualizar = upd;
        }

        EntidadPartida entidad;
        ManejadorPartida manejador;
        bool actualizar; //

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                ActualizarPartida();
            }
            else
            {
                GuardarPartida();
            }
        }

        void GuardarPartida()
        {
            entidad = new EntidadPartida
            {
                IDPartida = int.Parse(txtID.Text),
                CodigoPartida = txtCodigo.Text,
                Jornada = txtJornada.Text,
                FkIDArbitro = int.Parse(txtArbitro.Text),
                FkIDSala = int.Parse(txtSala.Text),
                Entradas = int.Parse(txtEntradas.Text)
            };

            manejador.GuardarPartida(entidad);
            Limpiar();
        }

        void ActualizarPartida()
        {
            entidad = new EntidadPartida
            {
                IDPartida = int.Parse(txtID.Text),
                CodigoPartida = txtCodigo.Text,
                Jornada = txtJornada.Text,
                FkIDArbitro = int.Parse(txtArbitro.Text),
                FkIDSala = int.Parse(txtSala.Text),
                Entradas = int.Parse(txtEntradas.Text)
            };

            manejador.ActualizarPartida(entidad);
            Limpiar();
        }

        void Limpiar()
        {
            txtID.Clear();
            txtCodigo.Clear();
            txtJornada.Clear();
            txtArbitro.Clear();
            txtSala.Clear();
            txtEntradas.Clear();
        }
    }
}
