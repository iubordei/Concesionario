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
    public partial class ClienteAltaBaja : Form
    {
        private string accion;
        private string DNI;

        // PRE:
        // POS: crea un formulario ClienteAltaBaja.
        public ClienteAltaBaja()
        {
            InitializeComponent();
        }

        // PRE:
        // POS: crea un formulario ClienteAltaBaja, que según el parámetro accion será usado para dar de alta a un cliente,
        // POS: dar de baja o buscar la información almacenada de un cliente mediante su DNI.
        public ClienteAltaBaja(String DNI, String accion)
        {
            InitializeComponent();
            this.accion = accion;
            this.DNI = DNI;
            txbDNI.Text = DNI;

            // Alta
            if (accion.Equals("Alta"))
            {
                this.Text = "Alta de un cliente";
                txbDNI.ReadOnly = true;
            }

            // Baja
            if (accion.Equals("Baja"))
            {
                MD.Cliente cliente = LNCliente.Cliente.GetCliente(this.DNI);
                this.Text = "Baja de un cliente";
                txbNombre.Text = cliente.Nombre;
                txbTelefono.Text = cliente.Telefono;
                if (cliente.Categoria.Equals(MD.Categoria.A))
                {
                    rbA.Checked = true;
                }
                if (cliente.Categoria.Equals(MD.Categoria.B))
                {
                    rbB.Checked = true;
                }
                if (cliente.Categoria.Equals(MD.Categoria.C))
                {
                    rbC.Checked = true;
                }
                txbDNI.ReadOnly = true;
                txbNombre.ReadOnly = true;
                txbTelefono.ReadOnly = true;
                rbA.Enabled = false;
                rbB.Enabled = false;
                rbC.Enabled = false;
            }

            // Busqueda
            if (accion.Equals("Busqueda"))
            {
                MD.Cliente cliente = LNCliente.Cliente.GetCliente(this.DNI);
                this.Text = "Datos del cliente";
                txbNombre.Text = cliente.Nombre;
                txbTelefono.Text = cliente.Telefono;
                if (cliente.Categoria.Equals(MD.Categoria.A))
                {
                    rbA.Checked = true;
                }
                if (cliente.Categoria.Equals(MD.Categoria.B))
                {
                    rbB.Checked = true;
                }
                if (cliente.Categoria.Equals(MD.Categoria.C))
                {
                    rbC.Checked = true;
                }
                txbDNI.ReadOnly = true;
                txbNombre.ReadOnly = true;
                txbTelefono.ReadOnly = true;
                rbA.Enabled = false;
                rbB.Enabled = false;
                rbC.Enabled = false;
                btCancelar.Hide();
                btAceptar.Location = new Point(117, 249);
            }
        }

        // PRE:
        // POS: según la acción pedida por el usuario (alta, baja o búsqueda) el botón aceptar guardará, eliminará o mostrará
        // POS: respectivamente la información afectada.
        private void btAceptar_Click(object sender, EventArgs e)
        {
            // Alta
            if (accion.Equals("Alta"))
            {
                if (string.IsNullOrEmpty(txbNombre.Text))
                {
                    MessageBox.Show("Debes introducir un nombre para el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (txbTelefono.Text.Equals(""))
                    {
                        MessageBox.Show("Debes introducir un telefono para el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        if (!rbA.Checked && !rbB.Checked && !rbC.Checked)
                        {
                            MessageBox.Show("Debes marcar una categoría", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MD.Categoria cat = MD.Categoria.A;
                            if (rbA.Checked)
                            {
                                cat = MD.Categoria.A;
                            }
                            if (rbB.Checked)
                            {
                                cat = MD.Categoria.B;
                            }
                            if (rbC.Checked)
                            {
                                cat = MD.Categoria.C;
                            }

                            LNCliente.Cliente.AltaCliente(new MD.Cliente(txbDNI.Text, txbNombre.Text, txbTelefono.Text, cat));
                            btCancelar.PerformClick();
                        }
                    }
                }
            }

            // Baja
            if (accion.Equals("Baja"))
            {
                DialogResult res = new DialogResult();
                res = MessageBox.Show("¿Está seguro que desea dar de baja a ese cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    MD.Cliente cliente = LNCliente.Cliente.GetCliente(this.DNI);
                    LNCliente.Cliente.BajaCliente(cliente);
                    DialogResult res2 = new DialogResult();
                    res2 = MessageBox.Show("Cliente eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (res == DialogResult.No)
                {
                    this.Close();
                }

                this.Close();
            }

            // Busqueda
            if (accion.Equals("Busqueda"))
            {
                this.Close();
            }
        }

        // PRE:
        // POS: cierra el formulario.
        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
