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
    public partial class ClienteRecorrido : Form
    {
        List<MD.Cliente> clientes;

        // PRE:
        // POS: crea un nuevo formulario de tipo ClienteRecorrido.
        public ClienteRecorrido(List<MD.Cliente> clientes)
        {
            this.clientes = clientes;
            InitializeComponent();
        }

        // PRE:
        // POS: asigna al DataSource del BindingSource del BindingNavigator una lista con todos los clientes de la BD.
        private void ClienteRecorrido_Load(object sender, EventArgs e)
        {
            sourceClientes.DataSource = clientes;
        }
    }
}
