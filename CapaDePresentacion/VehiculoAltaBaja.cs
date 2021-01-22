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
    public partial class VehiculoAltaBaja : Form
    {
        String accion;
        String numeroBastidor;
        UserControl userControl;
        public VehiculoAltaBaja()
        {
            InitializeComponent();
        }

        public VehiculoAltaBaja(String numeroBastidor, String accion)
        {
            this.accion = accion;
            this.numeroBastidor = numeroBastidor;
            this.Text = accion + "de un vehiculo";
            tbNumeroBastidor.Text = numeroBastidor;
            InitializeComponent();
        }

        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNuevo.Checked)
            {
                userControl = new Nuevo();
                userControl.Location = new Point(390, 151);
                userControl.Show();
            }
        }

        private void rbSegundaMano_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSegundaMano.Checked)
            {
                userControl = new SegundaMano();
                userControl.Location = new Point(390, 151);
                userControl.Show();
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            MD.Vehiculo vehiculo;
            if (tbNumeroBastidor.Text.Equals("") || tbMarca.Text.Equals("") || tbModelo.Text.Equals("") || tbPotencia.Text.Equals("") || tbPrecioRecomendado.Text.Equals("") ||
                ((!(rbNuevo.Checked)) && (!(rbSegundaMano.Checked))))
            {
                DialogResult dialogResult = MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (rbNuevo.Checked && userControl.)
            {

            }


            if (rbNuevo.Checked)
            {

            }

            if (accion.Equals("Alta"))
            {
                LNVehiculo.Vehiculo.AltaVehiculo(vehiculo);
            }
            else if (accion.Equals("Baja"))
            {
                LNVehiculo.Vehiculo.BajaVehiculo(vehiculo);
            }
        }
    }
}
