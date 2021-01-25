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
    public partial class ClienteBusquedaDNI : Form
    {
        private BindingSource sourceClientes;
        private Dictionary<string, MD.Cliente> clientes;

        // PRE:
        // POS: inicializa un formulario de tipo ClienteBusquedaDNI (crea los orígenes de datos para el ComboBox).
        public ClienteBusquedaDNI()
        {
            InitializeComponent();

            sourceClientes = new BindingSource();
            clientes = new Dictionary<string, MD.Cliente>();
            foreach (MD.Cliente cliente in LNCliente.Cliente.VerClientes())
            {
                clientes.Add(cliente.DNI, cliente);
            }

            sourceClientes.DataSource = clientes.Keys;
            comboDNIs.DataSource = sourceClientes;
        }

        // PRE:
        // POS: cuando se selecciona un objeto diferente del ComboBox, es decir, cuando cambia el índice del objeto seleccionado
        // POS: se actualiza el control de usuario InfoCliente con la información del cliente seleccionado.
        private void comboDNIs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (clientes.Count > 0)
            {
                MD.Cliente seleccionado = clientes[comboDNIs.Text];
                string[] trozos = seleccionado.Nombre.Split(' ');
                string nombre = trozos[0];
                string apellidos = "";
                if (trozos.Length > 1)
                {
                    for (int i = 1; i < trozos.Length; i++)
                    {
                        apellidos += trozos[i] + " ";
                    }
                }

                clienteInfo1.Nombre = nombre;
                clienteInfo1.Apellidos = apellidos;
            }
            else
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("No hay clientes registrados en el sistema", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // PRE:
        // POS: cierra el formulario actual de búsqueda.
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
