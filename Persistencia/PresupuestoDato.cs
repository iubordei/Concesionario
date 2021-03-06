﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class PresupuestoDato
    {
        private DateTime fechaRealizacion;
        private ClienteDato cliente;
        private VehiculoDato vehiculo;
        private EstadoDato estado;
        private Dictionary<VehiculoDato, double> valoraciones;

        // PRE: fecha != null, cliente != null, valoraciones != null
        // POS: crea un nuevo objeto de tipo PresupuestoDato con los parámetros pertinentes.
        public PresupuestoDato(DateTime fecha, ClienteDato cliente, VehiculoDato vehiculo, EstadoDato estado, Dictionary<VehiculoDato, double> valoraciones)
        {
            this.fechaRealizacion = fecha;
            this.cliente = cliente;
            this.estado = estado;
            this.valoraciones = valoraciones;
            this.vehiculo = vehiculo;
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
        public ClienteDato Cliente
        {
            get
            {
                return (this.cliente);
            }
        }

        // PRE:
        // POS: get: devuelve el vehiculo del presupuesto.
        public VehiculoDato Vehiculo
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

        // PRE:
        // POS: get: devuelve el estado en el que se encuentra el presupuesto (Aceptado, Pendiente o Desestimado).
        public EstadoDato Estado
        {
            get
            {
                return (this.estado);
            }
        }
    }
}
