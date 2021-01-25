using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Persistencia;

namespace LNVehiculo
{
    public class Vehiculo
    {
        //PRE:
        //POST: si el vehiculo no estaba en la base de datos y no es null se añade y devuelve true
        public static bool AltaVehiculo(MD.Vehiculo vehiculo)
        {
            MD.Vehiculo vehiculoFinal;

            if (vehiculo == null)
                return false;

            vehiculoFinal = PersistenciaVehiculo.Buscar(vehiculo);
            if (vehiculoFinal != null)
                return false;

            PersistenciaVehiculo.Añadir(vehiculo);
            return true;
        }

        //PRE:
        //POST: si el vehiculo no estaba en la base de datos y no es null se elimina y devuelve true
        public static bool BajaVehiculo(MD.Vehiculo vehiculo)
        {
            MD.Vehiculo vehiculoFinal;

            if (vehiculo == null)
                return false;

            vehiculoFinal = PersistenciaVehiculo.Buscar(vehiculo);
            if (vehiculoFinal == null)
                return false;

            PersistenciaVehiculo.Eliminar(vehiculo);
            return true;
        }

        // PRE:
        // POS:
        public static MD.Vehiculo GetVehiculo(String num)
        {
            return PersistenciaVehiculo.BuscarNum(num);
        }

        //PRE:
        //POST: devuelve una lista de todos los vehiculos del concesionario, si no hay ninguno la devuelve vacia
        public static List<MD.Vehiculo> GetAllVehiculos()
        {
            return PersistenciaVehiculo.GetAll();
        }

        // PRE:
        // POST: devuelve una lista con todos los vehículos de segunda mano almacenados en la BD.
        public static List<MD.Vehiculo> GetSegundaMano()
        {
            return PersistenciaVehiculo.GetSegundaMano();
        }

        // PRE:
        // POST: devuelve una lista con todos los vehículos nuevos almacenados en la BD.
        public static List<MD.Vehiculo> GetNuevos()
        {
            return PersistenciaVehiculo.GetNuevos();
        }

        //PRE:
        //POST: devuelve una String con los datos del vehiculo
        public static String ShowVehiculo(MD.Vehiculo vehiculo)
        {
            return vehiculo.ToString();
        }

        //PRE:
        //POST: si el extra no estaba en el vehiculo, y no es null se añade y devuelve true, en caso contrario devuelve false
        public static bool AñadirExtra(MD.Nuevo vehiculo, MD.Extra newExtra)
        {
            List<MD.Extra> extras = vehiculo.Extras;
            if (newExtra == null)
                return false;
            foreach (MD.Extra extra in extras)
            {
                if (extra.Equals(newExtra))
                    return false;
            }
            extras.Add(newExtra);
            vehiculo.Extras = extras;
            return true;
        }
    }
}