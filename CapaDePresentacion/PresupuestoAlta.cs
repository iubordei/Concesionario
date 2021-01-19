using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LNCliente;
using LNPresupuesto;
using LNVehiculo;
using MD;

namespace CapaDePresentacion
{
    public partial class PresupuestoAlta : Form
    {
        public PresupuestoAlta()
        {
            InitializeComponent();
        }

        private void PresupuestoAlta_Load(object sender, EventArgs e)
        {
            List<MD.Cliente> clientes = LNCliente.Cliente.verClientes();
            foreach (MD.Cliente cliente in clientes)
            {
                listBoxClientes.Items.Add(cliente);
            }

            List<MD.Vehiculo> vehiculos = LNVehiculo.Vehiculo.getAllVehiculos();
            foreach (MD.Vehiculo vehiculo in vehiculos)
            {
                listBoxClientes.Items.Add(vehiculo);
            }

            listBoxClientes.SelectedIndex = 0;
            listBoxVehiculos.SelectedIndex = 0;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            LNPresupuesto.Presupuesto.CrearPresupuesto(DateTime.Today, (MD.Cliente) listBoxClientes.SelectedItem, (MD.Vehiculo) listBoxVehiculos.SelectedItem);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
