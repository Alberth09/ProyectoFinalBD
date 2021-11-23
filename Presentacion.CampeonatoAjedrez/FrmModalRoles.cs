using System;
using System.Windows.Forms;
using Entidades.CampeonatoAjedrez;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmModalRoles : Form
    {
        public FrmModalRoles()
        {
            InitializeComponent();
            manejador = new ManejadorRol();
            entidad = new EntidadRol();
        }
        ManejadorRol manejador;
        EntidadRol entidad;

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            GuardarRol();
        }

        void GuardarRol()
        {
            int color = 0;

            if (rbBlancas.Checked)
            {
                color = 1;
            }
            if (rbNegras.Checked)
            {
                color = 2;
            }

            entidad = new EntidadRol
            {
                FkIDPartida = int.Parse(txtPartida.Text),
                FkJornada = txtJornada.Text,
                FkIDParticipante = int.Parse(txtParticipante.Text),
                Color = color.ToString()
            };

            manejador.GuardarRol(entidad);
            Limpiar();
        }

        void Limpiar()
        {
            txtParticipante.Clear();
            txtPartida.Clear();
            txtJornada.Clear();
            rbBlancas.Checked = false;
            rbNegras.Checked = false;
        }
    }
}
