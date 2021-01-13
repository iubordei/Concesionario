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

        public Cliente(String nom, String dni, String tel, Categoria cat)
        {
            this.nombre = nom;
            this.dni = dni;
            this.telefono = tel;
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

        public override String ToString()
        {
            return "Nombre: " + this.nombre + ". DNI: " + this.dni + ". Teléfono: " + this.telefono + ". Categoría: " + this.categoria + ".";
        }

        public bool Equals(Cliente c)
        {
            return (c.dni.Equals(this.dni));
        }
    }
}