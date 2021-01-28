using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaDePresentacion
{
    public partial class SegundaMano : UserControl
    {
        // PRE: 
        // POS: crea un control de usuario de tipo "SegundaMano".
        public SegundaMano()
        {
            InitializeComponent();
            tbFechaMatriculacion.Enabled = true;
            tbMatricula.Enabled = true;
            tbFechaMatriculacion.Text = DateTime.Today.ToString("dd/MM/yyyy");
        }

        // PRE: matricula y fecha tienen que ser != null
        // POS: crea un control de usuario de tipo "SegundaMano".
        public SegundaMano(String matricula, DateTime? fecha)
        {
            InitializeComponent();
            tbFechaMatriculacion.Text = ((DateTime)fecha).ToString("dd/MM/yyyy");
            tbMatricula.Text = matricula;
            tbFechaMatriculacion.Enabled = false;
            tbMatricula.Enabled = false;
        }

        // PRE: 
        // POS: return true si todos los controles del control son validos (estan rellenados)
        public Boolean isValido()
        {
            if (tbFechaMatriculacion.Text.Equals("") || tbMatricula.Text.Equals("")) {
                return false;
            }

            return true;
        }

        // PRE:
        // POS: devuelve la fecha introducida en su correspondiente control.
        public DateTime? getFecha()
        {
            return DateTime.Parse(tbFechaMatriculacion.Text);
        }

        // PRE:
        // POS: devuelve la matricula introducida en su correspondiente control.
        public string getMatricula()
        {
            return tbMatricula.Text;
        }
    }
}
