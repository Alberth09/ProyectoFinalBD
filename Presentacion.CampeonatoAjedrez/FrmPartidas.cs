using System;
using Manejadores.CampeonatoAjedrez;
using System.Windows.Forms;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmPartidas : Form
    {
        public FrmPartidas()
        {
            InitializeComponent();
            manejador = new ManejadorPartida();
        }
        ManejadorPartida manejador;

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmModalPartidas modalPartidas = new FrmModalPartidas(false);
            modalPartidas.ShowDialog();
            Actualizar();
        }

        void Actualizar()
        {
            dtgPartidas.DataSource = manejador.LeerPartida();
            dtgPartidas.Columns["Jornada"].DefaultCellStyle.Format = "y";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgPartidas.CurrentRow.Cells["IDpartida"].Value.ToString());
            string jornada = dtgPartidas.CurrentRow.Cells["Jornada"].Value.ToString();
            if (MessageBox.Show("¿Desea eliminar la siguiente paí de la lista?", "Aviso.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manejador.EliminarPartida(id,jornada);
            }
            Actualizar();
        }

        private void dtgPartidas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModalPartidas modalPartidas = new FrmModalPartidas(true);
            modalPartidas.ShowDialog();
            Actualizar();
        }

        private void FrmPartidas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
