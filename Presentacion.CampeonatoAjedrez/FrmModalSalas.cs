using System;
using System.Windows.Forms;
using Entidades.CampeonatoAjedrez;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmModalSalas : Form
    {
        public FrmModalSalas(bool upd)
        {
            InitializeComponent();
            manejador = new ManejadorSala();
            entidad = new EntidadSala();
            actualizar = upd;
        }
        ManejadorSala manejador;
        EntidadSala entidad;
        bool actualizar;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                ActualizarSala();
            }
            else
            {
                GuardarSala();
            }
        }

        void GuardarSala()
        {
            entidad = new EntidadSala
            {
                IDSala = int.Parse(txtID.Text),
                FkIDHotel = int.Parse(txtHotel.Text),
                CodigoSala = txtCodigo.Text,
                Capacidad = int.Parse(txtCapacidad.Text),
                Medios = txtMedios.Text
            };

            manejador.GuardarSala(entidad);
            Limpiar();
        }

        void ActualizarSala()
        {
            entidad = new EntidadSala
            {
                IDSala = int.Parse(txtID.Text),
                FkIDHotel = int.Parse(txtHotel.Text),
                CodigoSala = txtCodigo.Text,
                Capacidad = int.Parse(txtCapacidad.Text),
                Medios = txtMedios.Text
            };

            manejador.ActualizarSala(entidad);
            Limpiar();
        }

        void Limpiar()
        {
            txtCodigo.Clear();
            txtCapacidad.Clear();
            txtHotel.Clear();
            txtMedios.Clear();
            txtID.Clear();
        }
    }
}
