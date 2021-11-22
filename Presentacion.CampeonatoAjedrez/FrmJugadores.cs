using System;
using System.Windows.Forms;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmJugadores : Form
    {
        public FrmJugadores()
        {
            InitializeComponent();
            manejador = new ManejadorParticipante();
        }

        ManejadorParticipante manejador;
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmJugadores_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmModalJugadores modalJugadores = new FrmModalJugadores(false);
            modalJugadores.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgJugadores.CurrentRow.Cells["IDParticipante"].Value.ToString());
            string campeonato = dtgJugadores.CurrentRow.Cells["Campeonato"].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar el siguiente jugador de la lista?", "Aviso.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manejador.EliminarParticipante(id,campeonato);
            }
            Actualizar();
        }

        private void dtgJugadores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModalJugadores modalJugadores = new FrmModalJugadores(true);
            modalJugadores.ShowDialog();
            Actualizar();
        }

        void Actualizar()
        {
            dtgJugadores.DataSource = manejador.LeerParticipante();
        }
    }
}
