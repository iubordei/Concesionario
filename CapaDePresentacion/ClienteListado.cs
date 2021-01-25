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
    public partial class ClienteListado : Form
    {
        private BindingSource sourceDNIs;
        private BindingSource sourceNombres;
        private BindingSource sourceCategorias;
        private Dictionary<MD.Cliente, string> dnis;
        private Dictionary<MD.Cliente, string> nombres;
        private Dictionary<MD.Cliente, string> categorias;
        private List<MD.Cliente> clientes;

        // PRE:
        // POS: crea un formulario de tipo ClienteListado, que se puede utilizar para ver información relativa a los clientes
        // POS: ordenada según un criterio de ordenación (DNI, nombre, categoría).
        public ClienteListado(List<MD.Cliente> clientes)
        {
            InitializeComponent();
            this.clientes = clientes;
        }

        // PRE:
        // POS: cierra el formulario de listado de clientes.
        private void btnListadoCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // PRE:
        // POS: recupera la información relativa a todos los clientes que se van a mostrar (DNI, Nombre e Importe).
        private void ClienteListado_Load(object sender, EventArgs e)
        {
            // Inicializar BindingSource
            sourceNombres = new BindingSource();
            sourceCategorias = new BindingSource();
            sourceDNIs = new BindingSource();

            generarDiccionarios();

            // Source DNI
            sourceDNIs = new BindingSource();
            sourceDNIs.DataSource = dnis.Values;
            lboxDni.DataSource = sourceDNIs;

            // Source Nombre
            sourceNombres = new BindingSource();
            sourceNombres.DataSource = nombres.Values;
            lboxNombre.DataSource = sourceNombres;

            // Source Categoria
            sourceCategorias = new BindingSource();
            sourceCategorias.DataSource = categorias.Values;
            lboxCategoria.DataSource = sourceCategorias;
        }

        // PRE:
        // POS: ordena los clientes de manera creciente por DNI.
        private void btnListadoDNI_Click(object sender, EventArgs e)
        {
            LNCliente.Cliente.Ordenar(clientes, delegate (MD.Cliente c1, MD.Cliente c2) { return (c1.DNI.CompareTo(c2.DNI)); });
            refrescarListas();
        }

        // PRE:
        // POS: ordena los clientes de manera alfabética por nombre.
        private void btnListadoNombre_Click(object sender, EventArgs e)
        {
            LNCliente.Cliente.Ordenar(clientes, delegate (MD.Cliente c1, MD.Cliente c2) { return ((c1.Nombre.Substring(c1.Nombre.IndexOf(' ') != -1 ? c1.Nombre.IndexOf(' ') : 0)).CompareTo(c2.Nombre.Substring(c2.Nombre.IndexOf(' ') != -1 ? c2.Nombre.IndexOf(' ') : 0))); });
            refrescarListas();
        }

        // PRE:
        // POS: ordena los clientes de manera ascendente por la suma de los presupuestos del mes actual.
        private void btnListadoCategoria_Click(object sender, EventArgs e)
        {
            LNCliente.Cliente.Ordenar(clientes, delegate (MD.Cliente c1, MD.Cliente c2) { return (c1.Categoria - c2.Categoria); });
            refrescarListas();
        }

        // PRE:
        // POS: refrsca el estado de los ListBox del formulario, para mostrar los resultados con el método de ordenación solicitado.
        private void refrescarListas()
        {
            dnis.Clear();
            nombres.Clear();
            categorias.Clear();

            generarDiccionarios();

            // Reasignar DataSource para actualizar las listas.
            sourceDNIs.DataSource = dnis.Values;
            lboxDni.DataSource = sourceDNIs;

            sourceNombres.DataSource = nombres.Values;
            lboxNombre.DataSource = sourceNombres;

            sourceCategorias.DataSource = categorias.Values;
            lboxCategoria.DataSource = sourceCategorias;
        }

        // PRE:
        // POS: inicializa los diccionarios como nuevos diccionarios y añade, por cada cliente, la información pertinente a cada apartado.
        private void generarDiccionarios()
        {
            dnis = new Dictionary<MD.Cliente, string>();
            nombres = new Dictionary<MD.Cliente, string>();
            categorias = new Dictionary<MD.Cliente, string>();

            foreach (MD.Cliente cliente in clientes)
            {
                // DNI
                dnis.Add(cliente, cliente.DNI);

                // Nombre
                string[] trozos = cliente.Nombre.Split(' ');
                string nombre = trozos[0];
                string apellidos = "";
                if (trozos.Length > 1)
                {
                    for (int i = 1; i < trozos.Length; i++)
                    {
                        apellidos += trozos[i] + " ";
                    }
                }
                apellidos = apellidos.Trim();

                nombres.Add(cliente, apellidos + ", " + nombre);

                // Categoría
                categorias.Add(cliente, cliente.Categoria.ToString());
            }
        }
    }
}
