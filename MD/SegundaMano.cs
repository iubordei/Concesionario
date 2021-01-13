using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class SegundaMano : Vehiculo
    {
        String matricula;
        DateTime? fechaMatriculacion;
        float? ivaSegundaMano;

        public SegundaMano(String numBastidor, String marca, String modelo, int potencia, int año, float precioRecom, String matricula, DateTime? fechaMatriculacion, float? ivaSegundaMano) : base(numBastidor, marca, modelo, potencia, año, precioRecom)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatriculacion;
            this.ivaSegundaMano = ivaSegundaMano;
        }

        public String Matricula
        {
            get
            {
                return matricula;
            }
        }

        public DateTime? FechaMatriculacion
        {
            get
            {
                return fechaMatriculacion;
            }
        }

        public float? IvaSegundaMano
        {
            get
            {
                return ivaSegundaMano;
            }
            set
            {
                ivaSegundaMano = value;
            }
        }

        public override float? PVP
        {
            get
            {
                return base.PrecioRecomendado + ivaSegundaMano;
            }
        }

        public override string ToString()
        {
            String ret = base.ToString();
            return ret += ", matricula: " + Matricula + ", fecha de matriculacion: " + FechaMatriculacion + ", PVP: " + PVP;
        }


    }
}