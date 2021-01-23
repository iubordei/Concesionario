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

        // PRE: dni != null, nombre != null, telefono != null, cat != null.
        // POS: crea un ClienteDato con DNI = dni, nombre = "nombre", telefono = "telefono" y categoria = cat.
        public ClienteDato(String dni, String nombre, String telefono, CategoriaDato cat)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.telefono = telefono;
            this.categoria = cat;
        }

        // PRE: el objeto ClienteDato ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el nombre del cliente.
        public String Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        // PRE: el objeto ClienteDato ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el DNI del cliente.
        public String DNI
        {
            get
            {
                return this.dni;
            }
        }

        // PRE: el objeto ClienteDato ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el telefono del cliente.
        // POS: set: modifica el número de teléfono del cliente a value.
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

        // PRE: el objeto ClienteDato ha sido inicializado previamente.
        // POS: get: devuelve un objeto CategoriaDato que contiene la categoria del cliente (A, B ó C).
        // POS: set: cambia la categoría del cliente a value.
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