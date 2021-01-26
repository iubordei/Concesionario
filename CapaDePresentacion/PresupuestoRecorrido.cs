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
        // POS: si el estado del presupuesto es Aceptado, el botón de compra está deshabilitado.
        private void actualizar()
        {
            MD.Presupuesto presupuesto = (MD.Presupuesto)bindingNavigator.BindingSource.Current;
            if (presupuesto != null)
            {
                lboxValoraciones.Items.Clear();
                foreach (KeyValuePair<MD.Vehiculo, double> kvp in presupuesto.Valoracion)
                {
                    lboxValoraciones.Items.Add(kvp.Key.Marca + " " + kvp.Key.Modelo + " " + kvp.Key.Año + ", " + kvp.Value + "€");
                }

                lboxValoraciones.SelectedIndex = 0;

                txtCliente.Text = presupuesto.Cliente.Nombre + ", " + presupuesto.Cliente.DNI;
                if (presupuesto.Vehiculo != null)
                {
                    txtVehiculo.Text = presupuesto.Vehiculo.Marca + " " + presupuesto.Vehiculo.Modelo + " " + presupuesto.Vehiculo.Año;
                    btnComprar.Visible = false;
                }
                else
                {
                    txtVehiculo.Clear();
                    btnComprar.Visible = true;
                }
            }
        }

        // PRE:
        // POS: realiza la compra del vehículo seleccionado de la sección de valoraciones en caso de que el presupuesto
        // POS: cumpla los requisitos (estar en Estado "Pendiente") y desactiva el botón de compra.
        private void btnComprar_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();
            res = MessageBox.Show("¿Quieres confirmar la compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            switch (res)
            {
                case DialogResult.Yes:
                    MD.Presupuesto presupuesto = (MD.Presupuesto)bindingNavigator.BindingSource.Current;
                    MD.Vehiculo vehiculo = null;
                    foreach (KeyValuePair<MD.Vehiculo, double> kvp in presupuesto.Valoracion)
                    {
                        if ((kvp.Key.Marca + " " + kvp.Key.Modelo + " " + kvp.Key.Año + ", " + kvp.Value + "€").Equals((string)lboxValoraciones.SelectedItem))
                        {
                            vehiculo = kvp.Key;
                        }
                    }
                    if (LNPresupuesto.Presupuesto.ComprarVehiculo(presupuesto, vehiculo))
                    {
                        MessageBox.Show("La compra se ha realizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        actualizar();
                    }
                    else
                    {
                        MessageBox.Show("La compra no se puede llevar a cabo, el presupuesto seleccionado no es válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    break;
                case DialogResult.No:
                    MessageBox.Show("La compra se ha cancelado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
