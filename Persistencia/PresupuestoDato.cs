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
        private string estado;
        private Dictionary<MD.Vehiculo, double> valoraciones;

        public PresupuestoDato(DateTime fecha, string cliente, string vehiculo, string estado, Dictionary<MD.Vehiculo, double> valoraciones)
        {
            this.fechaRealizacion = fecha;
            this.cliente = cliente;
            this.vehiculo = vehiculo;
            this.estado = estado;
            this.valoraciones = valoraciones;
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
    }
}
