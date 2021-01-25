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
    public partial class VehiculoAgregarClave : Form
    {
        String accion;
        public VehiculoAgregarClave(String accion)
        {
            this.accion = accion;
            InitializeComponent();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            MD.Vehiculo vehiculo = LNVehiculo.Vehiculo.GetVehiculo(tbNumeroBastidor.Text);
            DialogResult dialogResult = new DialogResult();
            if (vehiculo != null && accion.Equals("Alta"))
            {
                 dialogResult = MessageBox.Show("¿Quieres introducir otro número?", "Ya existe un vehiculo con ese número", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            } else if(vehiculo == null && ((accion.Equals("Baja")) ||(accion.Equals("Búsqueda"))))
            {
                 dialogResult = MessageBox.Show("¿Quieres introducir otro número?", "No existe un vehiculo con ese número", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            }

            if (dialogResult == DialogResult.No)
            {
                Close();
            }

            if (vehiculo != null && accion.Equals("Baja"))
            {
                DialogResult dialogResultAviso = MessageBox.Show("¿Estás seguro que deseas dar de baja a ese vehiculo?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResultAviso == DialogResult.Yes)
                {
                    DialogResult dialogResultNotificacion;
                    if(LNVehiculo.Vehiculo.BajaVehiculo(vehiculo))
                        dialogResultNotificacion = MessageBox.Show("Vehiculo eliminado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                    this.Hide();
                
            }
            else if (vehiculo == null && accion.Equals("Alta")) 
            {
                Form vehiculoAltaBaja = new VehiculoAltaBaja(tbNumeroBastidor.Text, accion);
                vehiculoAltaBaja.ShowDialog();
            } else if(vehiculo != null && accion.Equals("Búsqueda"))
            {
                Form vehiculoAltaBaja = new VehiculoAltaBaja(tbNumeroBastidor.Text, accion);
                vehiculoAltaBaja.ShowDialog();
            }
            
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
