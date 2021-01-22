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

        // PRE: cliente != null, valoraciones != null, valoraciones contiene por lo menos una valoración.
        // POS: crea un nuevo presupuesto con los parámetros pasados.
        public Presupuesto(DateTime fecha, Cliente cliente, Dictionary<Vehiculo, double> valoraciones)
        {
            this.fechaRealizacion = fecha;
            this.cliente = cliente;
            this.estado = Estado.Pendiente;
            this.vehiculoComprado = null;
            this.valoraciones = valoraciones;
        }

        // PRE: el objeto de tipo Presupuesto debe haber sido inicializado previamente.
        // POS: get: devuelve el cliente asociado al presupuesto.
        public Cliente Cliente
        {
            get
            {
                return (this.cliente);
            }
        }

        // PRE: el objeto de tipo Presupuesto debe haber sido inicializado previamente.
        // POS: get: devuelve el vehiculo comprado del presupuesto.
        // POS: set: establece el vehiculo comprado del presupuesto a value.
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

        // PRE: el objeto de tipo Presupuesto debe haber sido inicializado previamente.
        // POS: get: devuelve la fecha del presupuesto.
        public DateTime FechaRealizacion
        {
            get
            {
                return (this.fechaRealizacion);
            }
        }

        // PRE: el objeto de tipo Presupuesto debe haber sido inicializado previamente.
        // POS: get: devuelve el estado del presupuesto.
        // POS: set: establece el estado del presupuesto a value.
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

        // PRE: el objeto de tipo Presupuesto debe haber sido inicializado previamente.
        // POS: get: devuelve el diccionario de parejas Vehiculo-precio del presupuesto.
        public Dictionary<Vehiculo, double> Valoracion
        {
            get
            {
                return (this.valoraciones);
            }
        }

        // PRE: el objeto de tipo Presupuesto debe haber sido inicializado previamente y other != null.
        // POS: devuelve verdadero si la fecha, cliente y vehiculo comprado de dos presupuestos es la misma, falso en caso contrario.
        public bool Equals(Presupuesto other)
        {
            return (this.fechaRealizacion == other.FechaRealizacion && this.cliente == other.cliente && this.vehiculoComprado == other.vehiculoComprado);
        }

        // PRE: el objeto de tipo Presupuesto debe haber sido inicializado previamente.
        // POS: devuelve una string que representa los datos contenidos en un presupuesto.
        public override String ToString()
        {
            String presupuesto = "Presupuesto: ";

            presupuesto += "\tFecha: " + fechaRealizacion + "\n";
            presupuesto += "\tCliente: " + this.cliente + "\n";
            presupuesto += "\tEstado: " + this.estado + "\n";
            if (this.vehiculoComprado != null)
            {
                presupuesto += "\tVehículo comprado:" + this.vehiculoComprado + "\n";
            }
            foreach (KeyValuePair<Vehiculo, double> kvp in this.valoraciones)
            {
                presupuesto += "\t\tVehiculo : " + kvp.Key + ", Precio: " + kvp.Value + "\n";
            }

            return (presupuesto);
        }
    }
}

