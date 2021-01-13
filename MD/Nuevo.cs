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

        public Nuevo(String numBastidor, String marca, String modelo, int potencia, int año, float precioRecom, List<Extra> extras, float? ivaNuevo) : base(numBastidor, marca, modelo, potencia, año, precioRecom)
        {
            this.extras = extras;
            this.ivaNuevo = ivaNuevo;
        }

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

        public override float? PVP
        {
            get
            {
                float pvp = (float)(base.PrecioRecomendado + ivaNuevo); // Puede que cause problemas en el futuro (no muy lejano) --> casteo a float
                foreach (Extra extra in extras)
                {
                    pvp += extra.Precio;
                }
                return pvp;
            }
        }
        public override string ToString()
        {
            String ret = base.ToString();
            return ret += ", extras: " + Extras.ToString() + ", PVP: " + PVP;
        }
    }
}
