using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmSalas : Form
    {
        public FrmSalas()
        {
            InitializeComponent();
            manejador = new ManejadorSala();
        }
        ManejadorSala manejador;
        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmModalSalas modalSalas = new FrmModalSalas(false);
            modalSalas.ShowDialog();
            Actualizar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la siguiente sala de la lista?", "Aviso.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manejador.EliminarSala(int.Parse(dtgSalas.CurrentRow.Cells["IDSala"].Value.ToString()));
            }
            Actualizar();
        }

        void Actualizar()
        {
            dtgSalas.DataSource = manejador.LeerSala();
        }

        private void FrmSalas_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        private void dtgSalas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmModalSalas modalSalas = new FrmModalSalas(true);
            modalSalas.ShowDialog();
            Actualizar();
        }
    }
}
