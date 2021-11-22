using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            FrmPais pais = new FrmPais();
            pais.Show();
        }
    }
}
