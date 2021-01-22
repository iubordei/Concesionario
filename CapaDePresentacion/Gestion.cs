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
        private string nombreUsuario;

        // PRE:
        // POS: crea un nuevo formulario de tipo Gestion.
        public Gestion() : this("")
        {
            
        }

        // PRE: nombre != null.
        // POS: crea un formulario de tipo Gestion, con nombreUsuario = nombre.
        public Gestion(string nombre)
        {
            InitializeComponent();
            this.nombreUsuario = nombre;
            this.Text = nombre + ": Gestión de concesionario";
        }

        // PRE:
        // POS: genera un formulario de tipo AltaPresupuesto, para añadir nuevos presupuestos al sistema.
        private void tsAltaPresupuesto_Click(object sender, EventArgs e)
        {
            PresupuestoAlta nuevo = new PresupuestoAlta();
            nuevo.ShowDialog();
        }

        // PRE:
        // POS: genera un formulario de tipo BusquedaPresupuesto, para buscar entre los presupuestos
        // POS: almacenados en el sistema según un parámetro (cliente, vehículo, estado).
        private void tsBusquedaPresupuesto_Click(object sender, EventArgs e)
        {
            PresupuestoBusqueda busqueda = new PresupuestoBusqueda();
            busqueda.ShowDialog();
        }

        // PRE:
        // POS: cierra la aplicacion.
        private void tsDesconectar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // PRE:
        // POS: genera un formulario de tipo VehiculoAgregarClave, para introducir el número de bastidor de un vehículo
        // POS: y así añadir un nuevo vehículo en el caso de que este no esté ya almacenado.
        private void tsAltaVehiculo_Click(object sender, EventArgs e)
        {
            Form VehiculoAgregarClave = new VehiculoAgregarClave(tsAltaVehiculo.Text);
            VehiculoAgregarClave.ShowDialog();
        }

        // PRE:
        // POS: genera un formulario de tipo VehiculoAgregarClave, para introducir el número de bastidor de un vehículo
        // POS: y así continuar con el proceso de eliminado de un vehículo del sistema.
        private void tsBajaVehiculo_Click(object sender, EventArgs e)
        {
            Form VehiculoAgregarClave = new VehiculoAgregarClave(tsAltaVehiculo.Text);
            VehiculoAgregarClave.ShowDialog();
        }

        // PRE:
        // POS: genera un formulario de tipo PresupuestoRecorrido, para mostrar todos los presupuestos almacenados en el sistema.
        private void tsMostrarTodosPresupuesto_Click(object sender, EventArgs e)
        {
            Form mostrarTodos = new PresupuestoRecorrido(LNPresupuesto.Presupuesto.GetTodosPresupuestos());
            mostrarTodos.ShowDialog();
        }
    }
}
