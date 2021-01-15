using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class ExtraDato
    {
        private string nombre;
        private float precio;

        public ExtraDato(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string Nombre
        {
            get
            {
                return (this.nombre);
            }
        }

        public float Precio
        {
            get
            {
                return (this.precio);
            }
        }
    }
}
