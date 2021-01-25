using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Cliente : IEquatable<Cliente>
    {
        private String nombre;
        private String dni;
        private String telefono;
        private Categoria categoria;

        // PRE: nom != null, dni != null, tel != null, cat != null.
        // POS: crea un objeto de tipo Cliente cuyo nombre es nom, DNI = dni, telefono = tel, y categoria = cat.
        public Cliente(String dni, String nom, String tel, Categoria cat)
        {
            this.nombre = nom;
            this.dni = dni;
            this.telefono = tel;
            this.categoria = cat;
        }

        // PRE: el objeto Cliente ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el nombre del cliente.
        public String Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        // PRE: el objeto Cliente ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el DNI del cliente.
        public String DNI
        {
            get
            {
                return this.dni;
            }
        }

        // PRE: el objeto Cliente ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el número de teléfono del cliente.
        // POS: set: asigna value como nueva representación como cadena del número de telefono del cliente.
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

        // PRE: el objeto Cliente ha sido inicializado previamente.
        // POS: get: devuelve la categoría del cliente, es decir, si es A, B ó C.
        // POS: set: modifica la categoría del cliente a value (que puede tomar los valores A, B ó C).
        public Categoria Categoria
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

        // PRE: el objeto Cliente ha sido inicializado previamente.
        // POS: devuelve una cadena que representa todos los datos de un cliente (nombre, dni, teléfono y categoría).
        public override String ToString()
        {
            return "Nombre: " + this.nombre + ". DNI: " + this.dni + ". Teléfono: " + this.telefono + ". Categoría: " + this.categoria + ".";
        }

        // PRE: el objeto Cliente ha sido inicializado previamente y c != null.
        // POS: devuelve TRUE si el DNI de ambos objetos comparados es el mismo, FALSE en caso contrario.
        public bool Equals(Cliente c)
        {
            return (c.dni.Equals(this.dni));
        }
    }
}