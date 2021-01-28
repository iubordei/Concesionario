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
        private string accion;
        private string numeroBastidor;
        private Nuevo nuevo = new Nuevo();
        private SegundaMano segundaMano = new SegundaMano();
        private MD.Vehiculo vehiculo;

        // PRE:
        // POS: crea un formulario de tipo "VehiculoAltaBaja".
        public VehiculoAltaBaja()
        {
            InitializeComponent();
        }

        // PRE:
        // POS: crea un formulario de tipo "VehiculoAltaBaja".
        public VehiculoAltaBaja(String numeroBastidor, String accion)
        {
            this.accion = accion;

            this.numeroBastidor = numeroBastidor;
            this.Text = accion + "de un vehiculo";

            InitializeComponent();
            setControlsEnabled(true);
            if (accion.Equals("Búsqueda"))
            {
                vehiculo = LNVehiculo.Vehiculo.GetVehiculo(numeroBastidor);
                tbNumeroBastidor.Text = numeroBastidor;
                tbAño.Text = vehiculo.Año.ToString();
                tbMarca.Text = vehiculo.Marca;
                tbModelo.Text = vehiculo.Modelo;
                tbPotencia.Text = vehiculo.Potencia.ToString();
                tbPrecioRecomendado.Text = vehiculo.PrecioRecomendado.ToString();
                if (vehiculo.GetType() == typeof(MD.SegundaMano))
                {
                    rbSegundaMano.Checked = true;
                    segundaMano = new SegundaMano(((MD.SegundaMano)vehiculo).Matricula, ((MD.SegundaMano)vehiculo).FechaMatriculacion);
                    segundaMano.Location = new Point(390, 151);
                    segundaMano.Show();
                    Controls.Add(segundaMano);
                }
                if (vehiculo.GetType() == typeof(MD.Nuevo))
                {
                    rbNuevo.Checked = true;
                    nuevo = new Nuevo(((MD.Nuevo)vehiculo).Extras);
                    nuevo.Location = new Point(390, 151);
                    nuevo.Show();
                    Controls.Add(nuevo);
                }
                setControlsEnabled(false);
            }
            tbNumeroBastidor.Text = numeroBastidor;
        }

        // PRE: variable booleana con valor true o false.
        // POS: Todos los controles estan activados o desactivados si el parametro es true o false.
        public void setControlsEnabled(bool estado)
        {
            tbNumeroBastidor.Enabled = estado;
            tbModelo.Enabled = estado;
            tbMarca.Enabled = estado;
            tbAño.Enabled = estado;
            tbPotencia.Enabled = estado;
            tbPrecioRecomendado.Enabled = estado;
            rbSegundaMano.Enabled = estado;
            rbNuevo.Enabled = estado;
        }

        // PRE:
        // POS: muestra en el formulario un control de usuario de tipo "Nuevo"
        private void rbNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbNuevo.Checked && !accion.Equals("Búsqueda"))
            {
                segundaMano.Hide();
                nuevo = new Nuevo();
                nuevo.Location = new Point(390, 158);
                nuevo.Show();
                Controls.Add(nuevo);
            }

        }

        // PRE:
        // POS: muestra en el formulario un control de usuario de tipo "SegundaMano"
        private void rbSegundaMano_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSegundaMano.Checked && !accion.Equals("Búsqueda"))
            {
                nuevo.Hide();
                segundaMano = new SegundaMano();
                segundaMano.Location = new Point(390, 151);
                segundaMano.Show();
                Controls.Add(segundaMano);
            }
        }

        // PRE:
        // POS: añade al sistema un nuevo vehiculo con los valores seleccionados en los distintos controles
        // POS: del formulario.
        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (tbNumeroBastidor.Text.Equals("") || tbMarca.Text.Equals("") || tbModelo.Text.Equals("") || tbPotencia.Text.Equals("") || tbPrecioRecomendado.Text.Equals("") ||
                (((!(rbNuevo.Checked)) || (!nuevo.isValido())) && ((!(rbSegundaMano.Checked)) || (!segundaMano.isValido()))))
            {
                DialogResult dialogResult = MessageBox.Show("Debes rellenar todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!(verificarCampo(tbPotencia) && verificarCampo(tbPrecioRecomendado) && verificarCampo(tbAño)))
            {
                return;
            }

            if (rbNuevo.Checked && nuevo.isValido())
            {
                vehiculo = new MD.Nuevo(tbNumeroBastidor.Text, tbMarca.Text, tbModelo.Text, int.Parse(tbPotencia.Text), int.Parse(tbAño.Text), float.Parse(tbPrecioRecomendado.Text), nuevo.getExtras(), 10);
            }
            else if (rbSegundaMano.Checked && segundaMano.isValido())
            {
                vehiculo = new MD.SegundaMano(tbNumeroBastidor.Text, tbMarca.Text, tbModelo.Text, int.Parse(tbPotencia.Text), int.Parse(tbAño.Text), float.Parse(tbPrecioRecomendado.Text), segundaMano.getMatricula(), segundaMano.getFecha(), 21);
            }

            DialogResult dialogResultInformacion;
            if (LNVehiculo.Vehiculo.AltaVehiculo(vehiculo))
                dialogResultInformacion = MessageBox.Show("Vehiculo añadido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();

        }

        // PRE:
        // POS: copmrueba si un cuadro de texto que debería contener un valor númerico contiene
        // POS: datos válidos. Si son válidos devuelve true, en caso contrario false y selecciona el texto incorrecto.
        private bool verificarCampo(TextBox tb)
        {
            int prueba;
            if (!(int.TryParse(tb.Text, out prueba)))
            {
                tb.SelectAll();
                tb.Focus();
                DialogResult dialogResult = MessageBox.Show("Datos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (false);
            }

            return (true);
        }

        // PRE:
        // POS: Se cierra el formulario.
        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
