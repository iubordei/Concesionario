using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    public class VehiculoDato
    {
        private String numeroDeBastidor;
        private String marca;
        private String modelo;
        private int potencia;
        private int año;
        private float precioRecomendado;
        private String matricula;
        private DateTime? fechaMatriculacion;
        private float? iva;
        private List<ExtraDato> extras;

        // PRE: numBastidor != null, marca != null, modelo != null, potencia > 0, año > 0; precioRecom > 0, iva > 0.
        // POS: crea un objeto de tipo VehiculoDato a partir de los parámetros pasados en la llamada al constructor.
        public VehiculoDato(String numBastidor, String marca, String modelo, int potencia, int año, float precioRecom, DateTime? fecha, float? iva, String matricula)
        {
            numeroDeBastidor = numBastidor;
            this.marca = marca;
            this.modelo = modelo;
            this.potencia = potencia;
            this.año = año;
            precioRecomendado = precioRecom;
            fechaMatriculacion = fecha;
            this.iva = iva;
            this.matricula = matricula;
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve una cadena que contiene el número de bastidor del coche.
        public String NumeroDeBastidor
        {
            get
            {
                return numeroDeBastidor;
            }
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve una cadena que contiene la marca del coche.
        public string Marca
        {
            get
            {
                return marca;
            }
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve una cadena que contiene el modelo del coche.
        public string Modelo
        {
            get
            {
                return (modelo);
            }
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve un número entero que representa la potencia del coche.
        public int Potencia
        {
            get
            {
                return (potencia);
            }
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve un número entero que representa el año del coche.
        public int Año
        {
            get
            {
                return (año);
            }
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el precio recomendado del vehículo.
        // POS: set: asigna value como el nuevo precio recomendado del vehículo.
        public float PrecioRecomendado
        {
            get
            {
                return (precioRecomendado);
            }

            set
            {
                this.precioRecomendado = value;
            }
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el IVA del vehículo, o null si no lo tiene asignado.
        // POS: set: establece value como el nuevo valor del IVA del vehículo.
        public float? Iva
        {
            get
            {
                return (iva);
            }

            set
            {
                iva = value;
            }
        }
        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve una cadena que contiene la matrícula del vehículo.
        public string Matricula
        {
            get
            {
                return (matricula);
            }
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: get: devuelve la fecha de matriculación del vehículo, null si se trata de un vehículo nuevo.
        public DateTime? FechaMatriculacion
        {
            get
            {
                return (fechaMatriculacion);
            }
        }

        // PRE: el objeto de tipo VehiculoDato ha sido inicializado previamente.
        // POS: devuelve una lista de ExtraDato que contiene todos los extras del vehiculo.
        public List<ExtraDato> Extras
        {
            get
            {
                return (this.extras);
            }
        }
    }
}
