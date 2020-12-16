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
            BD.INSERTVehiculo(vehiculoAvehiculoDato(vehiculo));
        }
        //Pre: … 
        //Post: …
        public static Vehiculo Buscar(Vehiculo vehiculo)
        {
            return (BD.SELECTVehiculo(vehiculoAvehiculoDato(vehiculo)));
        }

        public static void Eliminar(Vehiculo vehiculo)
        {
            BD.DELETEVehiculo(vehiculoAvehiculoDato(vehiculo));
        }

        public static void Modificar(Vehiculo vehiculo)
        {
            BD.UPDATEVehiculo(vehiculoAvehiculoDato(vehiculo));
        }

        private VehiculoDato vehiculoAvehiculoDato(Vehiculo vehiculo)
        {
            return (new VehiculoDato(vehiculo.NumBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.Año, vehiculo.PrecioRecom, vehiculo.Fecha, vehiculo.Iva, vehiculo.Matricula));
        }
    }
}