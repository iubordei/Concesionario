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
        // POS: genera un formulario de tipo AltaPresupuesto, para añadir nuevos presupuestos al sistema (siempre y cuando haya clientes y vehículos en el sistema).
        private void tsAltaPresupuesto_Click(object sender, EventArgs e)
        {
            if (LNCliente.Cliente.VerClientes().Count > 0 && LNVehiculo.Vehiculo.GetAllVehiculos().Count > 0)
            {
                PresupuestoAlta nuevo = new PresupuestoAlta();
                nuevo.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay datos suficientes para crear presupuestos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
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
                    login.Show();
                    this.Close();
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

        // PRE:
        // POS: permite buscar entre los vehículos de la BD según el número de bastidor.
        private void tsBusquedaVehiculo_Click(object sender, EventArgs e)
        {
            Form VehiculoAgregarClave = new VehiculoAgregarClave(tsBusquedaVehiculo.Text);
            VehiculoAgregarClave.ShowDialog();
        }

        // PRE:
        // POS: lista los vehículos almacenados en el concesionario.
        private void tsListadoVehiculo_Click(object sender, EventArgs e)
        {
            List<MD.Vehiculo> ListadoVehiculos = LNVehiculo.Vehiculo.GetAllVehiculos();
            if (ListadoVehiculos.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show("No hay vehiculos en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form Listado = new ListadoVehiculos();
            Listado.ShowDialog();
        }

        // PRE:
        // POS: permite recorrer los objetos Vehiculo que están almacenados en la BD.
        private void txRecorridoVehiculo_Click(object sender, EventArgs e)
        {
            List<MD.Vehiculo> ListadoVehiculos = LNVehiculo.Vehiculo.GetAllVehiculos();
            if (ListadoVehiculos.Count == 0)
            {
                DialogResult dialogResult = MessageBox.Show("No hay vehiculos en la base de datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Form Recorrido = new VehiculoUnoAUno();
            Recorrido.ShowDialog();
        }

        // PRE:
        // POS: inicia el proceso de búsqueda de un cliente por su DNI.
        private void tsBusquedaCliente_Click(object sender, EventArgs e)
        {
            ClienteClave clave = new ClienteClave("Busqueda");
            clave.ShowDialog();
        }

        // PRE:
        // POS: inicia el proceso de alta de un cliente.
        private void tsAltaCliente_Click(object sender, EventArgs e)
        {
            ClienteClave clave = new ClienteClave(tsAltaCliente.Text);
            clave.ShowDialog();
        }

        // PRE:
        // POS: inicia el proceso de baja de un cliente.
        private void tsBajaCliente_Click(object sender, EventArgs e)
        {
            ClienteClave clave = new ClienteClave(tsBajaCliente.Text);
            clave.ShowDialog();
        }

        // PRE:
        // POS: búsqueda de clientes mediante la elección de su DNI.
        private void búsquedaPorDNIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteBusquedaDNI busqueda = new ClienteBusquedaDNI();
            busqueda.ShowDialog();
        }

        // PRE:
        // POS: recorre uno a uno todos los clientes almacenados en la BD.
        private void recorridoUnoAUnoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ClienteRecorrido recorrido = new ClienteRecorrido();
            recorrido.ShowDialog();
        }

        private void listadoOrdenadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClienteListado listado = new ClienteListado();
            listado.ShowDialog();
        }
    }
}
