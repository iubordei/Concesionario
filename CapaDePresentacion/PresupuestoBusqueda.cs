using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MD;

namespace CapaDePresentacion
{
    public partial class PresupuestoBusqueda : Form
    {
        private Dictionary<string, MD.Cliente> clavesCliente;
        private Dictionary<string, MD.Vehiculo> clavesVehiculo;
        private Dictionary<string, MD.Estado> clavesEstado;
        private BindingSource bsParametros;
        private BindingSource bsResultados;

        // PRE:
        // POS: crea un formulario del tipo PresupuestoBusqueda.
        public PresupuestoBusqueda()
        {
            InitializeComponent();
        }

        // PRE:
        // POS: inicializa los objetos BindingSource que se emplearán para mostrar los datos en las listas del formulario.
        // POS: inicializa diccionarios que incluyen el objeto especificado como valor y una cadena que lo representa como clave.
        private void PresupuestoBusqueda_Load(object sender, EventArgs e)
        {
            bsParametros = new BindingSource();
            bsResultados = new BindingSource();

            // Claves Cliente
            clavesCliente = new Dictionary<string, Cliente>();
            foreach (MD.Cliente cliente in LNCliente.Cliente.VerClientes())
            {
                clavesCliente.Add(cliente.Nombre, cliente);
            }

            // Claves Vehiculo
            clavesVehiculo = new Dictionary<string, MD.Vehiculo>();
            foreach (MD.Vehiculo vehiculo in LNVehiculo.Vehiculo.GetAllVehiculos())
            {
                clavesVehiculo.Add(vehiculo.Marca + " " + vehiculo.Modelo + ", " + vehiculo.NumeroDeBastidor, vehiculo);
            }

            // Claves Estado
            clavesEstado = new Dictionary<string, MD.Estado>();
            foreach (MD.Estado estado in Enum.GetValues(typeof(MD.Estado)))
            {
                clavesEstado.Add(estado.ToString(), estado);
            }
        }

        // PRE:
        // POS: cierra el formulario de tipo PresupuestoBusqueda.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PRE:
        // POS: actualiza la lista de parámetros, mostrando los clientes al seleccionar la búsqueda por cliente.
        private void rdBtnCliente_CheckedChanged(object sender, EventArgs e)
        {
            bsParametros.DataSource = clavesCliente.Keys;
            listBoxParametros.DataSource = bsParametros;
            listBoxParametros.Refresh();

            listBoxParametros.SelectedIndex = 0;
        }

        // PRE:
        // POS: actualiza la lista de parámetros, mostrando los vehículos al seleccionar la búsqueda por vehículo.
        private void rdBtnVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            bsParametros.DataSource = clavesVehiculo.Keys;
            listBoxParametros.DataSource = bsParametros;
            listBoxParametros.Refresh();

            listBoxParametros.SelectedIndex = 0;
        }

        // PRE:
        // POS: actualiza la lista de parámetros, mostrando los estados al seleccionar la búsqueda por estado.
        private void rdBtnEstado_CheckedChanged(object sender, EventArgs e)
        {
            bsParametros.DataSource = clavesEstado.Keys;
            listBoxParametros.DataSource = bsParametros;
            listBoxParametros.Refresh();

            listBoxParametros.SelectedIndex = 1;
        }

        // PRE: las tablas de clientes y vehículos contienen datos.
        // POS: muestra el resultado de los presupuestos pedidos en función del parametro seleccionado.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (rdBtnCliente.Checked)
            {
                MD.Cliente parametro = clavesCliente[(string)listBoxParametros.SelectedItem];
                mostrarResultado(LNPresupuesto.Presupuesto.GetPresupuestosPorCliente(parametro));

            }

            if (rdBtnVehiculo.Checked)
            {
                MD.Vehiculo parametro = clavesVehiculo[(string)listBoxParametros.SelectedItem];
               mostrarResultado(LNPresupuesto.Presupuesto.GetPresupuestosPorVehiculo(parametro));
            }

            if (rdBtnEstado.Checked)
            {
                MD.Estado parametro = clavesEstado[(string)listBoxParametros.SelectedItem];
                mostrarResultado(LNPresupuesto.Presupuesto.GetPresupuestosPorEstado(parametro));
            }
        }

        // PRE:
        // POS: inicializa un formulario de recorrido, donde muestra los presupuestos de la lista "presupuestos",
        // POS: siempre y cuando que la lista no esté vacía (en tal caso muestra un mensaje de aviso).
        private void mostrarResultado(List<MD.Presupuesto> presupuestos)
        {
            if (presupuestos.Count > 0)
            {
                PresupuestoRecorrido recorrido = new PresupuestoRecorrido(presupuestos);
                recorrido.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay presupuestos que coincidan con el criterio de búsqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
