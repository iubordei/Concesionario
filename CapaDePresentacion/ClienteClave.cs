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
    public partial class ClienteClave : Form
    {
        private string accion;

        // PRE: accion != null.
        // POS: inicializa un formulario de tipo ClienteClave con el parámetro accion, que indica cual será el cometido de la instancia
        // POS: generada del formulario (alta, baja o búsqueda).
        public ClienteClave(String accion)
        {
            InitializeComponent();
            this.accion = accion;
        }

        // PRE:
        // POS: al apretar el botón aceptar, según la acción asignada al formulario, se abrirá el correspondiente formulario para continuar con la alta,
        // POS: baja o búsqueda, sobre el DNI del cliente introducido.
        private void btAceptar_Click(object sender, EventArgs e)
        {
            DialogResult res = new DialogResult();

            if (accion.Equals("Alta"))
            {
                if (LNCliente.Cliente.ExisteCliente(txbDNI.Text))
                {
                    res = MessageBox.Show("¿Quieres introducir otro?", "Ya existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                }
                else
                {
                    ClienteAltaBaja altaBaja = new ClienteAltaBaja(txbDNI.Text, accion);
                    altaBaja.ShowDialog();
                }
            }
            
            if (accion.Equals("Baja") || accion.Equals("Busqueda"))
            {
                if (LNCliente.Cliente.ExisteCliente(txbDNI.Text))
                {
                    ClienteAltaBaja altaBaja = new ClienteAltaBaja(txbDNI.Text, accion);
                    altaBaja.ShowDialog();
                }
                else
                {
                    res = MessageBox.Show("¿Quieres introducir otro?", "No existe un cliente con ese DNI", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
            }

            if (res == DialogResult.No)
            {
                Close();
            }
        }

        // PRE:
        // POS: cierra el formulario actual.
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
