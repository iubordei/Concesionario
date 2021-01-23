using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public abstract class Vehiculo : IEquatable<Vehiculo>
    {
        private String numeroDeBastidor;
        private String marca;
        private String modelo;
        private int potencia;
        private int año;
        private float precioRecomendado;

        // PRE: numBastidor != null, marca != null, modelo != null, potencia > 0, año > 0, precioRecom > 0.
        // POS: inicializa los valores numeroDeBastidor, marca, modelo, potencia, año y precioRecomendado con los valores pasados al constructor.
        public Vehiculo(String numBastidor, String marca, String modelo, int potencia, int año, float precioRecom)
        {
            numeroDeBastidor = numBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.año = año;
            precioRecomendado = precioRecom;
        }

        // PRE: numBastidor != null.
        // POS: crea un objeto Vehículo cuyo número de bastidor sea numBastidor.
        public Vehiculo(String numBastidor)
        {
            numeroDeBastidor = numBastidor;
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el número de bastidor del vehículo.
        public String NumeroDeBastidor
        {
            get
            {
                return numeroDeBastidor;
            }
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa la marca del vehículo.
        public String Marca
        {
            get
            {
                return marca;
            }
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa el modelo del vehículo.
        public String Modelo
        {
            get
            {
                return modelo;
            }
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente.
        // POS: get: devuelve un entero que representa la potencia del vehículo.
        public int Potencia
        {
            get
            {
                return potencia;
            }
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente.
        // POS: get: devuelve un entero que representa el año del vehículo.
        public int Año
        {
            get
            {
                return año;
            }
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el precioRecomendado del vehículo.
        // POS: set: asigna value como el precio recomendado del vehículo.
        public float PrecioRecomendado
        {
            get
            {
                return precioRecomendado;
            }
            set
            {
                precioRecomendado = value;
            }
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente, y other != null.
        // POS: devuelve TRUE si los números de bastidor de ambos vehículos coinciden, FALSE en caso contrario.
        public bool Equals(Vehiculo other)
        {
            return (other.NumeroDeBastidor.Equals(this.NumeroDeBastidor));
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el PVP del vehículo, o null si no ha sido asignado.
        public virtual float? PVP
        {
            get
            {
                return precioRecomendado;
            }
        }

        // PRE: el objeto Vehiculo ha sido inicializado previamente.
        // POS: devuelve una cadena que representa a un vehículo (marca, modelo, potencia, año...).
        public override string ToString()
        {
            String ret = "";
            ret += "Numero de bsatidor: " + NumeroDeBastidor + ", marca: " + Marca + ", modelo: " + Modelo + ", potencia: " + Potencia +
                ", año: " + Año + ", precio recomendado: " + PrecioRecomendado;
            return ret;
        }
    }
}