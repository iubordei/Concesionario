using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MD
{
    public class SegundaMano : Vehiculo
    {
        private String matricula;
        private DateTime? fechaMatriculacion;
        private float? ivaSegundaMano;

        // PRE: numBastidor != null, marca != null, modelo != null, potencia > 0, año > 0, precioRecom > 0, matricula != null.
        // POS: crea un nuevo elemento de tipo "SegundaMano" con los parámetros pasados al constructor.
        public SegundaMano(String numBastidor, String marca, String modelo, int potencia, int año, float precioRecom, String matricula, DateTime? fechaMatriculacion, float? ivaSegundaMano) : base(numBastidor, marca, modelo, potencia, año, precioRecom)
        {
            this.matricula = matricula;
            this.fechaMatriculacion = fechaMatriculacion;
            this.ivaSegundaMano = ivaSegundaMano;
        }

        // PRE: el objeto SegundaMano ha sido inicializado previamente.
        // POS: get: devuelve una cadena que representa la matrícula del vehículo de segunda mano.
        public String Matricula
        {
            get
            {
                return matricula;
            }
        }

        // PRE: el objeto SegundaMano ha sido inicializado previamente.
        // POS: get: devuelve la fecha de matriculación del vehículo, o null si no ha sido asignada.
        public DateTime? FechaMatriculacion
        {
            get
            {
                return fechaMatriculacion;
            }
        }

        // PRE: el objeto SegundaMano ha sido inicializado previamente.
        // POS: get: devuelve un float con el IVA que se le aplica al vehículo, o null si no ha sido asignado.
        // POS: set: asigna value como el IVA del vehículo.
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

        // PRE: el objeto SegundaMano ha sido inicializado previamente.
        // POS: get: devuelve un float que representa el PVP del vehículo de segunda mano, o null si no ha sido calculado.
        public override float? PVP
        {
            get
            {
                return base.PrecioRecomendado + ivaSegundaMano;
            }
        }

        // PRE: el objeto SegundaMano ha sido inicializado previamente.
        // POS: devuelve una cadena que representa al vehículo, además de su matrícula, fecha de matriculación y PVP.
        public override string ToString()
        {
            String ret = base.ToString();
            return ret += ", matricula: " + Matricula + ", fecha de matriculacion: " + FechaMatriculacion + ", PVP: " + PVP;
        }


    }
}