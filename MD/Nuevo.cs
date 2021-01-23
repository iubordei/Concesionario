using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class Nuevo : Vehiculo
    {
        private List<Extra> extras;
        private float? ivaNuevo;

        // PRE: numBastidor != null, marca != null, modelo != null, potencia > 0, año > 0, precioRecom > 0.
        // POS: crea un nuevo elemento de tipo "Nuevo" con los parámetros pasados al constructor.
        public Nuevo(String numBastidor, String marca, String modelo, int potencia, int año, float precioRecom, List<Extra> extras, float? ivaNuevo) : base(numBastidor, marca, modelo, potencia, año, precioRecom)
        {
            this.extras = extras;
            this.ivaNuevo = ivaNuevo;
        }

        // PRE: el objeto Nuevo ha sido inicializado previamente.
        // POS: get: devuelve una lista formada por todos los elmentos Extra que contiene un vehículo.
        // POS: set: asigna value como la nueva lista de extras del coche nuevo.
        public List<Extra> Extras
        {
            get
            {
                return extras;
            }
            set
            {
                extras = value;
            }
        }

        // PRE: el objeto Nuevo ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el IVA de un vehículo nuevo, o null si no ha sido asignado.
        // POS: set: asigna value como nuevo valor del IVA para un vehículo nuevo.
        public float? IvaNuevo
        {
            get
            {
                return ivaNuevo;
            }
            set
            {
                ivaNuevo = value;
            }
        }

        // PRE: el objeto Nuevo ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el precio de venta del vehículo, o null si no ha sido calculado.
        // POS: set: asigna value como PVP del vehículo nuevo.
        public override float? PVP
        {
            get
            {
                float pvp = (float)(base.PrecioRecomendado + ivaNuevo); // Casteo a float puede ser problemático.
                foreach (Extra extra in extras)
                {
                    pvp += extra.Precio;
                }
                return pvp;
            }
        }

        // PRE: el objeto Nuevo ha sido inicializado previamente.
        // POS: devuelve una cadena que representa el vehículo, sus extras y PVP.
        public override string ToString()
        {
            String ret = base.ToString();
            return ret += ", extras: " + Extras.ToString() + ", PVP: " + PVP;
        }
    }
}
