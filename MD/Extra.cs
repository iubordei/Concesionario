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

        public Extra(String nombre, float precio)
        {
            this.nombre = nombre;
            this.precio = precio;
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

        public override String ToString()
        {
            return "Nombre: " + this.nombre + ". Precio: " + this.precio + ".";
        }


        public bool Equals(Extra e)
        {
            return (e.nombre.Equals(this.nombre));
        }
    }
}