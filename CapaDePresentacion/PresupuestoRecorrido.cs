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
    public partial class PresupuestoRecorrido : Form
    {
        private List<MD.Presupuesto> presupuestos;

        // PRE:
        // POS: crea un nuevo formulario de tipo PresupuestoRecorrido.
        public PresupuestoRecorrido()
        {
            InitializeComponent();
        }

        // PRE: presupuestos != null.
        // POS: crea un nuevo formulario de tipo PresupuestoRecorrido y establece la fuente de datos de
        // POS: bindingNavigator a la lista pasada de presupuestos.
        public PresupuestoRecorrido(List<MD.Presupuesto> presupuestos)
        {
            this.presupuestos = presupuestos;
            InitializeComponent();
        }

        // PRE:
        // POS: durante la carga del formulario, asigna como origen de datos del BindingSource una lista con todos los presupuestos.
        private void PresupuestoRecorrido_Load(object sender, EventArgs e)
        {
            sourcePresupuestos.DataSource = presupuestos;
            actualizar();
        }

        // PRE:
        // POS: actualiza los campos para representar el presupuesto correcto.
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        // PRE:
        // POS: actualiza los campos para representar el presupuesto correcto.
        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        // PRE:
        // POS: actualiza los campos para representar el presupuesto correcto.
        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        // PRE:
        // POS: actualiza los campos para representar el presupuesto correcto.
        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            actualizar();
        }

        // PRE:
        // POS: introduce en la lista de valoraciones, las valoraciones asignadas al presupuesto mostrado.
        private void actualizar()
        {
            MD.Presupuesto presupuesto = (MD.Presupuesto)bindingNavigator.BindingSource.Current;

            lboxValoraciones.Items.Clear();
            foreach (KeyValuePair<MD.Vehiculo, double> kvp in presupuesto.Valoracion)
            {
                lboxValoraciones.Items.Add(kvp.Key.Marca + " " + kvp.Key.Modelo + " " + kvp.Key.Año + ", " + kvp.Value);
            }

            txtCliente.Text = presupuesto.Cliente.Nombre + ", " + presupuesto.Cliente.DNI;
            if (presupuesto.Vehiculo != null)
            {
                txtVehiculo.Text = presupuesto.Vehiculo.Marca + " " + presupuesto.Vehiculo.Modelo + " " + presupuesto.Vehiculo.Año;
            }
        }
    }
}
