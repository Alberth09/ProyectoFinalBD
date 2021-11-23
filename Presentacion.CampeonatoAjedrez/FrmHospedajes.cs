using System;
using System.Windows.Forms;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmHospedajes : Form
    {
        public FrmHospedajes()
        {
            InitializeComponent();
            manejador = new ManejadorHospedaje();
        }
        ManejadorHospedaje manejador;

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el siguiente hospedaje de la lista?", "Aviso.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manejador.EliminarHospedaje(int.Parse(dtgHospedajes.CurrentRow.Cells["IDHospedaje"].Value.ToString()));
            }
            Actualizar();
        }

        void Actualizar()
        {
            dtgHospedajes.DataSource = manejador.LeerHospedaje();
        }

        private void FrmHospedajes_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmModalHospedajes modalHospedajes = new FrmModalHospedajes();
            modalHospedajes.ShowDialog();
            Actualizar();
        }
    }
}
