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
        private BindingSource sourcePresupuestos;

        // PRE:
        // POS: crea un nuevo formulario de tipo PresupuestoRecorrido.
        public PresupuestoRecorrido() : this(null)
        {

        }

        // PRE: presupuestos != null.
        // POS: crea un nuevo formulario de tipo PresupuestoRecorrido y establece la fuente de datos de
        // POS: bindingNavigator a la lista pasada a presupuestos.
        public PresupuestoRecorrido(List<MD.Presupuesto> presupuestos)
        {
            InitializeComponent();
            sourcePresupuestos = new BindingSource();
            sourcePresupuestos.DataSource = presupuestos;
            bindingNavigator.BindingSource = sourcePresupuestos;
        }

        // PRE:
        // POS: durante la carga del formulario, asigna a cada cuadro de texto su valor a mostrar correspondiente.
        private void PresupuestoRecorrido_Load(object sender, EventArgs e)
        {
            txtFecha.DataBindings.Add(new Binding("Text", sourcePresupuestos, "FechaRealizacion", true));
            txtCliente.DataBindings.Add(new Binding("Text", sourcePresupuestos, "Cliente", true));
            txtVehiculo.DataBindings.Add(new Binding("Text", sourcePresupuestos, "Vehiculo", true));
        }
    }
}
