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
        public LogIn()
        {
            InitializeComponent();
            txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(txtUser.Text)) && !(string.IsNullOrEmpty(txtPassword.Text)))
            {
                Gestion gestion = new Gestion(txtUser.Text);
                gestion.Show();
                this.Hide();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
