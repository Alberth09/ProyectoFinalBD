using System;
using System.Windows.Forms;
using Entidades.CampeonatoAjedrez;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmModalPaises : Form
    {
        public FrmModalPaises(bool upd)
        {
            InitializeComponent();
            manejador = new ManejadorPais();
            entidad = new EntidadPais();
            actualizar = upd;
        }
        ManejadorPais manejador;
        EntidadPais entidad;
        bool actualizar; //Bandera que indica si se intenta actualizar

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            Close();
        }

        void Limpiar()
        {
            txtID.Clear();
            txtNombre.Clear();
            numClubes.Value = 0;
            txtRepresenta.Clear();
        }

        void GuardarPais()
        {
            entidad = new EntidadPais
            {
                IDPais = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                NoClubes = int.Parse(numClubes.Value.ToString()),
                Representa = txtRepresenta.Text
            };

            manejador.GuardarPais(entidad);
            Limpiar();
        }

        void ActualizarPais()
        {
            entidad = new EntidadPais
            {
                IDPais = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                NoClubes = int.Parse(numClubes.Value.ToString()),
                Representa = txtRepresenta.Text
            };

            manejador.ActualizarPais(entidad);
            Limpiar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (actualizar)
            {
                ActualizarPais();
            }
            else
            {
                GuardarPais();
            }
        }
    }
}
