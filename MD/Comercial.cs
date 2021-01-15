using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Comercial
    {
        private string nombre;
        private string dni;
        private string telefono;

        public Comercial(string nombre, string dni, string telefono)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
        }

        public string Nombre
        {
            get
            {
                return (this.nombre);
            }
        }

        public string DNI
        {
            get
            {
                return (this.dni);
            }
        }

        public string Telefono
        {
            get
            {
                return (this.telefono);
            }
        }
    }
}
