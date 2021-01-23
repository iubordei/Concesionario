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
        private LogIn login;

        // PRE:
        // POS: crea un nuevo formulario de tipo Gestion.
        public Gestion() : this("", new LogIn())
        {

        }

        // PRE: nombre != null.
        // POS: crea un formulario de tipo Gestion, con nombreUsuario = nombre.
        public Gestion(string nombre, LogIn login)
        {
            InitializeComponent();
            this.nombreUsuario = nombre;
            this.Text = nombre + ": Gestión de concesionario";
            this.login = login;
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

        // PRE:
        // POS: "simula" la acción de cerrar sesión, y muestra el formulario de LogIn para conectarse como otro Comercial.
        private void tsDesconectar_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Seguro que quieres desconectar?", "Cerrar sesión", MessageBoxButtons.YesNo);
            switch (mensaje)
            {
                case DialogResult.Yes:
                    foreach (Form form in Application.OpenForms)
                    {
                        if (form != login)
                        {
                            form.Close();
                        }
                    }
                    login.Show();
                    break;
            }

        }

        // PRE:
        // POS: cierra la aplicación.
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult mensaje = MessageBox.Show("¿Seguro que quieres salir?", "Cerrar aplicación", MessageBoxButtons.YesNo);
            switch (mensaje)
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
            }
        }
    }
}
