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
        private CategoriaDato categoria;

        public ClienteDato(String dni, String nombre, String telefono, CategoriaDato cat)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.categoria = cat;
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
