using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{
    class PersistenciaVehiculo
    {
        //Pre: … 
        //Post: …
        public static void Añadir(Vehiculo vehiculo)
        {
            VehiculoDato vehiculoDato = new VehiculoDato(vehiculo.NumBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.Año, vehiculo.PrecioRecomendado, vehiculo.FechaMatriculacion, vehiculo.Iva, vehiculo.Matricula);
            BD.INSERTVehiculo(vehiculoDato);
        }
        //Pre: … 
        //Post: …
        public static Vehiculo Buscar(Vehiculo vehiculo)
        {
            VehiculoDato vehiculoDato = new VehiculoDato(vehiculo.NumBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.Año, vehiculo.PrecioRecomendado, vehiculo.FechaMatriculacion, vehiculo.Iva, vehiculo.Matricula);
            if (BD.SELECTVehiculo(vehiculoDato))
                return BD.SELECTVehiculo(vehiculoDato);
            else
                return null;
        }
    }
}