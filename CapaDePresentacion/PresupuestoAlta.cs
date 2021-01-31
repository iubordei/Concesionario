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
        private Dictionary<MD.Vehiculo, double> valoraciones = new Dictionary<MD.Vehiculo, double>();
        private BindingSource sourceClientes;
        private BindingSource sourceVehiculos;

        private Dictionary<string, MD.Cliente> clientes;
        private Dictionary<string, MD.Vehiculo> vehiculos;

        // PRE:
        // POS: crea un formuilario de tipo PresupuestoAlta.
        public PresupuestoAlta()
        {
            InitializeComponent();
            sourceClientes = new BindingSource();
            sourceVehiculos = new BindingSource();
        }

        // PRE:
        // POS: durante el proceso de carga del formulario genera las fuentes de datos para
        // POS: las listas de clientes y vehiculos.
        private void PresupuestoAlta_Load(object sender, EventArgs e)
        {
            // Clientes
            clientes = new Dictionary<string, MD.Cliente>();
            foreach (MD.Cliente cliente in LNCliente.Cliente.VerClientes())
            {
                clientes.Add(cliente.DNI + ", " + cliente.Nombre, cliente);
            }

            sourceClientes.DataSource = clientes.Keys;
            listBoxClientes.DataSource = sourceClientes;
            listBoxClientes.Refresh();

            // Vehiculos
            vehiculos = new Dictionary<string, MD.Vehiculo>();
            foreach (MD.Vehiculo vehiculo in LNVehiculo.Vehiculo.GetAllVehiculos())
            {
                vehiculos.Add(vehiculo.Marca + " " + vehiculo.Modelo + ", " + vehiculo.NumeroDeBastidor, vehiculo);
            }

            sourceVehiculos.DataSource = vehiculos.Keys;
            listBoxVehiculos.DataSource = sourceVehiculos;
            listBoxVehiculos.Refresh();

            listBoxClientes.SelectedIndex = 0;
            listBoxVehiculos.SelectedIndex = 0;
        }

        // PRE:
        // POS: añade al sistema un nuevo presupuesto con los valores seleccionados en los distintos controles
        // POS: del formulario (cliente, vehiculos y precios para las valoraciones) cuya fecha es el momento de
        // POS: creación del formulario.
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (listBoxClientes.SelectedIndex != -1)
            {
                if (valoraciones.Count > 0)
                {
                    MD.Cliente cliente = clientes[listBoxClientes.SelectedItem.ToString()];
                    LNPresupuesto.Presupuesto.CrearPresupuesto(DateTime.Now, cliente, valoraciones);

                    DialogResult res = new DialogResult();
                    res = MessageBox.Show("Presupuesto creado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    res = MessageBox.Show("¿Quieres hacer otro presupuesto?", "Continuación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    switch (res)
                    {
                        case DialogResult.Yes:
                            this.Hide();
                            PresupuestoAlta alta = new PresupuestoAlta();
                            alta.ShowDialog();
                            break;
                    }
                    this.Close();

                }
                else
                {
                    MessageBox.Show("No se han añadido valoraciones");
                }
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún cliente");
            }
        }

        // PRE:
        // POS: cierra el formulario de tipo PresupustoAlta.
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PRE:
        // POS: añade una pareja vehículo-precio al diccionario de valoraciones que será utilizado para
        // POS: generar el nuevo presupuesto.
        private void btnAgregarValoracion_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtValoracion.Text))
            {
                MessageBox.Show("No se ha introducido un precio a la valoración");
            }
            else
            {
                double precio;
                if (double.TryParse(txtValoracion.Text, out precio) || txtValoracion.Text.Equals(""))
                {
                    if (listBoxVehiculos.SelectedIndex != -1)
                    {
                        MD.Vehiculo vehiculo = vehiculos[listBoxVehiculos.SelectedItem.ToString()];
                        if (valoraciones.ContainsKey(vehiculo))
                        {
                            MessageBox.Show("El vehículo seleccionado ya ha sido introducido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            valoraciones.Add(vehiculo, precio);
                            MessageBox.Show("Se ha añadido el vehículo a la valoración", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtValoracion.Clear();
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha seleccionado ningún vehículo");
                    }
                }
                else
                {
                    MessageBox.Show("El valor introducida no es correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
