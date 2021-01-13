using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ClienteDato
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

        public String Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public String DNI
        {
            get
            {
                return this.dni;
            }
        }

        public String Telefono
        {
            get
            {
                return this.telefono;
            }

            set
            {
                this.telefono = value;
            }
        }

        public CategoriaDato Categoria
        {
            get
            {
                return this.categoria;
            }

            set
            {
                this.categoria = value;
            }
        }
    }
}