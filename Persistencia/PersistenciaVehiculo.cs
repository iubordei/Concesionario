using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD;

namespace Persistencia
{
    public class PersistenciaVehiculo
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
            VehiculoDato vd = vehiculoAvehiculoDato(vehiculo);
            VehiculoDato res = BD.SELECTVehiculo(vd);
            if (res != null)
            {
                if (res.Matricula == null)
                {
                    return (new MD.Nuevo(res.NumeroDeBastidor, res.Marca, res.Modelo, res.Potencia, res.Año, res.PrecioRecomendado, res.Extras, res.Iva));
                }
                    else
                {
                    return (new MD.SegundaMano(res.NumeroDeBastidor, res.Marca, res.Modelo, res.Potencia, res.Año, res.PrecioRecomendado, res.Matricula, res.FechaMatriculacion, res.Iva));
                }
            }
            else
            {
                return (null);
            }
        }

        public static void Eliminar(Vehiculo vehiculo)
        {
            BD.DELETEVehiculo(vehiculoAvehiculoDato(vehiculo));
        }

        public static void Modificar(Vehiculo vehiculo)
        {
            BD.UPDATEVehiculo(vehiculoAvehiculoDato(vehiculo));
        }

        private static VehiculoDato vehiculoAvehiculoDato(Vehiculo vehiculo)
        {
            return (new VehiculoDato(vehiculo.NumeroDeBastidor, vehiculo.Marca, vehiculo.Modelo, vehiculo.Potencia, vehiculo.Año, vehiculo.PrecioRecomendado, null, null, null));
        }
    }
}