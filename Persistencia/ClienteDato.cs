using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class ClienteDato
    {
        private String dni;
        private String nombre;
        private String telefono;
        private Cat categoria;

        public ClienteDato(String dni, String nombre, String telefono, Cat cat)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.categoria = cat;
        }

        public enum Cat
        {
            A,
            B,
            C
        }

        public String DNI
        {
            get
            {
                return this.dni;
            }
        }
    }
}
