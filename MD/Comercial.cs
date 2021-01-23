using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Comercial : IEquatable<Comercial>
    {
        private string nombre;
        private string dni;
        private string telefono;

        // PRE: nombre != null, dni != null, != null.
        // POS: crea un nuevo objeto de tipo Comercial con los parámetros pasados.
        public Comercial(string nombre, string dni, string telefono)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
        }

        // PRE: el objeto de tipo Comercial debe haber sido inicialziado previamente.
        // POS: devuelve una cadena que contiene el nombre del comercial.
        public string Nombre
        {
            get
            {
                return (this.nombre);
            }
        }

        // PRE: el objeto de tipo Comercial debe haber sido inicialziado previamente.
        // POS: devuelve una cadena que contiene el dni del comercial.
        public string DNI
        {
            get
            {
                return (this.dni);
            }
        }

        // PRE: el objeto de tipo Comercial debe haber sido inicialziado previamente.
        // POS: get: devuelve una cadena que contiene el número de teléfono del comercial.
        // POS: set: pone el valor del número de teléfono del comercial = value.
        public string Telefono
        {
            get
            {
                return (this.telefono);
            }

            set
            {
                this.telefono = value;
            }
        }


        // PRE: el objeto de tipo Comercial debe haber sido inicialziado previamente.
        // POS: devuelve verdadero si los DNI's de los dos comerciales son iguales, falso en caso contrario.
        public bool Equals(Comercial comercial)
        {
            return (this.dni == comercial.dni);
        }
    }
}
