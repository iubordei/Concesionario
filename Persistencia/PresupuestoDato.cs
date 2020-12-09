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
        private string cliente;
        private string vehiculo;
        private string estado;
        private string valoracion;

        public PresupuestoDato(DateTime fecha, string cliente, string vehiculo, string estado, string valoracion)
        {
            this.fechaRealizacion = fecha;
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.estado = estado;
            this.valoracion = valoracion;
        }

        public DateTime FechaRealizacion
        {
            get
            {
                return (this.fechaRealizacion);
            }
        }

        public string Cliente
        {
            get
            {
                return (this.cliente);
            }
        }

        public string Vehiculo
        {
            get
            {
                return (this.vehiculo);
            }
        }

        public string Estado
        {
            get
            {
                return (this.estado);
            }
        }

        public string Valoracion
        {
            get
            {
                return (this.valoracion);
            }
        }
    }
}