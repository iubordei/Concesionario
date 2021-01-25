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
    public partial class ClienteInfo : UserControl
    {
        private string nombre;
        private string apellidos;

        public ClienteInfo()
        {
            InitializeComponent();
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                txtNombre.Text = value;
            }
        }

        public string Apellidos
        {
            get
            {
                return this.apellidos;
            }

            set
            {
                txtApellidos.Text = value;
            }
        }
    }
}
