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

        // PRE: nombre != null, precio > 0.
        // POS: crea un objeto ExtraDato con nombre = "nombre" y precio = "precio".
        public ExtraDato(string nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        // PRE: el objeto ExtraDato ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el nombre del extra.
        // POS: set: asigna value como nuevo nombre del extra.
        public string Nombre
        {
            get
            {
                return (this.nombre);
            }

            set
            {
                this.nombre = value;
            }
        }

        // PRE: el objeto ExtraDato ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el precio del extra.
        // POS: set: asigna value como nuevo precio del extra.
        public float Precio
        {
            get
            {
                return (this.precio);
            }

            set
            {
                this.precio = value;
            }
        }
    }
}
