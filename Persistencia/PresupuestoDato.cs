using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class PresupuestoDato
    {
        private DateTime fechaRealizacion;
        private string cliente;
        private string vehiculo;
        private EstadoDato estado;
        private Dictionary<VehiculoDato, double> valoraciones;

        // PRE:
        // POS: crea un nuevo objeto de tipo PresupuestoDato con los parámetros pertinentes.
        public PresupuestoDato(DateTime fecha, string cliente, string vehiculo, EstadoDato estado, Dictionary<VehiculoDato, double> valoraciones)
        {
            this.fechaRealizacion = fecha;
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.estado = estado;
            this.valoraciones = valoraciones;
        }

        // PRE:
        // POS: get: devuelve la fecha de ralización del presupuesto.
        public DateTime FechaRealizacion
        {
            get
            {
                return (this.fechaRealizacion);
            }
        }

        // PRE:
        // POS: get: devuelve el cliente del presupuesto.
        public string Cliente
        {
            get
            {
                return (this.cliente);
            }
        }

        // PRE:
        // POS: get: devuelve el vehiculo del presupuesto.
        public string Vehiculo
        {
            get
            {
                return (this.vehiculo);
            }
        }

        // PRE:
        // POS: get: devuelve el diccionario que contiene las parejas VehiculoDato-precio (valoraciones) del presupuesto.
        public Dictionary<VehiculoDato, double> Valoraciones
        {
            get
            {
                return (this.valoraciones);
            }
        }
    }
}
