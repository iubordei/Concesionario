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
        public SegundaMano()
        {
            InitializeComponent();
            tbFechaMatriculacion.Enabled = true;
            tbMatricula.Enabled = true;
        }

        public SegundaMano(String matricula, DateTime? fecha)
        {
            InitializeComponent();
            tbFechaMatriculacion.Text = ((DateTime)fecha).ToString("dd-MM-yyyy");
            tbMatricula.Text = matricula;
            tbFechaMatriculacion.Enabled = false;
            tbMatricula.Enabled = false;
        }

        public Boolean isValido()
        {
            if (tbFechaMatriculacion.Text.Equals("") || tbMatricula.Text.Equals("")) {
                return false;
            }

            return true;
        }

        public DateTime? getFecha()
        {
            return DateTime.Parse(tbFechaMatriculacion.Text);
        }

        public string getMatricula()
        {
            return tbMatricula.Text;
        }
    }
}
