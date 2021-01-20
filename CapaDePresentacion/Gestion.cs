using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class Gestion : Form
    {
        private string usuario;

        public Gestion()
        {
            InitializeComponent();
        }

        public Gestion(string usuario) : base()
        {
            this.usuario = usuario;
            this.Text = usuario + ": Gestión de concesionario";
        }

        private void altaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PresupuestoAlta nuevo = new PresupuestoAlta();
            nuevo.Show();
        }

        private void búsquedaToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            PresupuestoBusqueda busqueda = new PresupuestoBusqueda();
            busqueda.Show();
        }

        private void altaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form VehiculoAgregarClave = new VehiculoAgregarClave(altaToolStripMenuItem1.Text);
            VehiculoAgregarClave.ShowDialog();
        }

        private void bajaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form VehiculoAgregarClave = new VehiculoAgregarClave(bajaToolStripMenuItem1.Text);
            VehiculoAgregarClave.ShowDialog();
        }
    }
}
