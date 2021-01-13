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

        public Vehiculo(String numBastidor, String marca, String modelo, int potencia, int año, float precioRecom)
        {
            numeroDeBastidor = numBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.año = año;
            precioRecomendado = precioRecom;
        }

        public Vehiculo(String numBastidor)
        {
            numeroDeBastidor = numBastidor;
        }

        public String NumeroDeBastidor
        {
            get
            {
                return numeroDeBastidor;
            }
        }

        public String Marca
        {
            get
            {
                return marca;
            }
        }

        public String Modelo
        {
            get
            {
                return modelo;
            }
        }

        public int Potencia
        {
            get
            {
                return potencia;
            }
        }

        public int Año
        {
            get
            {
                return año;
            }
        }

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

        public bool Equals(Vehiculo other)
        {
            return (other.NumeroDeBastidor.Equals(this.NumeroDeBastidor));
        }

        public virtual float? PVP
        {
            get
            {
                return precioRecomendado;
            }
        }

        public override string ToString()
        {
            String ret = "";
            ret += "Numero de bsatidor: " + NumeroDeBastidor + ", marca: " + Marca + ", modelo: " + Modelo + ", potencia: " + Potencia +
                ", año: " + Año + ", precio recomendado: " + PrecioRecomendado;
            return ret;
        }
    }
}