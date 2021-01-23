using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Extra : IEquatable<Extra>
    {
        private String nombre;
        private float precio;

        // PRE: nombre != null, precio > 0.
        // POS: crea un objeto Extra de nombre = "nombre" y precio = "precio".
        public Extra(String nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        // PRE: el objeto Extra ha sido inicializado previamente.
        // POS: get: devuelve una representación en forma de cadena del nombre del extra del vehículo.
        // POS: set: cambia el nombre del extra a value.
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

        // PRE: el objeto Extra ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el precio del extra.
        // POS: set: asigna value como el nuevo precio del extra.
        public float Precio
        {
            get
            {
                return this.precio;
            }

            set
            {
                this.precio = value;
            }
        }

        // PRE: el objeto Extra ha sido inicializado previamente.
        // POS: devuelve una cadena que representa a un extra (contiene su nombre y precio, formateado en una sola línea).
        public override String ToString()
        {
            return "Nombre: " + this.nombre + ". Precio: " + this.precio + ".";
        }


        // PRE: el objeto Extra ha sido inicializado previamente y e != null.
        // POS: devuelve TRUE si ambos extras tienen el mismo nombre, FALSE en caso contrario.
        public bool Equals(Extra e)
        {
            return (e.nombre.Equals(this.nombre));
        }
    }
}