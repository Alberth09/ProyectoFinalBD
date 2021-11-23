using System;
using System.Windows.Forms;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmHoteles : Form
    {
        public FrmHoteles()
        {
            InitializeComponent();
            manejador = new ManejadorHotel();
        }
        ManejadorHotel manejador;

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmModalHoteles modalHoteles = new FrmModalHoteles(false);
            modalHoteles.ShowDialog();
            Actualizar();
        }

        private void FrmHoteles_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            dtgHoteles.DataSource = manejador.LeerHotel();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el siguiente hotel de la lista?", "Aviso.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manejador.EliminarHotel(int.Parse(dtgHoteles.CurrentRow.Cells["IDHotel"].Value.ToString()));
            }
            Actualizar();
        }

        private void dtgHoteles_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModalHoteles modalHoteles = new FrmModalHoteles(true);
            modalHoteles.ShowDialog();
            Actualizar();
        }
    }
}
