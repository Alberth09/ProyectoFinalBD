using System;
using System.Windows.Forms;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void salidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void jugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJugadores jugadores = new FrmJugadores();
            jugadores.Show();
        }

        private void paísesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPaises paises = new FrmPaises();
            paises.Show();
        }

        private void hotelesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmHoteles hoteles = new FrmHoteles();
            hoteles.Show();
        }

        private void partidasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPartidas partidas = new FrmPartidas();
            partidas.Show();
        }

        private void salasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSalas salas = new FrmSalas();
            salas.Show();
        }

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmRoles roles = new FrmRoles();
            roles.Show();
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHospedajes hospedajes = new FrmHospedajes();
            hospedajes.Show();
        }

        private void movimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMovimientos movimientos = new FrmMovimientos();
            movimientos.Show();
        }
    }
}
