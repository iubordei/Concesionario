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
        public PresupuestoBusqueda()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdBtnCliente_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnEstado.Checked = false;
            rdBtnVehiculo.Checked = false;
            listBoxParametros.Items.Clear();
            List<MD.Cliente> clientes = LNCliente.Cliente.verClientes();
            foreach (MD.Cliente cliente in clientes)
            {
                listBoxParametros.Items.Add(cliente);
            }

            listBoxParametros.SelectedIndex = 0;
        }

        private void rdBtnVehiculo_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnEstado.Checked = false;
            rdBtnCliente.Checked = false;
            listBoxParametros.Items.Clear();
            List<MD.Vehiculo> vehiculos = LNVehiculo.Vehiculo.getAllVehiculos();
            foreach (MD.Vehiculo vehiculo in vehiculos)
            {
                listBoxParametros.Items.Add(vehiculo);
            }

            listBoxParametros.SelectedIndex = 0;
        }

        private void rdBtnEstado_CheckedChanged(object sender, EventArgs e)
        {
            rdBtnCliente.Checked = false;
            rdBtnVehiculo.Checked = false;
            listBoxParametros.Items.Clear();
            foreach (MD.Estado estado in Enum.GetValues(typeof(MD.Estado)))
            {
                listBoxParametros.Items.Add(estado);
            }

            listBoxParametros.SelectedIndex = 0;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            listBoxResultado.Items.Clear();
            if (rdBtnCliente.Checked)
            {
                List<MD.Presupuesto> presupuestos = LNPresupuesto.Presupuesto.GetPresupuestosPorCliente((MD.Cliente)listBoxParametros.SelectedItem);
                añadirListaAListBox(presupuestos, listBoxResultado);
            }

            if (rdBtnVehiculo.Checked)
            {
                List<MD.Presupuesto> presupuestos = LNPresupuesto.Presupuesto.GetPresupuestosPorVehiculo((MD.Vehiculo)listBoxParametros.SelectedItem);
                añadirListaAListBox(presupuestos, listBoxResultado);
            }

            if (rdBtnEstado.Checked)
            {
                List<MD.Presupuesto> presupuestos = LNPresupuesto.Presupuesto.GetPresupuestosPorEstado((MD.Estado)listBoxParametros.SelectedItem);
                añadirListaAListBox(presupuestos, listBoxResultado);
            }
        }

        private void añadirListaAListBox(List<MD.Presupuesto> lista, ListBox listBox)
        {
            foreach (MD.Presupuesto presupuesto in lista)
            {
                listBox.Items.Add(presupuesto);
            }
        }
    }
}
