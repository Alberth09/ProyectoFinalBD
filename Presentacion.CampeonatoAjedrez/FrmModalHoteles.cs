using System;
using System.Windows.Forms;
using Entidades.CampeonatoAjedrez;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmModalHoteles : Form
    {
        public FrmModalHoteles(bool upd)
        {
            InitializeComponent();
            manejador = new ManejadorHotel();
            entidad = new EntidadHotel();
            actualizar = upd;
        }

        ManejadorHotel manejador;
        EntidadHotel entidad;
        bool actualizar; //bandera que indica si se intenta actualizar

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                ActualizarHotel();
            }
            else
            {
                GuardarHotel();
            }
        }

        void GuardarHotel()
        {
            entidad = new EntidadHotel
            {
                IDHotel = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };

            manejador.GuardarHotel(entidad);
            Limpiar();
        }

        void ActualizarHotel()
        {
            entidad = new EntidadHotel
            {
                IDHotel = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text
            };

            manejador.ActualizarHotel(entidad);
            Limpiar();
        }

        void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
        }
    }
}
