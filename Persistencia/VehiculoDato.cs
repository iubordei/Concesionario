using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class VehiculoDato
    {
        private String numeroDeBastidor;
        private String marca;
        private String modelo;
        private int potencia;
        private int año;
        private float precioRecomendado;
        private String matricula;
        private DateTime fechaMatriculacion;
        private float iva;




        public VehiculoDato(String numBastidor, String marca, String modelo, int potencia, int año, float precioRecom, DateTime fecha, float iva, String matricula)
        {
            numeroDeBastidor = numBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.año = año;
            precioRecomendado = precioRecom;
            fechaMatriculacion = fecha;
            this.iva = IVA;
            this.matricula = matricula;
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
        }
        public DateTime FechaMatriculacion
        {
            get
            {
                return fechaMatriculacion;
            }
        }
        public float IVA
        {
            get
            {
                return iva;
            }
        }

        public String Matricula
        {
            get
            {
                return matricula;
            }
        }
    }
}
