using System;
using System.Windows.Forms;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmMovimientos : Form
    {
        public FrmMovimientos()
        {
            InitializeComponent();
            manejador = new ManejadorMovimiento();
        }
        ManejadorMovimiento manejador;

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmModalMovimientos movimientos = new FrmModalMovimientos();
            movimientos.ShowDialog();
            Actualizar();
        }
        
        void Actualizar()
        {
            dtgMovimientos.DataSource = manejador.LeerMovimiento();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgMovimientos.CurrentRow.Cells["IDMovimiento"].Value.ToString());
            int partida = int.Parse(dtgMovimientos.CurrentRow.Cells["FkIDPartida"].Value.ToString());
            string jornada = dtgMovimientos.CurrentRow.Cells["FkJornada"].Value.ToString();

            if (MessageBox.Show("¿Desea eliminar la siguiente sala de la lista?", "Aviso.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manejador.EliminarMovimiento(id,partida,jornada);
            }
            Actualizar();
        }

        private void FrmMovimientos_Load(object sender, EventArgs e)
        {
            Actualizar();
        }
    }
}
