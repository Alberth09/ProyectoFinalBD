using System;
using System.Windows.Forms;
using Manejadores.CampeonatoAjedrez;

namespace Presentacion.CampeonatoAjedrez
{
    public partial class FrmRoles : Form
    {
        public FrmRoles()
        {
            InitializeComponent();
            manejador = new ManejadorRol();
        }
        ManejadorRol manejador;

        private void FrmRoles_Load(object sender, EventArgs e)
        {
            Actualizar();
        }

        void Actualizar()
        {
            dtgRoles.DataSource = manejador.LeerRol();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dtgRoles.CurrentRow.Cells["FkIDPartida"].Value.ToString());
            string jornada = dtgRoles.CurrentRow.Cells["FkJornada"].Value.ToString();
            string color = dtgRoles.CurrentRow.Cells["Color"].Value.ToString();

            if (MessageBox.Show("¿Desea eliminar la siguiente paí de la lista?", "Aviso.", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                manejador.EliminarRol(id, jornada,color);
            }
            Actualizar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmModalRoles modalRoles = new FrmModalRoles();
            modalRoles.ShowDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
