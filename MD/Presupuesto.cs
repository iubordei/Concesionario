using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Presupuesto : IEquatable<Presupuesto>
    {
        private DateTime fechaRealizacion;
        private Cliente cliente;
        private Dictionary<Vehiculo, double> valoraciones;
        private Estado estado;
        private Vehiculo vehiculoComprado;


        public Presupuesto(DateTime fecha, Cliente cliente, Vehiculo vehiculo)
        {
            this.fechaRealizacion = fecha;
            this.cliente = cliente;
            this.estado = Estado.Pendiente;
            this.vehiculoComprado = vehiculo;
            this.valoraciones = new Dictionary<Vehiculo, double>();
        }

        public Cliente Cliente
        {
            get
            {
                return (this.cliente);
            }
        }

        public Vehiculo Vehiculo
        {
            get
            {
                return (this.vehiculoComprado);
            }

            set
            {
                this.vehiculoComprado = value;
            }
        }

        public DateTime FechaRealizacion
        {
            get
            {
                return (this.fechaRealizacion);
            }
        }

        public Estado Estado
        {
            get
            {
                return (this.estado);
            }

            set
            {
                this.estado = value;
            }
        }

        public Dictionary<Vehiculo, double> Valoracion
        {
            get
            {
                return (this.valoraciones);
            }

            set
            {
                this.valoraciones = value;
            }
        }

        public bool Equals(Presupuesto other)
        {
            return (this.fechaRealizacion == other.FechaRealizacion && this.cliente == other.cliente && this.vehiculoComprado == other.vehiculoComprado);
        }

        public override String ToString()
        {
            String presupuesto = "Presupuesto: ";

            presupuesto += "\tFecha: " + fechaRealizacion + "\n";
            presupuesto += "\tCliente: " + this.cliente + "\n";
            presupuesto += "\tEstado: " + this.estado + "\n";
            foreach (KeyValuePair<Vehiculo, double> kvp in this.valoraciones)
            {
                presupuesto += "\t\tVehiculo : " + kvp.Key + ", Precio: " + kvp.Value + "\n";
            }
            presupuesto += "\tVehículo: " + this.vehiculoComprado;

            return (presupuesto);
        }
    }
}

