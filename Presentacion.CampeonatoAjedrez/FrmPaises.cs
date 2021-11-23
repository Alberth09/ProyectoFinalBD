using System;
using System.Windows.Forms;
using Manejadores.CampeonatoAjedrez;


namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmPaises : Form
    {
        public FrmPaises()
        {
            InitializeComponent();
            manejador = new ManejadorPais();
        }

        ManejadorPais manejador;

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmModalPaises modalPais = new FrmModalPaises(false);
            modalPais.ShowDialog();
            Actualizar();
        }

        void Actualizar()
        {
            dtgPaises.DataSource = manejador.LeerPais();
        }

        private void FrmPais_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el siguiente país de la lista?","Aviso.",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manejador.EliminarPais(int.Parse(dtgPaises.CurrentRow.Cells["IDPais"].Value.ToString()));
            }
            Actualizar();
        }

        private void dtgPaises_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModalPaises modalPais = new FrmModalPaises(true);
            modalPais.ShowDialog();
            Actualizar();
        }
    }
}
