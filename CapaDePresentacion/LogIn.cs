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
    public partial class LogIn : Form
    {
        // PRE:
        // POS: crea un formulario de tipo LogIn y establece el tipo de caracter del cuadro de texto para la contraseña a '*'.
        public LogIn()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        // PRE:
        // POS: si los campos usuario y contraseña no están vacíos, creará y mostrará un nuevo formulario de tipo Gestion.
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Simulación de un sistema de login sin un sistema real de usuarios y contraseñas.
            // Cualquier combinación de usuario y contraseña pueden autenticar el sistema.
            if (!(string.IsNullOrEmpty(txtUser.Text)) && !(string.IsNullOrEmpty(txtPassword.Text)))
            {
                Gestion gestion = new Gestion(txtUser.Text);
                gestion.Show();
                this.Hide();
            }
        }

        // PRE:
        // POS: cierra la aplicación.
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
